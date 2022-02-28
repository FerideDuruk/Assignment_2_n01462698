using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2_n01462698.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Count all possible dice combinations that add up to 10
        /// </summary>
        /// <param name="m">input for max sides for dice 1</param>
        /// <param name="n">input for max sides for dice 2</param>
        /// <returns>
        /// GET : /api/J2/DiceGame/5/6 ->
        /// 2 (combinations returned)
        /// </returns>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int TotalTenCombinations = 0;
            int mSide = 1;
            int nSide = 1;

            // iterate through all side of dice 1
            while(mSide <= m)
            {
                // iterate through all sides of dice 2
                while(nSide <= n)
                {
                    // if two dice add up to 10, increment the combinations counter
                    if (mSide+nSide == 10)
                    {
                        TotalTenCombinations = TotalTenCombinations + 1;
                    }
                    nSide = nSide + 1;
                }
                nSide = 1;
                mSide = mSide + 1;
            }


            return TotalTenCombinations.ToString();
        }
            

    }
}

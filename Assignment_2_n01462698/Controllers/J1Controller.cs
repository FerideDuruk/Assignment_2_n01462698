using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2_n01462698.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Count all calories for all 4 items on the menu
        /// </summary>
        /// <param name="burger">input of burger choice index</param>
        /// <param name="drink">input of drink choice index</param>
        /// <param name="side">input of side choice index</param>
        /// <param name="dessert">input of dessert choice index</param>
        /// <returns>
        /// GET : /api/J1/Menu/1/2/3/4 ->
        /// 691 (total calories)
        /// </returns>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int TotalCalories = 0;
            int BurgerCalories = 0;
            int DrinkCalories = 0;
            int SideCalories = 0;
            int DessertCalories = 0;
            string message = "invalid input";

            // determine calorie count based on user choice
            if (burger == 1)
            {
                BurgerCalories = 461;
            }
            else if (burger == 2)
            { 
                BurgerCalories = 431;
            }
            else if (burger == 3)
            { 
                BurgerCalories = 420;
            }
            else if (burger == 4)
            {
                BurgerCalories = 0;
             }
            // invalid message is displayed for out of bounds options
            else if (burger <= 0 || burger > 4)
            { 
                return burger.ToString()+ " is "+ message;
            }


            if (drink == 1)
            {
                DrinkCalories = 130;
            }
            else if (drink == 2)
            {
                DrinkCalories = 160;
            }
            else if (drink == 3)
            {
                DrinkCalories = 118;
            }
            else if (drink == 4)
            {
                DrinkCalories = 0;
            }
            else if (drink <= 0 || drink > 4)
            {
                return drink.ToString() + " is " + message;
            }


            if (side == 1)
            {
                SideCalories = 100;
            }
            else if (side == 2)
            {
                SideCalories = 57;
            }
            else if (side == 3)
            {
                SideCalories = 70;
            }
            else if (side == 4)
            {
                SideCalories = 0;
            }
            else if (side <= 0 || side > 4)
            {
                return side.ToString() + " is " + message;
            }


            if (dessert == 1)
            {
                DessertCalories = 167;
            }
            else if (dessert == 2)
            {
                DessertCalories = 266;
            }
            else if (dessert == 3)
            {
                DessertCalories = 75;
            }
            else if (dessert == 4)
            {
                DessertCalories = 0;
            }
            else if (dessert <= 0 || dessert > 4)
            {
                return dessert.ToString() + " is " + message;
            }

            // Calculate the total of all calories for all options
            TotalCalories = BurgerCalories + DrinkCalories + SideCalories + DessertCalories;
            return TotalCalories.ToString();
        }


    }

}

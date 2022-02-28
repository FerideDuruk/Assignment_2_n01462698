using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2_n01462698.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Count the time in seconds to type each word on the phone
        /// </summary>
        /// <param name="word1">input word 1</param>
        /// <param name="word2">input word 2</param>
        /// <param name="word3">input word 3</param>
        /// <param name="stopWord">input word "halt"</param>
        /// <returns>
        /// GET : /api/J3/WordTimer/cat/dog/fox/halt ->
        /// 5, 5, 8
        /// </returns>
        [HttpGet]
        [Route("api/J3/WordTimer/{word1}/{word2}/{word3}/{stopWord}")]
        public string WordTimer(string word1, string word2, string word3, string stopWord)
        {
            int stopWordTime = 7;
            int i = 0;
            int j = 0;

            string SelectedWord = "";
            int SelectedWordLength = 0;
            int SelectedWordTime = 0;
            string AllTimes = "";
            string[] WordArray = {word1, word2, word3};

            char[] CharArray1 = { 'a', 'd', 'g', 'j', 'm', 'p', 't', 'w' };
            char[] CharArray2 = { 'b', 'e', 'h', 'k', 'n', 'q', 'u', 'x' };
            char[] CharArray3 = { 'c', 'f', 'i', 'l', 'o', 'r', 'v', 'y' };
            char[] CharArray4 = { 's', 'z' };

            // iterate through words array
            while (i <= WordArray.Length - 1)
            {
                SelectedWord = WordArray[i];

                SelectedWordLength = SelectedWord.Length;

                // iterate through word letters array
                for (j=0; j <= SelectedWordLength - 1; j++)
                {
                    // if word letter is found in the array, compare them
                    if (SelectedWord[j] == Array.Find(CharArray1, element => element == SelectedWord[j]))
                    {
                        SelectedWordTime = SelectedWordTime + 1;
                    }
                    else if (SelectedWord[j] == Array.Find(CharArray2, element => element == SelectedWord[j]))
                    {
                        SelectedWordTime = SelectedWordTime + 2;
                    }
                    else if (SelectedWord[j] == Array.Find(CharArray3, element => element == SelectedWord[j]))
                    {
                        SelectedWordTime = SelectedWordTime + 3;
                    }
                    else if (SelectedWord[j] == Array.Find(CharArray4, element => element == SelectedWord[j]))
                    {
                        SelectedWordTime = SelectedWordTime + 4;
                    }
                }
                // concatenate word times
                AllTimes = AllTimes +", "+ SelectedWordTime.ToString();
                SelectedWordTime = 0;
                i = i + 1;
            }

            return AllTimes;
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Int2TextProject
{
    public class Int2Text
    {
        List<string> NumbersBelowTwenty = new List<string>() { "Zero", "One", "Two", "Three", "Four", "Five", 
            "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", 
            "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        List<string> Tens = new List<string> { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", 
            "Eighty", "Ninety" };

        Dictionary<int, string> OneHundredAbove = new Dictionary<int, string>() { 
            { 100, "Hundred" },
            { 1000, "Thousand" },
            { 1000000, "Million" },
            { 1000000000, "Billion" },
            };

        /// <summary>
        /// Constructor
        /// </summary>
        public Int2Text()
        {
        }


        /// <summary>
        /// Take an int number and convert it to text with the number spelled.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string Convert(int num)
        {
 
            string result = "";

            if (num > 19)
            {
                if(num <= 99)
                    return (Tens[num / 10 - 2] + ((num % 10 == 0) ? "" : "-" + Convert(num % 10))).Trim();


                int tensPlace = 0;

                foreach (int key in OneHundredAbove.Keys)
                {
                    if (num >= key)
                    {
                        tensPlace = key;
                    }
                }

                return (Convert(num / tensPlace) + " " + OneHundredAbove[tensPlace] + " " + ((num % tensPlace == 0) ? "" : Convert(num % tensPlace))).Trim();
            }
                
            return NumbersBelowTwenty[num];
        }
    }
}

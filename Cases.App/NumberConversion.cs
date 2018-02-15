using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cases.App
{

    public class NumberConversion
    {

        public string ToRoman(int number)
        {
            var returnValue = new StringBuilder(5);
            var numberDictionary = new SortedDictionary<int, string>
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M" },
        };

            foreach (var intRomanPair in numberDictionary.Reverse())
            {
                while (number >= intRomanPair.Key)
                {
                    number -= intRomanPair.Key;
                    returnValue.Append(intRomanPair.Value);
                }
            }

            return returnValue.ToString();
        }
    }
}




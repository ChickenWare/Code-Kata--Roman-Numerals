using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_Roman_Convertor
{
    public class RomanNumeral
    {

        private Dictionary<string, int> arabByRomanNumber = new Dictionary<string, int> 
        {
            {"M", 1000},
            {"CM",900},
            {"D",500},
            {"CD",400},
            {"C",100},
            {"XC",90},
            {"L",50},
            {"XL", 40},
            {"X", 10},
            {"IX",9},
            {"V", 5},
            {"IV",4},
            {"I",1}
        };

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public string convertTo(int input)
        {
            string output = string.Empty;

            foreach (string romanNumber in arabByRomanNumber.Keys)
            {
                int arabNumber = arabByRomanNumber[romanNumber];
                while (input >= arabNumber)
                {
                    input -= arabNumber;
                    output += romanNumber;
                }
            }

            return output;
        }
    }
}
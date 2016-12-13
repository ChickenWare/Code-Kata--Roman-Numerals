using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_Roman_Convertor
{
    public class RomanNumeral
    {
        private int[] specialCasesArabNotation = { 1000, 900, 500, 400,100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private string[] specialCasesRomanNotation = {"M", "CM","D","CD","C","XC","L","XL", "X", "IX","V", "IV", "I" };

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public string convertTo(int input)
        {
            string output = string.Empty;
            foreach (string romanNumber in specialCasesRomanNotation)
            {
                int indexOfRomanNumber = Array.IndexOf(specialCasesRomanNotation, romanNumber);
                int arabNumber = specialCasesArabNotation[indexOfRomanNumber];

                while (input >= arabNumber && input != 0)
                {
                    input -= arabNumber;
                    if (input < 0)
                    {
                        output += convertTo(Math.Abs(input));
                    }
                    output += romanNumber;
                }
            }

            return output;
        }
    }
}
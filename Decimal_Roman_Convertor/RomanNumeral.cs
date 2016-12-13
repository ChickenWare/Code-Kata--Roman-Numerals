using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_Roman_Convertor
{
    public class RomanNumeral
    {
        private int[] specialCasesArabNotation = {50,10,5,1};
        private string[] specialCasesRomanNotation = {"L","X","V","I"};

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

                int specialCaseTriggeringNumber = 1;
                if (indexOfRomanNumber != specialCasesRomanNotation.Length -1 )
                    specialCaseTriggeringNumber = specialCasesArabNotation[indexOfRomanNumber + 1];
                //specialCaseTriggeringNumber
                while (input >= arabNumber - 1 && input !=0 )
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

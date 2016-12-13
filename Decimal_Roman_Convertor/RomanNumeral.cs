using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_Roman_Convertor
{
    public class RomanNumeral
    {
        private int[] specialCasesArabNotation = {1,4,9};
        private string[] specialCasesRomanNotation = {"I","V","X"};

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public string convertTo(int input)
        {
            string output = string.Empty;

            while (input > 9)
            {
                output += "X";
                input -= 10;
            }

            if (input == 9)
            {
                output += "IX";
                return output;
            }


            while (input > 4)
            {
                output += "V";
                input -= 5;
            }

            if (input == 4)
            {
                output += "IV";
                return output;
            }
          
            output += convertToI(input);
            
            //The number was build in reverse order. Print it correct way.
            //output = reverseString(output);

            return output;
        }

        public string convertToI(int input)
        {
            if (input < 0)
                return string.Empty;

            string output = string.Empty;

            for (int i = 0; i < input; ++i)
                output = "I" + output;

            return output;
        }

        public string reverseString(string stringToReverse)
        {
            if (stringToReverse == "")
                return string.Empty;
    
            char[] arr = stringToReverse.ToCharArray();
	        Array.Reverse(arr);

	        return new string(arr);
        }
    }
}

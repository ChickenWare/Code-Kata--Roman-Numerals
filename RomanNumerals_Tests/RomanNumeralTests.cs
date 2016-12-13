using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Decimal_Roman_Convertor
{
    [TestClass]
    public class RomanNumeralTests
    {
        private RomanNumeral DeciToRomanConvertor;

        [TestInitialize]
        public void TestInitialize()
        {
            DeciToRomanConvertor = new RomanNumeral();
        }

        [TestCleanup]
        public void Testcleanup()
        {
            DeciToRomanConvertor.Dispose();
        }


        [TestMethod]
        public void convertTo_OTo20_OTo20()
        {
            int[] input = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            string[] expected = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII", "XIII", "XIV", "XV", "XVI", "XVII", "XVIII", "XIX", "XX"};

            for (int i = 0; i < expected.Length - 1; i++)
            {
                string actual = DeciToRomanConvertor.convertTo(input[i]);
                Assert.AreEqual(expected[i], actual);
            } 
        }

        [TestMethod]
        public void convertTo_Random_Random()
        {
            int[] input = { 50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,
                              70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,
                              89,90,91,92,93,94,95,96,97,98,99,100,200,300,400,500,600,700,
                              800,900};
            string[] expected = {"L","LI","LII","LIII","LIV","LV","LVI","LVII","LVIII","LIX",
                                    "LX","LXI","LXII","LXIII","LXIV","LXV","LXVI","LXVII","LXVIII",
                                    "LXIX","LXX","LXXI","LXXII","LXXIII","LXXIV","LXXV","LXXVI","LXXVII",
                                    "LXXVIII","LXXIX","LXXX","LXXXI","LXXXII","LXXXIII","LXXXIV",
                                    "LXXXV","LXXXVI","LXXXVII","LXXXVIII","LXXXIX","XC","XCI","XCII",
                                    "XCIII","XCIV","XCV","XCVI","XCVII","XCVIII","XCIX","C","CC","CCC",
                                    "CD","D","DC","DCC","DCCC","CM" };

            for (int i = 0; i < expected.Length - 1; i++)
            {
                string actual = DeciToRomanConvertor.convertTo(input[i]);
                Assert.AreEqual(expected[i], actual);
            }
        }

        
        [TestMethod]
        public void convertTo_34_XXXIV()
        {
            int input = 34;
            string expected = "XXXIV";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_35_XXXV()
        {
            int input = 35;
            string expected = "XXXV";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_39_XXXIX()
        {
            int input = 39;
            string expected = "XXXIX";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_40_XL()
        {
            int input = 40;
            string expected = "XL";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_44_XLIV()
        {
            int input = 44;
            string expected = "XLIV";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_45_XLV()
        {
            int input = 45;
            string expected = "XLV";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }


    }
}

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
        public void convertTo_zero_empty()
        {
            int input = 0;
            string expected = "";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_1_I()
        {
            int input = 1;
            string expected = "I";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_2_II()
        {
            int input = 2;
            string expected = "II";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void convertTo_3_III()
        {
            int input = 3;
            string expected = "III";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_4_IV()
        {
            int input = 4;
            string expected = "IV";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_5_V()
        {
            int input = 5;
            string expected = "V";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_6_VI()
        {
            int input = 6;
            string expected = "VI";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_7_VII()
        {
            int input = 7;
            string expected = "VII";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_8_VIII()
        {
            int input = 8;
            string expected = "VIII";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_9_IX()
        {
            int input = 9;
            string expected = "IX";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_10_X()
        {
            int input = 10;
            string expected = "X";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_11_XI()
        {
            int input = 11;
            string expected = "XI";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_14_XIV()
        {
            int input = 14;
            string expected = "XIV";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_16_XVI()
        {
            int input = 16;
            string expected = "XVI";

            string actual = DeciToRomanConvertor.convertTo(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertTo_19_XIX()
        {
            int input = 19;
            string expected = "XIX";

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

        #region Helpers
        [TestMethod]
        public void reverseString_Imlegend_dnegelmI()
        {
            string input = "Imlegend";
            string expected = "dnegelmI";

            string actual = DeciToRomanConvertor.reverseString(input);

            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}

using NUnit.Framework;
using Cases.App;

namespace Cases.Test
{
    [TestFixture]
    public class RomanNumeralConversionTests
    {

        [Test]
        public void Convert_Number_One_To_Roman_Numeral_I()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(1);
            var expected = "I";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_Number_Four_To_Roman_Numeral_IV()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(4);
            var expected = "IV";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_Number_Five_To_Roman_Numeral_V()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(5);
            var expected = "V";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_Number_Nine_To_Roman_Numeral_IX()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(9);
            var expected = "IX";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_Number_Ten_To_Roman_Numeral_X()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(10);
            var expected = "X";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_Number_Fourty_To_Roman_Numeral_XL()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(40);
            var expected = "XL";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_Number_Fifty_To_Roman_Numeral_L()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(50);
            var expected = "L";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_Number_Ninety_To_Roman_Numeral_XC()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(90);
            var expected = "XC";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_Number_One_Hundred_To_Roman_Numeral_C()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(100);
            var expected = "C";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_Number_Four_Hundred_To_Roman_Numeral_CD()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(400);
            var expected = "CD";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_Number_Five_Hundred_To_Roman_Numeral_D()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(500);
            var expected = "D";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_Number_Nine_Hundred_To_Roman_Numeral_CM()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(900);
            var expected = "CM";

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_Number_One_Thousand_To_Roman_Numeral_M()
        {
            var numberConversion = new NumberConversion();
            var results = numberConversion.ToRoman(1000);
            var expected = "M";

            Assert.AreEqual(expected, results);
        }
    }
}

  


using NUnit.Framework;
using Tyuiu.LeushinP.Sprint3.Task3.V18.Lib;

namespace Tyuiu.LeushinP.Sprint3.Task3.V18.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ReplaceNumOnChar_ReplacesAllDigitsWithGivenChar()
        {
            DataService ds = new DataService();

            string input = "4n5nvf 56 bgy";
            char replaceWith = 'n';

            string result = ds.ReplaceNumOnChar(input, replaceWith);

            string expected = "nnnnvf nn bgy";
            Assert.AreEqual(expected, result, "Цифры должны быть заменены на символ 'n'");
        }

        [Test]
        public void ReplaceNumOnChar_NoDigits_ReturnsSameString()
        {
            DataService ds = new DataService();

            string input = "abc def g";
            char replaceWith = 'n';

            string result = ds.ReplaceNumOnChar(input, replaceWith);

            Assert.AreEqual(input, result);
        }

        [Test]
        public void ReplaceNumOnChar_Null_ThrowsArgumentNullException()
        {
            DataService ds = new DataService();

            Assert.Throws<System.ArgumentNullException>(() => ds.ReplaceNumOnChar(null, 'n'));
        }
    }
}
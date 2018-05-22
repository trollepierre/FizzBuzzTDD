using FizzBuzz.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzerTests
    {
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(14)]
        [DataRow(16)]
        [DataRow(17)]
        [DataRow(19)]
        public void DefaultTest(int input)
        {
            var result = FizzBuzzer.FizzBuzz(input);
            Assert.AreEqual(input.ToString(), result);
        }
    }
}

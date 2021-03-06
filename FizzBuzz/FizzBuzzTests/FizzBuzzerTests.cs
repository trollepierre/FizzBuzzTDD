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

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(9)]
        [DataRow(12)]
        [DataRow(18)]
        public void Div3Test(int input)
        {
            var result = FizzBuzzer.FizzBuzz(input);
            Assert.AreEqual("Fizz", result);
        }

        [DataTestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(20)]
        public void Div5Test(int input)
        {
            var result = FizzBuzzer.FizzBuzz(input);
            Assert.AreEqual("Buzz", result);
        }

        [DataTestMethod]
        [DataRow(15)]
        [DataRow(30)]
        [DataRow(45)]
        [DataRow(60)]
        public void Div5AndDiv3Test(int input)
        {
            var result = FizzBuzzer.FizzBuzz(input);
            Assert.AreEqual("FizzBuzz", result);
        }

    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Test
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz fizzBuzz;
        [SetUp]
        public void Setup()
        {
            fizzBuzz= new FizzBuzz();
        }
        [TearDown]
        public void TearDown()
        {
            fizzBuzz = null;
        }
        [TestCase("Fizz",3)]
        [TestCase("Buzz", 5)]
        [TestCase("FizzBuzz", 15)]
        public void FizzBuzzTest_Returns_FizzBuzz(string expected, int number)
        {
            Assert.That(FizzBuzz.Ask(number), Is.EqualTo(expected));
        }
       
    }
}

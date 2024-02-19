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
        [Test]
        public void FizzBuzzTest_Returns_FizzBuzz()
        {
            var result = FizzBuzz.Ask(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void FizzBuzzTest_Returns_Buzz()
        {
            var result = FizzBuzz.Ask(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        public void FizzBuzzTest_Returns_Fizz()
        {
            var result = FizzBuzz.Ask(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }
    }
}

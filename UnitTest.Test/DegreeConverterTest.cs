using NUnit.Framework;
using System.Collections;

namespace UnitTest.Test
{
    [TestFixture]
    public class DegreeConverterTest
    {
        private DegreeConverter _degreeConverter;
        [SetUp]
        public void Setup()
        {
            _degreeConverter = new DegreeConverter();
        }
        [TearDown]
        public void Teardown()
        {
            _degreeConverter = null;
        }
        [Test]
        public void ToFahrenheit_ZeroCelcius_Return32()
        {
            double result = _degreeConverter.ToFahrenheit(0);

            Assert.That(result, Is.EqualTo(32));
        }
        [Test]
        public void ToCelcius_1Fahreneit_Return0()
        {
            double result = _degreeConverter.ToCelcius(1);

            Assert.That(result,Is.EqualTo(0));
        }
        [TestCase(1,0)]
        public void ToCelcius_Fahreneit_With_Params(double value, double expectedValue)
        {
            double result = _degreeConverter.ToCelcius(value);

            Assert.That(result, Is.EqualTo(expectedValue));
        }
        [TestCaseSource(typeof(DegreeConverterSource))]
        public void ToCelcius_Fahreneit_With_TestCase(double value, double expectedValue)
        {
            double result = _degreeConverter.ToCelcius(value);

            Assert.That(result, Is.EqualTo(expectedValue));
        }
        public class DegreeConverterSource : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new double[] { 1, 0 };
            }
        }
    }
}

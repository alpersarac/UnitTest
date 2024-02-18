﻿using NUnit.Framework;

namespace UnitTest.Test
{
    [TestFixture]
    public class DegreeConverterTest
    {
        [Test]
        public void ToFahrenheit_ZeroCelcius_Return32()
        {
            var converter = new DegreeConverter();
            double result = converter.ToFahrenheit(0);

            Assert.That(result, Is.EqualTo(32));
        }
        [Test]
        public void ToCelcius_1Fahreneit_Return0()
        {
            var converter = new DegreeConverter();
            double result = converter.ToCelcius(1);

            Assert.That(result,Is.EqualTo(0));
        }
    }
}
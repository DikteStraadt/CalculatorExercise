using System;
using NUnit.Framework;
using CalculatorExercise;

namespace CalculatorTest
{
    [TestFixture]
    public class UnitTest
    {
        private Calculator uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Calculator();
        }

        [TestCase(1,2,3)]
        [TestCase(-1, 2, 1)]
        [TestCase(-1, -2, -3)]
        public void Test_Add(double a, double b, double output)
        {
            Assert.That(uut.Add(a,b), Is.EqualTo(output));
        }

        [TestCase(1, 2, -1)]
        [TestCase(-1, 2, -3)]
        [TestCase(-1, -2, 1)]
        public void Test_Substract(double a, double b, double output)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(output));
        }

        [TestCase(1, 2, 2)]
        [TestCase(-1, 2, -2)]
        [TestCase(-1, -2, 2)]
        public void Test_Multiply(double a, double b, double output)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(output));
        }

        [TestCase(1, 2, 1)]
        [TestCase(-1, 2, 1)]
        [TestCase(-1, -2, 1)]
        public void Test_Power(double x, double exp, double output)
        {
            Assert.That(uut.Power(x, exp), Is.EqualTo(output));
        }

        [TestCase(1, 2, 3)]
        [TestCase(4, 2, 6)]
        public void FestMedTest(double a, double b, double output)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(output));
        }

    }
}

using HW_9;
using NUnit.Framework;
using System;

namespace HW_9_tests
{
    [TestFixture]
    class ScientificCalculatorTest : CalculatorTest
    {
        ScientificCalculator scientificCalculator = new ScientificCalculator();

        [SetUp]
        public void ResetDataSetup()
        {
            TestArgument1 = 0;
            TestArgument2 = 0;
            TestArgument3 = 0;
            TestResult = 0;
        }

        [Test, Order(1)]
        public void ExponentiationTest()
        {
            TestArgument1 = 2;
            TestArgument2 = 3;
            TestResult = 8;
            scientificCalculator.Exponentiate(TestArgument1, TestArgument2);
            Assert.That(TestResult, Is.EqualTo(scientificCalculator.Result));
        }

        [Test]
        [Repeat(5)]
        public void ExponentiationTestNegativeBase()
        {
            TestArgument1 = -2;
            TestArgument2 = 3;
            scientificCalculator.Exponentiate(TestArgument1, TestArgument2);
            Assert.That(scientificCalculator.Result, Is.LessThan(0));
        }

        [Test]
        [Retry(5)]
        public void ExponentiationTestNegativeExponent()
        {
            TestArgument1 = 2;
            TestArgument2 = -3;
            TestResult = 0.125;
            scientificCalculator.Exponentiate(TestArgument1, TestArgument2);
            Assert.That(TestResult, Is.EqualTo(scientificCalculator.Result));
        }

        [Test]
        public void ExponentiationTestZeroExponent()
        {
            TestArgument1 = 2;
            TestArgument2 = 0;
            TestResult = 1;
            scientificCalculator.Exponentiate(TestArgument1, TestArgument2);
            Assert.That(TestResult, Is.EqualTo(scientificCalculator.Result));
        }

        [Test]
        public void ExponentiationTestZeroBase()
        {
            TestArgument1 = 0;
            TestArgument2 = 5;
            scientificCalculator.Exponentiate(TestArgument1, TestArgument2);
            Assert.That(scientificCalculator.Result, Is.EqualTo(0));
        }

        [Test, Order(2)]
        public void CalculatePercentageTest()
        {
            TestArgument1 = 5;
            TestArgument2 = 25;
            TestResult = 20;
            scientificCalculator.CalculatePercentage(TestArgument1, TestArgument2);
            Assert.That(TestResult, Is.EqualTo(scientificCalculator.Result));
        }

        [Test]
        public void CalculatePercentageToZeroTest()
        {
            TestArgument1 = 0;
            TestArgument2 = 5;
            scientificCalculator.CalculatePercentage(TestArgument1, TestArgument2);
            Assert.That(scientificCalculator.Result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateModuleTestPositiveInput()
        {
            TestArgument1 = 5;
            scientificCalculator.CalculateModule(TestArgument1);
            Assert.That(scientificCalculator.Result, Is.GreaterThan(0));
        }

        [Test, Order(3)]
        public void CalculateModuleTestNegativeInput()
        {
            TestArgument1 = -5;
            scientificCalculator.CalculateModule(TestArgument1);
            Assert.That(scientificCalculator.Result, Is.GreaterThan(0));
        }

        [Test]
        [Ignore("Meaningless test")]
        public void CalculateModuleZeroTest()
        {
            TestArgument1 = 0;
            scientificCalculator.CalculateModule(TestArgument1);
            Assert.That(scientificCalculator.Result, Is.EqualTo(0));
        }

        [Test, Order(4)]
        public void CalculateSumOfArrayTest()
        {
            TestArgument1 = 3;
            TestArgument2 = 1;
            TestArgument3 = 4;
            TestResult = 8;
            scientificCalculator.CalculateSumOfArray(TestArgument1, TestArgument2, TestArgument3);
            Assert.That(TestResult, Is.EqualTo(scientificCalculator.Result));
        }

        [Test, Order(5)]
        public void FindMinimumTest()
        {
            TestArgument1 = 6;
            TestArgument2 = 2;
            TestArgument3 = 5;
            TestResult = 2;
            scientificCalculator.FindMinimum(TestArgument1, TestArgument2, TestArgument3);
            Assert.That(TestResult, Is.EqualTo(scientificCalculator.Result));
        }

        [Test, Order(6)]
        public void FindMaximumTest()
        {
            TestArgument1 = 6;
            TestArgument2 = 2;
            TestArgument3 = 5;
            TestResult = 6;
            scientificCalculator.FindMaximum(TestArgument1, TestArgument2, TestArgument3);
            Assert.That(TestResult, Is.EqualTo(scientificCalculator.Result));
        }

        [Test, Order(7)]
        public void CalculateAverageTest()
        {
            TestArgument1 = 6;
            TestArgument2 = 3;
            TestArgument3 = 12;
            TestResult = 7;
            scientificCalculator.CalculateAverage(TestArgument1, TestArgument2, TestArgument3);
            Assert.That(TestResult, Is.EqualTo(scientificCalculator.Result));
        }

        [TestCase(5, -5, 0, ExpectedResult = -5)]
        [TestCase(5, 5, 5, ExpectedResult = 5)]
        [TestCase(-5, -5.123456789, -5.1, ExpectedResult = -5.123456789)]
        [TestCase(-10000000000, 10000000000, 0, ExpectedResult = -10000000000)]
        public double FindMinimumTestExtended(double testArgument1, double testArgument2, double testArgument3)
        {
            scientificCalculator.FindMinimum(testArgument1, testArgument2, testArgument3);
            return scientificCalculator.Result;
        }

        [TestCase(5, -5, 0, ExpectedResult = 0)]
        [TestCase(-5, -5.123456789, -10000000000, ExpectedResult = -10000000010.123456789)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        public double CalculateSumOfArrayTestExtended(double testArgument1, double testArgument2, double testArgument3)
        {
            scientificCalculator.CalculateSumOfArray(testArgument1, testArgument2, testArgument3);
            return scientificCalculator.Result;
        }

        [TestCase(1, 10, ExpectedResult = 1)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(0, 0, ExpectedResult = 1)]
        [TestCase(10, 5, ExpectedResult = 100000)]
        [TestCase(-5, -2, ExpectedResult = 0.04)]
        public double ExponentiationTestExtended(double testArgument1, double testArgument2)
        {
            scientificCalculator.Exponentiate(testArgument1, testArgument2);
            return scientificCalculator.Result;
        }

        [Test, Timeout(10)]
        public void ExponentiationTestBigNumbers()
        {
            TestArgument1 = 9999999999999999999;
            TestArgument2 = 10;
            scientificCalculator.Exponentiate(TestArgument1, TestArgument2);
            TestResult = 1.0000000000000001E+190d;
            Assert.That(TestResult, Is.EqualTo(scientificCalculator.Result));
        }

        [Test, MaxTime(10)]
        public void ExponentiationTestBigNegaviveNumbers()
        {
            TestArgument1 = -999999999999999999;
            TestArgument2 = -10;
            scientificCalculator.Exponentiate(TestArgument1, TestArgument2);
            TestResult = 1E-180d;
            Assert.That(TestResult, Is.EqualTo(scientificCalculator.Result));
        }

        [Test]
        public void CalculateModuleTestToFail()
        {
            TestArgument1 = -5;
            scientificCalculator.CalculateModule(TestArgument1);
            Assert.That(scientificCalculator.Result, Is.LessThan(0));
        }

        [Test]
        public void CalculateSquareTest()
        {
            TestArgument1 = 4;
            TestResult = 2;
            scientificCalculator.CalculateSquare(TestArgument1);
            Assert.That(TestResult, Is.EqualTo(scientificCalculator.Result));
        }

        [Test]
        public void CalculateSquareMessageTest()
        {
            TestArgument1 = -5;
            scientificCalculator.CalculateSquare(TestArgument1);
            StringAssert.StartsWith("Argument should be", scientificCalculator.Message);
        }

        [Test]
        public void CalculateFactorialTest()
        {
            TestArgument1 = 5;
            TestResult = 120;
            scientificCalculator.CalculateFactorial(TestArgument1);
            Assert.That(TestResult, Is.EqualTo(scientificCalculator.Result));
        }

        [Test]
        public void CalculateFactorialTestNegativeNumbers()
        {
            TestArgument1 = -5;
            scientificCalculator.CalculateFactorial(TestArgument1);
            StringAssert.AreEqualIgnoringCase("Argument should be greater or equal to Zero", scientificCalculator.Message);
        }

        [Test]
        public void CalculateFactorialTestDecimals()
        {
            TestArgument1 = 3.25;
            scientificCalculator.CalculateFactorial(TestArgument1);
            StringAssert.Contains("natural", scientificCalculator.Message);
        }

        [TearDown]
        public void ResetDataTeardown()
        {
            TestArgument1 = 0;
            TestArgument2 = 0;
            TestArgument3 = 0;
            TestResult = 0;
        }
    }
}
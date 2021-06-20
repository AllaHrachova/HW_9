using HW_9;
using NUnit.Framework;
using System;

namespace HW_9_tests
{
    [TestFixture]
    class ScientificCalculatorTest : CalculatorTest
    {
        ScientificCalculator scientificCalculator = new ScientificCalculator();
        [Test]
        public void ExponentiationTest()
        {
            TestArgument1 = 2;
            TestArgument2 = 3;
            TestResult = 8;
            scientificCalculator.Exponentiate(TestArgument1, TestArgument2);
            Assert.AreEqual(TestResult, scientificCalculator.Result);
        }

        [Test]
        public void ExponentiationTestNegativeBase()
        {
            TestArgument1 = -2;
            TestArgument2 = 3;
            scientificCalculator.Exponentiate(TestArgument1, TestArgument2);
            Assert.Negative(scientificCalculator.Result);
        }

        [Test]
        public void ExponentiationTestNegativeExponent()
        {
            TestArgument1 = 2;
            TestArgument2 = -3;
            TestResult = 0.125;
            scientificCalculator.Exponentiate(TestArgument1, TestArgument2);
            Assert.AreEqual(TestResult, scientificCalculator.Result);
        }

        [Test]
        public void ExponentiationTestZeroExponent()
        {
            TestArgument1 = 2;
            TestArgument2 = 0;
            TestResult = 1;
            scientificCalculator.Exponentiate(TestArgument1, TestArgument2);
            Assert.AreEqual(TestResult, scientificCalculator.Result);
        }

        [Test]
        public void ExponentiationTestZeroBase()
        {
            TestArgument1 = 0;
            TestArgument2 = 5;
            scientificCalculator.Exponentiate(TestArgument1, TestArgument2);
            Assert.Zero(scientificCalculator.Result);
        }

        [Test]
        public void CalculatePercentageTest()
        {
            TestArgument1 = 5;
            TestArgument2 = 25;
            TestResult = 20;
            scientificCalculator.CalculatePercentage(TestArgument1, TestArgument2);
            Assert.AreEqual(TestResult, scientificCalculator.Result);
        }

        [Test]
        public void CalculatePercentageToZeroTest()
        {
            TestArgument1 = 0;
            TestArgument2 = 5;
            scientificCalculator.CalculatePercentage(TestArgument1, TestArgument2);
            Assert.Zero(scientificCalculator.Result);
        }

        [Test]
        public void CalculateModuleTestPositiveInput()
        {
            TestArgument1 = 5;
            scientificCalculator.CalculateModule(TestArgument1);
            Assert.Positive(scientificCalculator.Result);
        }

        [Test]
        public void CalculateModuleTestNegativeInput()
        {
            TestArgument1 = -5;
            scientificCalculator.CalculateModule(TestArgument1);
            Assert.Positive(scientificCalculator.Result);
        }

        [Test]
        public void CalculateModuleZeroTest()
        {
            TestArgument1 = 0;
            scientificCalculator.CalculateModule(TestArgument1);
            Assert.Zero(scientificCalculator.Result);
        }

        [Test]
        public void CalculateSumOfArrayTest()
        {
            TestArgument1 = 3;
            TestArgument2 = 1;
            TestArgument3 = 4;
            TestResult = 8;
            scientificCalculator.CalculateSumOfArray(TestArgument1, TestArgument2, TestArgument3);
            Assert.AreEqual(TestResult, scientificCalculator.Result);
        }

        [Test]
        public void FindMinimumTest()
        {
            TestArgument1 = 6;
            TestArgument2 = 2;
            TestArgument3 = 5;
            TestResult = 2;
            scientificCalculator.FindMinimum(TestArgument1, TestArgument2, TestArgument3);
            Assert.AreEqual(TestResult, scientificCalculator.Result);
        }

        [Test]
        public void FindMaximumTest()
        {
            TestArgument1 = 6;
            TestArgument2 = 2;
            TestArgument3 = 5;
            TestResult = 6;
            scientificCalculator.FindMaximum(TestArgument1, TestArgument2, TestArgument3);
            Assert.AreEqual(TestResult, scientificCalculator.Result);
        }

        [Test]
        public void CalculateAverageTest()
        {
            TestArgument1 = 6;
            TestArgument2 = 3;
            TestArgument3 = 12;
            TestResult = 7;
            scientificCalculator.CalculateAverage(TestArgument1, TestArgument2, TestArgument3);
            Assert.AreEqual(TestResult, scientificCalculator.Result);
        }
    }
}
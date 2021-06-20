using HW_9;
using NUnit.Framework;
using System;

namespace HW_9_tests
{
    [TestFixture]
    class CalculatorTest
    {
        public double TestArgument1;
        public double TestArgument2;
        public double TestArgument3;
        public double TestResult;
        Calculator calculator = new Calculator();

        [Test]
        public void TestAdditionHappyFlow()
        {
            TestArgument1 = 2;
            TestArgument2 = 1;
            TestResult = 3;
            calculator.Add(TestArgument1, TestArgument2);
            Assert.AreEqual(TestResult, calculator.Result);
        }

        [Test]
        public void TestAdditionDecimal()
        {
            TestArgument1 = 0.0000002412;
            TestArgument2 = 0.0000004525;
            TestResult = 0.0000006937;
            calculator.Add(TestArgument1, TestArgument2);
            Assert.AreEqual(TestResult, calculator.Result);
        }

        [Test]
        public void TestAdditioBigNumbers()
        {
            TestArgument1 = 516453646436456;
            TestArgument2 = 453646436456475;
            TestResult = 970100082892931;
            calculator.Add(TestArgument1, TestArgument2);
            Assert.AreEqual(TestResult, calculator.Result);
        }

        [Test]
        public void TestAdditionNegativeNumbers()
        {
            TestArgument1 = -2;
            TestArgument2 = -1;
            calculator.Add(TestArgument1, TestArgument2);
            Assert.Negative(calculator.Result);
        }

        [Test]
        public void TestSubtraction()
        {
            TestArgument1 = 2;
            TestArgument2 = 1;
            TestResult = 1;
            calculator.Subtract(TestArgument1, TestArgument2);
            Assert.AreEqual(TestResult, calculator.Result);
        }

        [Test]
        public void TestSubtractionZeroResult()
        {
            TestArgument1 = 2;
            TestArgument2 = 2;
            calculator.Subtract(TestArgument1, TestArgument2);
            Assert.Zero(calculator.Result);
        }

        [Test]
        public void TestMultiplication()
        {
            TestArgument1 = 2;
            TestArgument2 = 1;
            TestResult = 2;
            calculator.Multiply(TestArgument1, TestArgument2);
            Assert.AreEqual(TestResult, calculator.Result);
        }

        [Test]
        public void TestMultiplicationOneNegativeNumber()
        {
            TestArgument1 = -2;
            TestArgument2 = 1;
            calculator.Multiply(TestArgument1, TestArgument2);
            Assert.Negative(calculator.Result);
        }

        [Test]
        public void TestMultiplicationBothNegativeNumbers()
        {
            TestArgument1 = -2;
            TestArgument2 = -4;
            calculator.Multiply(TestArgument1, TestArgument2);
            Assert.Positive(calculator.Result);
        }

        [Test]
        public void TestDivision()
        {
            TestArgument1 = 4;
            TestArgument2 = 2;
            TestResult = 2;
            calculator.Divide(TestArgument1, TestArgument2);
            Assert.AreEqual(TestResult, calculator.Result);
        }

        [Test]
        public void TestDivisionOneNegativeNumber()
        {
            TestArgument1 = -2;
            TestArgument2 = 1;
            calculator.Divide(TestArgument1, TestArgument2);
            Assert.Negative(calculator.Result);
        }

        [Test]
        public void TestDivisionBothNegativeNumbers()
        {
            TestArgument1 = -2;
            TestArgument2 = -1;
            calculator.Divide(TestArgument1, TestArgument2);
            Assert.Positive(calculator.Result);
        }
    }
}
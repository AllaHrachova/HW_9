using System;

namespace HW_9
{
    public class Calculator
    {
        public double Result;

        public void Add(double Argument1, double Argument2)
        {
            Result = Argument1 + Argument2;
        }

        public void Subtract(double Argument1, double Argument2)
        {
            Result = Argument1 - Argument2;
        }

        public void Multiply(double Argument1, double Argument2)
        {
            Result = Argument1 * Argument2;
        }

        public void Divide(double Argument1, double Argument2)
        {
            Result = Argument1 / Argument2;
        }
    }
}
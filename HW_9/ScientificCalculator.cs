using System;
using System.Collections.Generic;
using System.Text;

namespace HW_9
{
    public class ScientificCalculator : Calculator
    {
        double[] array = new double[3];
        public void Exponentiate(double argument1, double argument2)
        {
            Result = Math.Pow(argument1, argument2);
        }

        public void CalculatePercentage(double argument1, double argument2)
        {
            Result = (argument1 / argument2) * 100;
        }

        public void CalculateModule(double argument1)
        {
            Result = Math.Abs(argument1);
        }

        public void CalculateSumOfArray(double argument1, double argument2, double argument3)
        {
            array[0] = argument1;
            array[1] = argument2;
            array[2] = argument3;
            Result = 0;
            for (int i = 0; i < 3; i++)
            {
                Result += array[i];
            }
        }

        public void FindMinimum(double argument1, double argument2, double argument3)
        {
            array[0] = argument1;
            array[1] = argument2;
            array[2] = argument3;
            Result = array[0];
            for (int i = 0; i < 3; i++)
            {
                if (Result > array[i])
                {
                    Result = array[i];
                }
            }
        }

        public void FindMaximum(double argument1, double argument2, double argument3)
        {
            array[0] = argument1;
            array[1] = argument2;
            array[2] = argument3;
            Result = array[0];
            for (int i = 0; i < 3; i++)
            {
                if (Result < array[i])
                {
                    Result = array[i];
                }
            }
        }

        public void CalculateAverage(double argument1, double argument2, double argument3)
        {
            array[0] = argument1;
            array[1] = argument2;
            array[2] = argument3;
            double sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += array[i];
            }
            Result = sum / 3;
        }
    }
}
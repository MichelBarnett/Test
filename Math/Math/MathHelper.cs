﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    public class MathHelper
    {
        private MathHelper() { }

        public static int Add(int param1, int param2)
        {
            int sum = param1 + param2;
            return sum;
        }

        public static int Subtract(int param1, int param2)
        {
            int difference = param1 - param2;
            return difference;
        }

        public static int Multiply(int factor1, int factor2)
        {
            int product = factor1 * factor2;
            return product;
        }

        public static int Divide(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            return quotient;
        }
    }
}
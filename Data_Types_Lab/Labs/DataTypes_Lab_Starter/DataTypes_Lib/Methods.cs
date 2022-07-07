using System;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static float Factorial(int n)
        {
            ulong sum = 1;

            for(int i = 1; i < n; i++)
            {
                sum += sum * (ulong)i;
            }

            return sum;
        }

        public static float Mult(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}

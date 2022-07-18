using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if (totalDays < 0) {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }
            int weeks = totalDays / 7;
            int days = totalDays % 7;
            var weeksAndDays = (weeks, days);
            return weeksAndDays;

        }
        public static (int square, int cube, double root) squareCubeRoot(int input){
            int square = input * input;
            int cube = (int)Math.Pow(input, 3);
            double root = Math.Sqrt(input);
            return (square, cube, root);

        }
        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

    }
}

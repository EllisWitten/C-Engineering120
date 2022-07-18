using System;
using System.Linq;
using System.Text;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            string newInput = input.Trim().ToUpper();
            for (int i = 0; i < num; i++)
               newInput = newInput + i.ToString();
            return newInput;
        }



        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return ($"{number} {street}, {city} {postcode}.");
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            double calc = ((double)score / outOf) *100;
            double percent = Math.Round(calc,1);
            return ($"You got {score} out of {outOf}: {percent}%");

            /*throw new NotImplementedException();*/
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            try
            {
                return double.Parse(numString);
            }
            catch 
            {
                return -999;
            }
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            foreach (char letter in input.ToUpper())
            {
                if (letter == 'A')
                {
                    a += 1;
                } else if (letter == 'B')
                {
                    b += 1;
                }
                else if (letter == 'C')
                {
                    c += 1;
                }
                else if (letter == 'D')
                {
                    d += 1;
                }
            }
            return($"A:{a} B:{b} C:{c} D:{d}");
        }

        
    }
}


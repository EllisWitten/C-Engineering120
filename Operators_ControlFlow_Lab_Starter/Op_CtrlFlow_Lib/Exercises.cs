using System.Collections.Generic;
using System.Linq;
using System;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            return nums.Count > 0 ? nums.Average() : 0.0;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            return age >= 60 ? "OAP" :
                age >= 18 ? "Standard":
                age >= 13 ? "Student" :
                age >= 5 ? "Child" : "Free";
        }

        public static string Grade(int mark)
        {
            if(mark > 100 || mark < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return mark >= 75 ? "Pass with Distinction" :
                mark >= 60 ? "Pass with Merit" :
                mark >= 40 ? "Pass" : "Fail";
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            if (covidLevel > 4 || covidLevel < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            return covidLevel == 0 ? 200 :
                covidLevel == 1 ? 100 :
                covidLevel == 2 ? 50 :
                covidLevel == 3 ? 50 : 20;
        }
    }
}

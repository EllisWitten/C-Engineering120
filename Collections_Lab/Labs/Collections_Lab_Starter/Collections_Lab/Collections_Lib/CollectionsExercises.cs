using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            if (queue.Count < num)
            {
                num = queue.Count;
            }

            string stringResult = "";
            for (int i = 0; i < num; ++i)
            {
                stringResult += queue.Dequeue();
                if (i+1 != num)
                {
                    stringResult += ", ";
                }
            }

            return stringResult;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            int[] originalReversed = new int[original.Length];

            Stack<int> stack = new Stack<int>(original);

            foreach(int num in original)
            {
                stack.Push(num);
            }
            for (int i = 0; i < originalReversed.Length; i++)
            {
                originalReversed[i] = stack.Pop();
            }

            return originalReversed;
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            var countDict = new Dictionary<int, int>();

         
            
            foreach(char num in input)
            {
                if(Int32.TryParse(num.ToString(), out int result))
                {
                    if (countDict.ContainsKey(result))
                    {
                        countDict[result]++;
                    }
                    else
                    {
                        countDict.Add(result, 1);
                    }
                }
            }

            string returnString = "";

            foreach(var entry in countDict)
            {
                returnString += entry;
            }

            return returnString;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> fiveList = new List<int>();

            for (int x = 1; x <= max; x++)
            {
                if (x % 5 == 0)
                {
                    fiveList.Add(x);
                }
            }

            return fiveList;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> aList = new List<string>();

            foreach (string word in sourceList)
            {
                if (word.StartsWith('A') || word.StartsWith('a'))
                {
                    aList.Add(word);
                }
            }
            return aList;
        }
    }
}

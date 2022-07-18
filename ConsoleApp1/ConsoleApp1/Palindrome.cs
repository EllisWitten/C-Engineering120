using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNUnit;

public static class Palindrome
{
    public static string PalindromeVar(string input)
    {
        if(input.StartsWith("-") && input.Contains(",")){

            List<string> inputList = new List<string>(input.Split(",").Reverse());

            string reverseNegNums = "";
            for(int i = 0; i < inputList.Count(); i++)
            {
                if (i + 1 == inputList.Count())
                {
                    reverseNegNums += inputList[i];
                }
                else
                {
                    reverseNegNums += inputList[i] + ",";
                }
               
            }

            if (reverseNegNums == input)
            {
                return ($"True, {input} is a palindrome");
            }
            else
            {
                return ($"False, {input} is not a palindrome: {reverseNegNums}");
            }

        } else if (input.StartsWith("-") &! (input.Contains(",")))
        {
            throw new ArgumentException("a negative list must be seperated by commas");
        }

        Stack<char> Reverse = new Stack<char>();

        foreach (char character in input)
        {
            Reverse.Push(character);
        }

        string ReversedInput = "";

        for (int i = 0; i < input.Length; i++)
        {
            ReversedInput += (Reverse.Pop());
        }

        if (ReversedInput == input)
        {
            return ($"True, {input} is a palindrome");
        }
        else
        {
            return ($"False, {input} is not a palindrome: {ReversedInput}");
        }

    }
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

namespace PalindromeNUnit;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.PalindromeVar("09890"));
        Console.WriteLine(Palindrome.PalindromeVar("-1-2-3-2-1"));
        Console.WriteLine(Palindrome.PalindromeVar("-1,-2,-3,-2,-1"));
        Console.WriteLine(Palindrome.PalindromeVar("-1,-2,-3,-2,-8"));


    }
}
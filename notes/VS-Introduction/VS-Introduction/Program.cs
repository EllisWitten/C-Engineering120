namespace CSharpIndroduction;

public class Program
{
    public static void Main(string[] args)
    {
        /*Console.WriteLine("I have gained sentience");
        int x = 100;
        x += 10;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            x += 1;*/

        Console.WriteLine("Writing out command line arguments");
        foreach (string item in args)
        {
            Console.WriteLine(item);
        }
        }
    }
}
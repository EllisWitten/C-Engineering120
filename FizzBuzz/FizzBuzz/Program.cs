
namespace CalculatorApp;

public class Program
{
    static void Main(string[] args)
    {
        
    }

    static public int Add(string numbers)
    {
        if(numbers.Length < 1)
        {
            return 0;
        }
        numbers = numbers.Replace("\n", ",");
        string[] arrString = numbers.Split(',');
        int[] arrInt = new int[arrString.Length];

        for(int i = 0; i < arrString.Length; i++)
        {
            arrInt[i] = Convert.ToInt32(arrString[i]);
        }
        return arrInt.Sum();
    }
}

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
        string delimiter = ",";
        if (numbers.Length > 3 && numbers.Substring(0,2) == "//")
        {
            delimiter = numbers.Substring(2,1);
            numbers = numbers.Remove(0, 3);
        }

        numbers = numbers.Replace("\n", delimiter);
        string[] arrString = numbers.Split(delimiter).Where(x => x.Length > 0).ToArray();
        int[] arrInt = new int[arrString.Length];

        List<int> negative = new List<int>();
        for(int i = 0; i < arrString.Length; i++)
        {
            arrInt[i] = Convert.ToInt32(arrString[i]);
            if (arrInt[i] > 1000)
            {
                arrInt[i] = 0;
            }

            if (arrInt[i] < 0)
            {
                negative.Add(arrInt[i]);
            }

        }
        if(negative.Count > 0)
        {
            throw new ArgumentOutOfRangeException($"negatives not allowed : {string.Join(',', negative)}");
        }
        return arrInt.Sum();
    }
}
namespace OperatorsControlFlow
{
    public class Methods
    {
        public static int GetStones(int totalPounds)
        {
            return (totalPounds / 14);
        }

        public static int GetPounds(int totalPounds)
        {
            return totalPounds % 14;
        }
    }
}
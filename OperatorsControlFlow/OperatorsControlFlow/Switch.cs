namespace OperatorsControlFlow 
{
    public static class Switch
    {
        public static string Priority(int level)
        {
            string priority = "Code ";

            switch (level)
            {
                case 3:
                    priority = priority + "Red";
                    break;
                case 2:
                case 1:
                    priority = priority + "Amber";
                    break;
                case 0:
                    priority = priority + "Green";
                    break;
                default:
                    priority = "Error";
                    break;
            }
            return priority;
        }
    }
}

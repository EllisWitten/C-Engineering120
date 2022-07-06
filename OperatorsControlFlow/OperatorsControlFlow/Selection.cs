namespace OperatorsControlFlow
{
    public class Selection
    {
        public static string Grade(int mark)
        {
            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }
    }
}
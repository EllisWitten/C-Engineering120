namespace MoreDataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CSharpIsFun(" c# list fundamentals"));
        }

        public static string CSharpIsFun(string myString)
        {
            string trimmed = myString.Trim();
            string upper = trimmed.ToUpper();
            string replaceL = upper.Replace('L', '*');
            string replaceT = replaceL.Replace('T', '*');
            int nIndex = replaceT.IndexOf('N');
            string remove = replaceT.Remove(nIndex + 1);
       
            return remove;
        }
    }
}
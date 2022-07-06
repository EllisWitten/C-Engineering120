namespace OperatorsControlFlow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*  int x = 0;
              int y = 0;
              int a = x++;
              int b = ++y;

              for (int i = 0; i < 10; i++)
              {
                  Console.WriteLine(i);
              }

              var c = 5 / 2;
              var e = 5 / 3
              var d = 5.0 / 2;;

              const int NUM_ROWS = 2;
              const int NUM_COLS = 5;
              bool running = true;
              int row = 0;
              int col = 0;
              int sprintNo = -1;

              while (running)
              {
                  sprintNo++;


              }*/
            /*Console.WriteLine(Switch.Priority(1));*/

            List<int> nums = new List<int> { 10, 6, 22, -17, 3 };
            Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
            Console.WriteLine("Highest for- loop: " + LoopTypes.HighestForLoop(nums));
            Console.WriteLine("Highest while- loop: " + LoopTypes.HighestWhileLoop(nums));
            Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));
        }

        


    } 
}
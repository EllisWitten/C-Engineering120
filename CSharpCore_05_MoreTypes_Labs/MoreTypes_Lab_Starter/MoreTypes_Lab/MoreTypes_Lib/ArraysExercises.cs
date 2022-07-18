using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            var listToArray = contents.ToArray();
            return listToArray;
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            if (length1 * length2 *length3 != contents.Count())
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            string[,,] array3d = new string[length1, length2, length3];
            int i = 0;
            for (int x = 0; x < length1; x++)
            {
                for (int y = 0; y < length2; y++)
                {
                    for (int z = 0; z < length3 ; z++)
                    {
                        array3d[x, y, z] = contents[i];
                        i++;
                    }
                }
            }
            return array3d;
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            if (countRow1 + countRow2 != contents.Count())
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            string[][] jaggedArray = new string[2][];
            jaggedArray[0] = new string[countRow1];
            jaggedArray[1] = new string[countRow2];

            int counter = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < jaggedArray[i].Length; x++)
                {
                    jaggedArray[i][x] = contents[counter];
                    counter++;
                }
            }
            return jaggedArray;
        }

        public static void LessonNotes()
        {
            //1D Arrays
            int[] arrayOfInts = { 1, 2, 3, 4, 5 };
            string sparta = "SpartaGlobal";
            var spartaArray = sparta.ToCharArray();

            var greetings = "Hello,Hi,Hola,Hallo,Hej";
            var greetingsArray = greetings.Split(',');

            //2D Arrays
            int[,] grid = new int[2, 4];
            grid[0, 1] = 6;
            grid[1, 3] = 8;

            foreach (var element in grid)
            {
                Console.WriteLine(element);
            }

            string[,] chessBoard = {{ "pawn", "king" },
                                    { "blank", "blank" },
                                    { "enemy king", "enemy pawn" } };

            int lower1D = chessBoard.GetLowerBound(0);
            int lower2D = chessBoard.GetLowerBound(1);
            int upper1D = chessBoard.GetUpperBound(0);
            int upper2D = chessBoard.GetUpperBound(1);

            string theBoard = "";
            for (int i = lower1D; i <= upper1D; i++)
            {
                for (int j = lower2D; j <= upper2D; j++)
                {
                    theBoard += $"{chessBoard[i, j]} is at {i} and {j}\n";
                }
            }
            Console.WriteLine(theBoard);

            //Jagged Arrays
            int[][] jaggedIntArray = new int[2][];
            jaggedIntArray[0] = new int[4];
            jaggedIntArray[1] = new int[2];

            jaggedIntArray[0][3] = 666;

            jaggedIntArray[0] = new int[] { 1, 1, 1, 1 };

            int upper1D2 = jaggedIntArray.GetUpperBound(0);

            foreach (var innerArray in jaggedIntArray)
            {
                foreach (int value in innerArray)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}

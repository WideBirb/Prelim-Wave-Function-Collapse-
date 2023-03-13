using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DECLARATION

            int[,] Board = new int[9,9];
            Random rnd = new Random();
            List<int> Pool = new List<int>();

            // first param is column
            // second param is row

            // Wave Function Collapse
            for (int i = 0; i < 9; i++)
                Pool.Add(i + 1);

            foreach (int num in Pool)
                Console.Write(num + "\t");

            int answer  = rnd.Next(0,Pool.Count + 1);

            // LOGIC


            // DISPLAY

            // first param is column
            // second param is row
            Board[3,8] = answer;
            Console.WriteLine();
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                if (i % 3 == 0)
                {
                    for (int j = 0; j < 90; j++)
                        Console.Write("-");
                }
                Console.WriteLine();

                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    if (j % 3 == 0)
                        Console.Write("|" + "\t");
                    Console.Write(Board[i, j] + "\t");
                }
                Console.WriteLine();

            }

            // https://www.geeksforgeeks.org/sudoku-backtracking-7/

        }
    }
}
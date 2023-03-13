using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DECLARATION

            int[,] Board = new int[9, 9];
            Random rnd = new Random();
            List<int> Pool = new List<int>();
            int Attempts = 0;
            int answer = 0;
            int Backtrack   = 0;

            // first param is column
            // second param is row

            // LOGIC


            // DISPLAY

            // first param is column
            // second param is row

            for (int current_col = 0; current_col < Board.GetLength(0); current_col++)
            {

                // GENERATE POOL


                for (int current_row = 0; current_row < Board.GetLength(0); current_row++)
                {

                    for (int i = 0; i < 9; i++)
                        Pool.Add(i + 1);

                    // SCAN ROW
                    for (int i = 0; i < Board.GetLength(1); i++)
                    {
                        Pool.Remove(Board[current_col, i]);
                    }

                    // SCAN COLUMN
                    for (int i = 0; i < Board.GetLength(0); i++)
                    {
                        Pool.Remove(Board[i, current_row]);
                    }

                    // SCAN 3x3 MATRIX

                    // GENERATE ANSWER
                    Board[current_col, current_row] = Pool[rnd.Next(0, Pool.Count)];

                    Pool.Clear();

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


                }


            }


            // DISPLAY


            // https://www.geeksforgeeks.org/sudoku-backtracking-7/

        }
    }
}


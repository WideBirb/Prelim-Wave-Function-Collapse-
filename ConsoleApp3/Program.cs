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
            bool solved = false;
            int answer = 0;

            // first param is column
            // second param is row

            // LOGIC


            // DISPLAY

            // first param is column
            // second param is row

            while (!solved)
            {
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


                        // REMAINING POOL
                        Console.WriteLine("REMAINING NUMBERS IN POOL AFTER REMOVAL");
                        foreach (int num in Pool)
                            Console.Write(num + "\t");

                        // GENERATE ANSWER
                        if (Pool.Count == 1)
                        {
                            Board[current_col, current_row] = Pool[0];
                        }
                        else
                        {
                            answer = rnd.Next(0, Pool.Count);
                            Console.WriteLine("ANSWER IS INDEX " + answer);
                            Board[current_col, current_row] = Pool[answer];
                        }

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
            }


            // DISPLAY


            // https://www.geeksforgeeks.org/sudoku-backtracking-7/

        }
    }
}


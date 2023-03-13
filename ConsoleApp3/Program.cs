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
            int Backtrack   = 0;

            // first param is column
            // second param is row

            // LOGIC


            // DISPLAY

            // first param is column
            // second param is row

            for (int current_col = 0; current_col < Board.GetLength(0); current_col++)
            {

                for (int current_row = 0; current_row < Board.GetLength(0); current_row++)
                {

                    // GENERATE POOL
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
                    int startRow = current_row / 3 * 3;
                    int startCol = current_col / 3 * 3;
                    for (int row = startRow; row < startRow + 3; row++)
                        for (int col = startCol; col < startCol + 3; col++)
                            Pool.Remove(Board[col, row]);

                    Console.Write(" AVAILABLE NUMBERS: " + "\t");
                    foreach (int num in Pool)
                        Console.Write(num + "\t");
                    Console.WriteLine();
                    Console.WriteLine("POOL COUNT: " + Pool.Count);

                    // BACKTRACK IF POOL COUNT == 0
                    if (Pool.Count == 0)
                        current_row =- 2;
                    else
                        Board[current_col, current_row] = Pool[rnd.Next(0, Pool.Count)];

                    // DISPLAY
                    Console.WriteLine("ATTEMPTS :" + Attempts);
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

                    Pool.Clear();

                }
            }

            

        }
    }
}


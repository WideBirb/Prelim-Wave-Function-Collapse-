using System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Board = new int[9, 9];
            Random rnd = new Random();
            List<int> Pool = new List<int>();
            int Attempts = 0;

            for (int current_col = 0; current_col < Board.GetLength(0); current_col++)
                for (int current_row = 0; current_row < Board.GetLength(0); current_row++)
                {

                    for (int i = 1; i < 10; i++)
                        Pool.Add(i);

                    for (int i = 0; i < Board.GetLength(1); i++)
                        Pool.Remove(Board[current_col, i]);

                    for (int i = 0; i < Board.GetLength(0); i++)
                        Pool.Remove(Board[i, current_row]);

                    int startRow = current_row / 3 * 3;
                    int startCol = current_col / 3 * 3;
                    for (int row = startRow; row < startRow + 3; row++)
                        for (int col = startCol; col < startCol + 3; col++)
                            Pool.Remove(Board[col, row]);

                    if (Pool.Count == 0)
                    {
                        Attempts++;
                        current_col = 0;
                        current_row = -1;
                        Board = new int[9, 9];
                    }
                    else
                        Board[current_col, current_row] = Pool[rnd.Next(0, Pool.Count)];
                    Pool.Clear();
                }

            Console.WriteLine("ATTEMPTS :" + Attempts);
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                if ((i % 3 == 0) && !(i == 0))
                {
                    for (int j = 0; j < 41; j++)
                        Console.Write("- ");
                }
                Console.WriteLine();
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    if ((j % 3 == 0) && !(j == 0))
                        Console.Write("|" + "\t");
                    Console.Write(Board[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

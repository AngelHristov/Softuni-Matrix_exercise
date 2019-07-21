namespace _01._Diagonal_Difference
{
    using System;
    using System.Linq;

    public class Diagonal
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int sumDiagonal1 = 0;
            int sumDiagonal2 = 0;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                sumDiagonal1 += (matrix[i, i]);
            }

            for (int row = 0; row < n; row++)
            {
                sumDiagonal2 += (matrix[row, n - 1 - row]);
            }

            Console.WriteLine(Math.Abs(sumDiagonal1 - sumDiagonal2));
        }
    }
}

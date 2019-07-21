namespace _03._Maximum_Sum
{
    using System;
    using System.Linq;

    public class MaxSum
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];
            int maxSum = int.MinValue;
            int startIndexRows = 0;
            int startIndexCols = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int sum = 0;
                    for (int i = row; i < row + 3; i++)
                    {
                        for (int j = col; j < col + 3; j++)
                        {
                            sum += matrix[i, j];
                        }
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startIndexRows = row;
                        startIndexCols = col;
                    }
                }
            }
            Console.WriteLine("Sum = " + maxSum);

            for (int row = startIndexRows; row < startIndexRows + 3; row++)
            {
                for (int col = startIndexCols; col < startIndexCols + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

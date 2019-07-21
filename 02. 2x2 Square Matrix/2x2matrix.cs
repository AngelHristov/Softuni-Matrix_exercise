namespace _02._2x2_Square_Matrix
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (dimensions[1] < 2 || dimensions[0] < 2 || dimensions.Length != 2)
            {
                Console.WriteLine(0);
                return;
            }

            char[,] matrix = new char[dimensions[0], dimensions[1]];
            int sumEqualMatrix = 0;
            for (int row = 0; row < dimensions[0]; row++)
            {
                char[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < dimensions[1]; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            for (int row = 0; row < dimensions[0] - 1; row++)
            {
                for (int col = 0; col < dimensions[1] - 1; col++)
                {

                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        sumEqualMatrix++;
                    }
                }
            }
            Console.WriteLine(sumEqualMatrix);
        }
    }
}

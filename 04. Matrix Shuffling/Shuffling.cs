namespace _04._Matrix_Shuffling
{
    using System;
    using System.Linq;

    public class Shuffling
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();
            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] lines = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = lines[col];
                }
            }

            string line = String.Empty;
            while ((line = Console.ReadLine()).ToLower() != "end")
            {
                string[] command = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row1 = 0; int row2 = 0; int col1 = 0; int col2 = 0;
                try
                {
                    row1 = int.Parse(command[1]);
                    col1 = int.Parse(command[2]);
                    row2 = int.Parse(command[3]);
                    col2 = int.Parse(command[4]);
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (command.Length != 5 || command[0].ToLower() != "swap"
                    || row1 * row2 * col1 * col2 < 0 || row1 > rows || row2 > rows
                    || col1 > cols || col2 > cols)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    string temp = string.Empty;
                    temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

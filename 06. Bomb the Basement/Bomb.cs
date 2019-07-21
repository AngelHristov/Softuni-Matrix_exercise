namespace _06._Bomb_the_Basement
{
    using System;
    using System.Linq;

    public class Bomb
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] basement = new int[rows, cols];

            int[] bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        if ()
            //        {

            //        }
            //    }
            //}


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(basement[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

namespace _05.SnakeMoves
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Snake
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int rows = input[0];
            int cols = input[1];

            char[] snake = Console.ReadLine().ToArray();

            Queue<char> queue = new Queue<char>(snake);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(queue.Peek());
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine();
            }
        }
    }
}

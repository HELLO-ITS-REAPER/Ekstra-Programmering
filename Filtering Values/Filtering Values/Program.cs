using System;

namespace Filtering_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers, separated by spaces:");
            string input = Console.ReadLine();

            char[] separators = new char[] { ' ' };

            string[] array = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] ints = Array.ConvertAll(array, a => int.Parse(a));

            Console.WriteLine("The even numbers are:");
            foreach (int number in ints)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}

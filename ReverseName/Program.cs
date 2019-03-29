using System;

namespace ReverseName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string input = Console.ReadLine();

            string reversedName = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedName += input[i];
            }

            Console.WriteLine("After reverse: " + reversedName);
            Console.ReadLine();
        }
    }
}

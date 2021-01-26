using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
            Console.WriteLine("Enter a name: ");
                string input = Console.ReadLine();
                names[i] = input;
            }

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadKey();

            Console.WriteLine("What name would you like to exchange? Input a number from 1 to 5");
            int numOfName = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a new name: ");
            string newName = Console.ReadLine();

            names[numOfName - 1] = newName;

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}

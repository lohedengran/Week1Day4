using System;

namespace Week1Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            int wholeNumber = 8;
            Console.WriteLine(wholeNumber);
            int returnValue = AddTwo(wholeNumber);
            Console.WriteLine(returnValue);
            Console.WriteLine(wholeNumber);
            //SomeMethod();
            //int i = SomeMethodWithReturnValue();
            //string returnString = GetAString();
            //TakeAMessageAndShout("Academy"); - argument i form av en literal
            Console.Write("Ange en sträng: ");
            string message = Console.ReadLine();
            TakeAMessageAndShout(message); //argument i form av en variabel

            Console.Write("Ange en sträng: ");
            TakeAMessageAndShout(Console.ReadLine()); // argument i form av ett metodanrop
        }
        static void SomeMethod() // enklast metod
        {
            Console.WriteLine("Academy!");
            Console.WriteLine("2021"); 
        }

        static int SomeMethodWithReturnValue() // enklast metod
        {
            bool done = true;
            if (done)
            {
                return 1;
            } else
            return 0;
        }

        static string GetAString()
        {
            return Console.ReadLine();
        }

        static void TakeAMessageAndShout(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        static int AddTwo(int wholeNumber)
        {
            wholeNumber = wholeNumber + 2;
            return wholeNumber;
        }
    }
}

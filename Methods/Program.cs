using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Addera(2, 5);
            Console.WriteLine(sum);

            double moms = Moms(100);
            Console.WriteLine(moms);

            double moms2 = Moms(100, 0.12);
            Console.WriteLine(moms2);
        }
        static int Addera(int num1, int num2)
        {
            return num1 + num2;
        }

        static double Moms(double num)
        {
            return num * 0.25;
        }

        static double Moms(double num, double moms)
        {
            return num * moms;
        }
    }
}

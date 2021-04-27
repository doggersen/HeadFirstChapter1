using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculations.Addition(19, 4);
            Console.WriteLine(Calculations.result);

            Calculations myCalculations = new Calculations();

            myCalculations.Subtraction(4, 1);
            Console.WriteLine(Calculations.result);


            Console.WriteLine("type in 2 numbers, and they will be added together");
            int intputNumber1 = Convert.ToInt32(Console.ReadLine());
            int intputNumber2 = Convert.ToInt32(Console.ReadLine());
            Calculations.Addition(intputNumber1, intputNumber2);
            Console.WriteLine("the result is: " + Calculations.result);

        }
    }
}

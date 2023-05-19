using System;

namespace SupremeCalculator
{
    public class Advanced
    {
        public void SquareRoot()
        {
            double num;
            Console.WriteLine("Welcome to the Square Root Operation :).");
            Console.Write("What number do you want to know the square root of?: ");

            num = Convert.ToDouble(Console.ReadLine());
            double result = Math.Sqrt(num);

            Console.WriteLine("The Square Root of " + num + " is " + result);
        }

        public void DBO()
        {
            int num;
            Console.WriteLine("Welcome to the divide by One Operation :).");
            Console.Write("What number do you want to divide by 1?: ");

            num = Convert.ToInt32(Console.ReadLine());
            double result = 1 / Convert.ToDouble(num);

            Console.WriteLine("1 divided by " + num + " is " + result);
        }
    }
}

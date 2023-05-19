using System;

namespace SupremeCalculator
{
    public class Basic
    {
        public void Add()
        {
            int first_num;
            int second_num;

            Console.WriteLine("Welcome to Addition!! \nPlease type 2(for now) numbers you would like to use");
            
            Console.Write("Number #1: ");
            first_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Number #2: ");
            second_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            int result = first_num + second_num;
            Console.WriteLine("The result of " + first_num + " + " + second_num + " is " + result);
        }

        public void Subtract()
        {
            int first_num;
            int second_num;

            Console.WriteLine("Welcome to Subtraction!! \nPlease type 2(for now) numbers you would like to use");

            Console.Write("Number #1: ");
            first_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Number #2: ");
            second_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            int result = first_num - second_num;
            Console.WriteLine("The result of " + first_num + " - " + second_num + " is " + result);
        }

        public void Multiply()
        {
            int first_num;
            int second_num;

            Console.WriteLine("Welcome to Multiplication!! \nPlease type 2(for now) numbers you would like to use");

            Console.Write("Number #1: ");
            first_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Number #2: ");
            second_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            int result = first_num * second_num;
            Console.WriteLine("The result of " + first_num + " * " + second_num + " is " + result);
        }

        public void Divide()
        {
            int first_num;
            int second_num;

            Console.WriteLine("Welcome to Multiplication!! \nPlease type 2(for now) numbers you would like to use");

            Console.Write("Number #1: ");
            first_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Number #2: ");
            second_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            int result = first_num / second_num;
            Console.WriteLine("The result of " + first_num + " / " + second_num + " is " + result);
        }
    }
}

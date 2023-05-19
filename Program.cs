using System;

namespace SupremeCalculator
{
    public class Program
    {

        static void Main(string[] args)
        {
            Table t = new Table();
            Choices choices = new Choices();


            Console.WriteLine("What would you like to do?: \n");
            t.Options();

            Console.WriteLine("");
            string? choice = Console.ReadLine();
            Console.WriteLine("");

            if (choice == null)
            {
            }
            else
            {
                choices.choices(choice);
            }
        }
    }
}

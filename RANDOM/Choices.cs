using System;

namespace SupremeCalculator
{
    public class Choices
    {
        public void choices(string choice)
        {
            Basic basic = new Basic();
            Advanced advanced = new Advanced();

            if (choice == "Add" || choice == "add")
            {
                basic.Add();
            } else if (choice == "Subtract" || choice == "subtract" || choice == "Sub" || choice == "sub")
            {
                basic.Subtract();
            } else if (choice == "Multiply" || choice == "multiply" || choice == "Mul" || choice == "mul") {
                basic.Multiply();
            } else if (choice == "Divide" || choice == "divide")
            {
                basic.Divide();
            } else if (choice == "Square Root" || choice == "square root" || choice == "Sqrt" || choice == "sqrt")
            {
                advanced.SquareRoot();
            } else if(choice == "D.B.O" || choice == "d.b.o")
            {
                advanced.DBO();
            } 
        }
    }
}

using System;

namespace SupremeCalculator
{
    public class Table
    {
        public void Options()
        {
            List<string> rows = new List<string>();
            List<string> col = new List<string>();
            
            AddRowItems(rows);
            AddColItems(col);

            for (int x = 0; x < rows.Count; x++)
            {
                Console.Write(rows[x] + "     ");
                Console.WriteLine("");
                for(int y = 0; y < col.Count; y++)
                {
                    Console.WriteLine(col[y]);
                }
            }
        }

        public void AddRowItems(List<string> rows)
        {
            rows.Add("Mathematics");
        }

        public void AddColItems(List<string> col)
        {
            col.Add("------------");
            col.Add("Add");
            col.Add("Subtract(Sub)");
            col.Add("Multiply(Mul)");
            col.Add("Divide");
            col.Add("Square Root(Sqrt)");
            col.Add("D.B.O");
        }
    }
}

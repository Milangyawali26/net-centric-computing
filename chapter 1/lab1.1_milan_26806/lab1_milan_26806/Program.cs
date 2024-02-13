// Write a C# program to add two digit using Constructor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_milan_26806
{
    class add
    {
        public int sum;
        public add(int x, int y)
        {
            sum = x + y;
        }
        public void value()
        {
            Console.WriteLine(sum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number\t");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number\t");
            int b = Convert.ToInt32(Console.ReadLine());
            add sum = new add(a, b);
            Console.Write("The sum is:\n");
            sum.value();
            Console.ReadLine();

        }
    }

}

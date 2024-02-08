using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_milan_26806
{
    class rectangle
    {
        public int width;
        public int height;
        public rectangle(int x, int y)
        {
            width = x;
            height = y;
        }
        public int getarea()
        {
            return width * height;
        }
        public void display()
        {
            Console.WriteLine("Length: {0}", height);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", getarea());
        }

    }
    class tabletop : rectangle
    {
        public int cost;
        public tabletop(int length, int width) : base(length, width) { }
        public int getcost(int price)
        {
            cost = price * getarea();
            return cost;
        }
        public void display(int price)
        {
            base.display();
            Console.WriteLine("cost: " + getcost(price));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the painting price");
            int price = Convert.ToInt32(Console.ReadLine());
            tabletop t = new tabletop(a, b);
            t.display(price);
            Console.Read();
        }
    }

}

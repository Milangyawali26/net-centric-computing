using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_milan_26806
{
    class shape
    {
        protected int width;
        protected int height;
        public void set(int x, int y)
        {
            width = x;
            height = y;
        }
    }

    public interface area
    {
        int getarea();

    }
    class cost : shape, area
    {
        public int a;
        public int getarea()
        {
            a = width * height;
            return a;
        }
        public int costof(int ar, int price)
        {
            return a * price;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width of the rectangle\t");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height of the rectangle\t");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of painting\t");
            int price = Convert.ToInt32(Console.ReadLine());
            cost r = new cost();
            r.set(x, y);
            int area = r.getarea();
            Console.Write("The area is: {0}", area, "\n");
            Console.Write("\nThe cost is: {0}", r.costof(area, price));
            Console.Read();

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_milan_26806
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

    class Rectangle : shape
    {
        public int area()
        {
            return width * height;
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
            Rectangle r = new Rectangle();
            r.set(x, y);
            Console.Write("The area is: {0}", r.area(), "\n");
            Console.Read();

        }
    }

}

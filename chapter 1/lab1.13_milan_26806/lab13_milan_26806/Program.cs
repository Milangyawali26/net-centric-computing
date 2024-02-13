using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13_milan_26806
{
    class car
    {
        public virtual string carname()
        {
            return "Car";
        }
    }
    class Ferrari : car
    {
        public override string carname()
        {
            return "Ferrari";
        }
    }
    class Labmorghini : car
    {
        public override string carname()
        {
            return "Lamborghini";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car c1 = new Ferrari();
            car c2 = new Labmorghini();
            Console.WriteLine(c1.carname());
            Console.WriteLine(c2.carname());
            Console.ReadLine();
        }
    }

}

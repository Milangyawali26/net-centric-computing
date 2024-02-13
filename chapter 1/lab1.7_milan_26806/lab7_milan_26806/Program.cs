using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_milan_26806
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence.");
            string str = Console.ReadLine();
            string[] tokens = str.Split(' ');
            Console.Write("The number of words :{0}\nThe number of Characters:{1}", tokens.Length, str.Length);
            Console.ReadLine();

        }
    }

}

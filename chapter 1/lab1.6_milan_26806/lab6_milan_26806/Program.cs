//Write a C# Sharp program to find the position of a specified word in a given string.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_milan_26806
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence.");
            string str = Console.ReadLine();
            Console.WriteLine("Enter a word to find its position in the sentence.");
            string word = Console.ReadLine();
            string[] tokens = str.Split(' ');
            int a = Array.IndexOf(tokens, word) + 1;
            Console.WriteLine("The position of {0} is {1}", word, a);
            Console.ReadLine();

        }
    }

}

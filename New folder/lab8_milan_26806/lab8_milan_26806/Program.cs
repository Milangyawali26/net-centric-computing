using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_milan_26806
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence.");
            string str = Console.ReadLine();
            int speccount = 0;
            int alpcount = 0;
            int digcount = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    alpcount++;
                }
                else if (char.IsDigit(c))
                {
                    digcount++;
                }
                else
                {
                    speccount++;
                }
            }
            Console.Write("The number of alphabets: {0}\nThe number of digits: {1}\nThe number of special characters: {2}", alpcount, digcount, speccount);
            Console.ReadLine();

        }
    }

}

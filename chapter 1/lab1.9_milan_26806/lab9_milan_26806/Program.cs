using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_milan_26806
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String.");
            string str = Console.ReadLine();
            int coscount = 0;
            int vowcount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' ||
                   str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')

                    {
                        vowcount++;
                    }
                    else
                    {
                        coscount++;
                    }


                }

            }
            Console.Write("The number of Vowels: {0}\nThe number of Consonants: {1}", vowcount, coscount);
            Console.ReadLine();

        }
    }

}

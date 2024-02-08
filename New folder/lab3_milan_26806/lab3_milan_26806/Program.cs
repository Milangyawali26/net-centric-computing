using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_milan_26806
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[,] arr2 = new int[3, 3] { { 12, 35, 12 }, { 51, 53, 32 }, { 56, 12, 78 } };

            Console.WriteLine("2D array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    count = count + arr2[i, j];
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The sum is:" + count);
            Console.ReadLine();
        }
    }

}

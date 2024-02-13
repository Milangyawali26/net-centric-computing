using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_milan_26806
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[][] arr2 = new int[3][];
            arr2[0] = new int[] { 12, 35, 12, 51, 53 };
            arr2[1] = new int[] { 32, 56, 12, 78, 54, 19, 87, 43, 26 };
            arr2[2] = new int[] { 75, 59, 35, 46, 24, 16, 61 };
            Console.WriteLine("Jagged array");
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    count = count + arr2[i][j];
                    Console.Write(arr2[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The sum is:" + count);
            Console.ReadLine();
        }
    }

}

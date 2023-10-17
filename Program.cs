using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                int space = rows - i;
                while (space > 0)
                {
                    Console.Write(" ");
                    space--;
                }

                int value = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(value + " ");
                    value = value * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
        }
    }

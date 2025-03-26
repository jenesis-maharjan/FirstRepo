using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1
{
    class patterns
    {
    public void pattern1()
        {
            Console.WriteLine("Pattern 1\n");
            for(int row=1; row <= 5; row++)
            {
                for(int col=1; col<=row; col++)
                {
                    Console.Write("*\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Pattern 2\n");
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row+"\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Pattern 3\n");
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Pattern 4\n");
            for (int row =5; row>=1; row--)
            {
                for(int col=5; col>=row; col--)
                {
                    Console.Write(col+"\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Pattern 5\n");
            for (int row=5; row>=1; row--)
            {
                for(int col=1; col<=row; col++)
                {
                    Console.Write(col+"\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Pattern 6\n");
            for (int row = 5; row >= 1; row--)
            {
                for (int col = row; col >= 1; col--)
                {
                    Console.Write(col + "\t");
                }
                Console.WriteLine("\n");
            }

        }
    }
}

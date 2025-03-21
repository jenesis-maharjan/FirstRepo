using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1
{
    class MultiplicationTable
    {
        public void multiply(int n)
        {
            int num = n;
            Console.WriteLine("Multiplication table of " + num);
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + num * i);
            }
        }

        public void mul()
        {
            for(int j = 1; j <= 10; j++)
            {
                //Console.WriteLine("Multiplication table of " + j);
                for(int i=1; i<=10; i++)
                {
                    Console.Write(j + "*" + i + "=" + j * i +"\t");
                }
                Console.WriteLine("");
            }
        }

        public void boxMul()
        {
            int size = 10;
            for (int i = 1; i <= size; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            for (int i = 1; i <= size; i++) //column
            {
                for (int j = 1; j <= size; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}

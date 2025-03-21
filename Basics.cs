using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1
{
    class Basics
    {
        public void PrintUsername()
        {
            Console.WriteLine("enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is : " + name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1
{
    class Calculate
    {
        public void calculate()
        {
            Console.WriteLine("Enter first number please:");
            string num1 = Console.ReadLine();
            float first_num = float.Parse(num1);

            Console.WriteLine("Enter second number:");
            float num2 = float.Parse(Console.ReadLine()); //direct method parsing

            Console.WriteLine("Choose: 1. + 2. - 3. * 4. /");
            string op = Console.ReadLine();
            float result = 0;

            switch (op)
            {
                case "1":
                    result = first_num + num2;
                    break;

                case "2":
                    result = first_num - num2;
                    break;

                case "3":
                    result = first_num * num2;
                    break;

                case "4":
                    result = first_num / num2;
                    break;

                default:
                    Console.WriteLine("default statement");
                    break;
            }
            Console.WriteLine("The result is :" + result);
        }

        public void checkPrime()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            if (num <= 1)
            {
                Console.WriteLine("It is neither prime nor composite");
            }

            for(int i = 2; i<=Math.Floor(Convert.ToDecimal(num/2)); i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(num + " is a composite number");
                    return;
                }              
            }
             Console.WriteLine(num + " is a prime number");
             return;                
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class MyMath
    {
        static void Main(string[] args)

        {
            Console.Write("enter first number");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number ");
            double operand2 = double.Parse(Console.ReadLine());
            double result = operand1 * operand2;
            Console.WriteLine("product is" + result);
        }
        public void divide()
        {
            Console.Write("enter first number");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("enter second number");
            double operand2 = double.Parse(Console.ReadLine());
            double result = operand1 / operand2;
            Console.WriteLine("result is " + result);
        }
        public void addition()
        {
            Console.Write("enter first number");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("enter second number");
            double operand2 = double.Parse(Console.ReadLine());
            double result = operand1 + operand2;
            Console.WriteLine("result is " + result);
        }
        public void subtract()
        {
            Console.Write("enter first number");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("enter second number");
            double operand2 = double.Parse(Console.ReadLine());
            double result = operand1 - operand2;
            Console.WriteLine("result is " + result);




        }
        public void calling()
        {

        }

    }
}



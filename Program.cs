using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {//1. A single selection statement works well with int values and giving statements to a value. Like for instance, if you want the program to dictate what an 85 percent is, you can use a single selection statement to state that any thing lower than a 90 but greater than 79 is a B. The while repetition statement lets an int be any value as long as that value follows the rule the code allows. For instance if you want an int "v" to be 1-10 then you can write a while loop so that v will be all values from 1-10. They both rely on if and statements.
            int speedLimit = 35;
            int speed = 42;
            if (speed > speedLimit)
                Console.WriteLine("SLOW NOW");
            bool isTrue = true;
            if (isTrue == true)
                Console.WriteLine("isTrue is true");
            bool isFalse = false;
            if (isFalse == false)
                Console.WriteLine("isFalse is False");
            double celsius;
            Console.Write("Enter Fahrenheit ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32 * 5 / 9);
            Console.WriteLine("the temp in celsius is " + celsius);
            if (fahrenheit > 90)
                Console.WriteLine("It is hot");
            if (fahrenheit < 40)
                Console.WriteLine("it is cold");
            int n = 0;
            while (++n < 11) 
            Console.WriteLine("current value of n is {0}",+n);
            int w = 61;
            while (--w > 19)
                Console.WriteLine("current value of w is {0}", +w);
            int v = 9;
            while (++v < 21) 
                Console.WriteLine("current value of v is {0}", +v);

            


            
            

            
            

            
            


  


        }
    }
}

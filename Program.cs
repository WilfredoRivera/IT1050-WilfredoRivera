using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_WilfredoRivera
{
    class Program
    {
        static void Main(string[] args)
        {
            int number01;
            int number02;
            int sum;
            Console.WriteLine("First Integer is  "); 
            number01 = int.Parse(Console.ReadLine());
            Console.Write("Second integer is  "); 
            number02 = int.Parse(Console.ReadLine());
            sum = number01 + number02;
            Console.WriteLine($"Sum is {sum}");
            // Question Number 2
            int x;
            int y;
            int z;
            int product;
            Console.WriteLine("x is equal to 15");
            x = 15;
            Console.WriteLine("y is equal to 40");
            y = 40;
            Console.WriteLine("z is equal to 24");
            z = 24;
            Console.WriteLine("what is x+y * z+10");
            product = (x + y) * (z + 10);
            Console.WriteLine($"prodcut is {product}");
            // Question Number 3
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("Hello\\World");

            




          
            
            





        }
    }
}

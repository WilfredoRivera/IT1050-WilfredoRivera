using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab005
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (++i <= 100)
                Console.WriteLine("number is {0}", +i);
            if ((i % 2) == 0) 
            Console.Write("it is even");
            else
                Console.WriteLine("it is odd");
            int n = 0;
            while(++n<100)
            if (n < 10)
                Console.WriteLine("Polar Bear");
            else
            if (n < 20)
                Console.WriteLine("Penguin");
            else
            if (n < 40)
                Console.WriteLine("Moose");
            else
                if (n < 50)
                Console.WriteLine("Reindeer");
            else
                if (n < 60)
                Console.WriteLine("Deer");
            if (n < 70)
                Console.WriteLine("Turtle");
            else
            if (n < 80)
                Console.WriteLine("Lion");
            else
                if (n < 90)
                Console.WriteLine("Fish");
           



            
            
             
            

            

            


        
           
            



        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            while (t++ < 128)
          Console.WriteLine("Value of t is {{{0}}}", ++t);
            for (int i = 49; i >= 1;)
            Console.Write(" {0},", i--);
            int v = 1;
            while (v <= 21)
            Console.Write("{0}   ", v++);
            int n = 8;
            int w = 10;
            while (w < n) ;
            Console.WriteLine("{0}",w++);
            // a do while loop executes the code without checking if the code is can be executed or not while a while loop checks the condition before running it.
            bool icyrain = true;
            bool tornadoWarning = true;
            if (icyrain = false && tornadoWarning == false) ;
            Console.WriteLine("\"lets go outside!\"");
            bool keeplooping;
            while (keeplooping = true) ;
            
            
            
        }
    }
}

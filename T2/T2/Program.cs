using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n Test2");
            
            Console.WriteLine("\n\n Press any key to exit!");
            
            int x, y, w, counter = 0;

            for (int i = 0; i == counter; i++)
            {
                try
                {
                    Console.Write("\n Enter please first number:  ");
                    x = Int32.Parse(Console.ReadLine());

                    Console.Write(" Enter please second number: ");
                    y = Int32.Parse(Console.ReadLine());

                   w = x + y;
                    
                    Console.WriteLine("\n x + y = " + w);
                }
                catch (Exception error)
                {
                    Console.WriteLine("\n " + error.Message);
                    counter++;
                }
            }
 
             Console.ReadKey();
        }
    }
}

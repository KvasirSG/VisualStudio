using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int træ = 1;
            for (int plads = 0; plads < 25 ; plads++)
            {
                Console.SetCursorPosition((Console.WindowWidth/2)-plads, 5 + plads);
            
                for (int i = 0; i < træ; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Å");
                    Thread.Sleep(50);
                }
                træ = træ + 2;
            }
            Console.ReadKey();
        }
    }
}


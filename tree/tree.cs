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
            int tree = 25;

            for (int plads = 0; plads < 25 ; plads++)
            {
                if (træ<25)
                {
                    Console.SetCursorPosition(40- plads, 5 + plads);


                    for (int i = 0; i < træ; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("§");
                        Thread.Sleep(50);
                    }
                    træ = træ + 2;
                }
                else
                {
                    Console.SetCursorPosition(16+plads, 5 + plads);


                    for (int i = 0; i < tree; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("§");
                        Thread.Sleep(50);
                    }
                    tree = tree - 2;
                }
            }
            Console.ReadKey();
        }
    }
}

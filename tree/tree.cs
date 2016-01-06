using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int træ = 1;
            for (int plads = 0; plads < 10 ; plads++)
            {
                Console.SetCursorPosition(20-plads, 5 + plads);
            
                for (int i = 0; i < træ; i++)
                {
                    Console.Write("^");
                }
                træ = træ + 2;
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            countup();
            Console.ReadKey();
        }
        static void countup()
        {
            int Length_x = 15;
            int Length_y = 15;
            int time = 50;
            for (int top = 0; top < Length_x; top++)
            {
                Console.SetCursorPosition(top + 1, 0);
                Console.Write("*");
                Thread.Sleep(time);
            }
            for (int right = 0; right < Length_y; right++)
            {
                Console.SetCursorPosition(16, right + 1);
                Console.Write("*");
                Thread.Sleep(time);
            }
            for (int bottom = Length_x; bottom > 0; bottom--)
            {
                Console.SetCursorPosition(bottom, 16);
                Console.Write("*");
                Thread.Sleep(time);
            }
            for (int left = Length_y; left > 0; left--)
            {
                Console.SetCursorPosition(0, left);
                Console.Write("*");
                Thread.Sleep(time);
            }
            countdown();
        }
        static void countdown()
        {
            int Length_x = 15;
            int Length_y = 15;
            int time = 50;
            for (int top = 0; top < Length_x; top++)
            {
                Console.SetCursorPosition(top + 1, 0);
                Console.Write(" ");
                Thread.Sleep(time);
            }
            for (int right = 0; right < Length_y; right++)
            {
                Console.SetCursorPosition(16, right + 1);
                Console.Write(" ");
                Thread.Sleep(time);
            }
            for (int bottom = Length_x; bottom > 0; bottom--)
            {
                Console.SetCursorPosition(bottom, 16);
                Console.Write(" ");
                Thread.Sleep(time);
            }
            for (int left = Length_y; left > 0; left--)
            {
                Console.SetCursorPosition(0, left);
                Console.Write(" ");
                Thread.Sleep(time);
            }
            countup();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_ritamedasterisker
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 25; a++)
            {
                
                switch (a % 3)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }

                if (a % 2 > 0)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < 39; i++)
                {
                    Console.Write("* ");
                }
                Console.ResetColor();
                Console.WriteLine();    
            }
        }
    }
}

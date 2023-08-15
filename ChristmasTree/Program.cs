using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Christmas Tree";

            int treeHeight = 8; // Height of the tree
            int spaces = treeHeight - 1; // Initial spaces for the top of the tree

            // Draw the tree
            for (int i = 1; i <= treeHeight; i++)
            {
                // Print spaces
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }

                // Print stars (tree branches)
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    if (i == 3 || i == 5 || i == 7) // Lines 3, 5, and 7
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                    }
                    else if (j % 2 == 0) // Even indexes (0, 2, 4, ...)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                    }
                    else // Odd indexes (1, 3, 5, ...)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*");
                    }

                    Console.ResetColor();
                }

                Console.WriteLine(); // Move to the next line
                spaces--; // Decrease spaces for the next line
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Rhomb : Figure
    {
        int side;
        public Rhomb()
        {
            side = 7;
        }
        public override void Print(int x, int y)
        {
            if (x == -1 && y == -1)
            {
                x = posX;
                y = posY;
            }
            for (int i = 0; i < side; i++)
            {
                Console.SetCursorPosition(x, y++);
                for (int j = 0; j < side; j++)
                {
                    if (j < side / 2)
                    {
                        if (i < side / 2 - j || i > side / 2 + j)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.BackgroundColor = colorFigure;
                            Console.Write(" ");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                    }
                    else
                    {
                        if (i < side / 2 - (side - 1 - j) || i > side / 2 + (side - 1 - j))
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.BackgroundColor = colorFigure;
                            Console.Write(" ");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                    }
                }
            }
        }
        protected override void SetSize(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.UpArrow:
                    if (side > 5)
                        side -= 2;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.DownArrow:
                    if (side < 15)
                        side += 2;
                    break;
                default:
                    break;
            }
        }
    }
}

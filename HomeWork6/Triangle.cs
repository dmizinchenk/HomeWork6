using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Triangle : Figure
    {
        int side;
        public Triangle()
        {
            side = 5;
        }
        public override void Print(int x, int y)
        {
            if (x == -1 && y == -1)
            {
                x = posX;
                y = posY;
            }
            for (int i = 0; i < (side + 1) / 2; i++)
            {
                Console.SetCursorPosition(x, y++);
                for (int j = 0; j < side; j++)
                {
                    if (j < side / 2 - i || j > side / 2 + i)
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
        protected override void SetSize(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.UpArrow:
                    if (side > 3)
                        side -= 2;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.DownArrow:
                    if (side < 11)
                        side += 2;
                    break;
                default:
                    break;
            }
        }
    }
}

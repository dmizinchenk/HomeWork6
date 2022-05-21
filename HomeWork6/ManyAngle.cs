using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class ManyAngle : Figure
    {
        int length;
        public ManyAngle()
        {
            length = 4;
        }
        public override void Print(int x, int y)
        {
            if (x == -1 && y == -1)
            {
                x = posX;
                y = posY;
            }
            for (int i = 0; i < length * 3 - 2; i++)
            {
                Console.SetCursorPosition(x, y++);
                for (int j = 0; j < length * 3 - 2; j++)
                {
                    if (j + i < length - 1 ||
                        i - j > 2 * (length - 1) ||
                        j - i > 2 * (length - 1) ||
                        i + j > 5 * length - 5
                        )
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
                    if (length > 3)
                        length --;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.DownArrow:
                    if (length < 5)
                        length++;
                    break;
                default:
                    break;
            }
        }
    }
}

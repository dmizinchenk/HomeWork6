using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Trapeze : Figure
    {
        int length, height;
        public Trapeze()
        {
            height = 4;
            length = 13;
        }
        public override void Print(int x, int y)
        {
            if (x == -1 && y == -1)
            {
                x = posX;
                y = posY;
            }
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(x, y++);
                for (int j = 0; j < length; j++)
                {
                    if (j < height - i - 1 || j > i + length - height)
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
                    if (length > height * 2 + 1)
                        length--;
                    break;
                case ConsoleKey.UpArrow:
                    if (height > 3)
                        height--;
                    break;
                case ConsoleKey.RightArrow:
                    if (length < 20)
                        length++;
                    break;
                case ConsoleKey.DownArrow:
                    if (height < 8)
                        height++;
                    break;
                default:
                    break;
            }
        }
    }
}

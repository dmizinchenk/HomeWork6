using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Rectangle : Figure
    {
        int width, height;
        public Rectangle()
        {
            width = 10;
            height = 5;
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
                for (int j = 0; j < width; j++)
                {
                    Console.BackgroundColor = colorFigure;
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.Black;
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
                    if(width > 5)
                        width--;
                    break;
                case ConsoleKey.UpArrow:
                    if (height > 3)
                        height --;
                    break;
                case ConsoleKey.RightArrow:
                    if (width < 30)
                        width++;
                    break;
                case ConsoleKey.DownArrow:
                    if (height < 10)
                        height++;
                    break;
                default:
                    break;
            }
        }
    }
}

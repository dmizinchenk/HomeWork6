using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal abstract class Figure
    {
        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        protected ConsoleColor colorFigure;
        protected int posX, posY;
        int index;
        public Figure()
        {
            colorFigure = ConsoleColor.Blue;
            index = (int)colorFigure;
            posX = 0;
            posY = 1;
        }
        ConsoleColor GetColor(ConsoleKey key)
        {
            if (key == ConsoleKey.RightArrow || key == ConsoleKey.UpArrow)
            {
                if (++index == colors.Length)
                    index = 1;
            }
            else if (key == ConsoleKey.LeftArrow || key == ConsoleKey.DownArrow)
            {
                if (--index < 1)
                    index = colors.Length - 1;
            }
            return colors[index];
        }
        void ChoiseColor(out ConsoleKey key)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите цвет фигуры стрелками клавиатуры (Enter-выбор):");
                Print();
                key = Console.ReadKey().Key;
                if (key != ConsoleKey.Enter)
                    colorFigure = GetColor(key);
            } while (key != ConsoleKey.Enter);
        }
        void ChoiseSize(ref ConsoleKey key)
        {
            do
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите размер фигуры стрелками клавиатуры (Enter-выбор):");
                key = Console.ReadKey().Key;
                Console.Clear();
                SetSize(key);
                Console.SetCursorPosition(0, 1);
                Print();
            } while (key != ConsoleKey.Enter);
        }
        void ChoisePos(ref ConsoleKey key)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выберите позицию фигуры стрелками клавиатуры (Enter-выбор):");
            do
            {
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        break;
                    case ConsoleKey.LeftArrow:
                        if (posX > 0)
                            posX--;
                        break;
                    case ConsoleKey.UpArrow:
                        if (posY > 1)
                            posY--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (posX < 30)
                            posX++;
                        break;
                    case ConsoleKey.DownArrow:
                        if (posY < 10)
                            posY++;
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.WriteLine("Выберите позицию фигуры стрелками клавиатуры (Enter-выбор):");
                Print(posX, posY); 
            } while (key != ConsoleKey.Enter);
        }
        public void SetParametres()
        {
            ConsoleKey key;
            ChoiseColor(out key);
            ChoiseSize(ref key);
            ChoisePos(ref key);
        }
        abstract public void Print(int x = -1, int y = -1);
        abstract protected void SetSize(ConsoleKey key);
    }
}

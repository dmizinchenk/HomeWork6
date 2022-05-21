using System;

namespace HomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollectionFigure myCollection = new CollectionFigure();

            int maxFigures = 0;
            while (maxFigures < 5)
            {
                Console.Clear();
                Console.WriteLine($"Выберите {maxFigures + 1}-ю (макс. 5) фигуру для добавления в коллекцию\n" +
                    "1 - треугольник\n" +
                    "2 - прямоугольник\n" +
                    "3 - ромб\n" + 
                    "4 - трапеция\n" +
                    "5 - многоугольник\n" +
                    "0 - конец коллекции \\ выход\n");
                byte temp = Byte.Parse(Console.ReadLine());
                Figure f = null;
                switch (temp)
                {
                    case 0:
                        maxFigures = 5; break;
                    case 1:
                        f = new Triangle(); maxFigures++; break;
                    case 2:
                        f = new Rectangle(); maxFigures++; break;
                    case 3:
                        f = new Rhomb(); maxFigures++; break;
                    case 4:
                        f = new Trapeze(); maxFigures++; break;
                    case 5:
                        f = new ManyAngle(); maxFigures++; break;
                    default:
                        break;
                }
                if (f != null)
                {
                    f.SetParametres();
                    myCollection.Add(f); 
                }
            }
            Console.Clear();
            foreach (Figure item in myCollection)
            {
                item.Print();
            }
        }
    }

}

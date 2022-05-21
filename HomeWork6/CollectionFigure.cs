using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class CollectionFigure
    {
        Figure[] collection;
        public CollectionFigure()
        {
            collection = new Figure[0];
        }
        public IEnumerator GetEnumerator() => collection.GetEnumerator();
        public void Add(Figure f)
        {
            Figure[] temp = new Figure[collection.Length + 1];
            collection.CopyTo(temp, 0);
            temp[collection.Length] = f;
            collection = temp;
        }
    }
}

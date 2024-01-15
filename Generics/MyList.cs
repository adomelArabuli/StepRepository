using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyList<T>
    {
        private T[] array = Array.Empty<T>();

        public T this[int indext]
        {
            get
            {
                return array[indext];
            }
            set
            {
                array[indext] = value;
            }
        }

        public int Count { get { return array.Length; } }

        public void Add(T value)
        {
            var newArray = new T[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = value;
            array = newArray;
        }
    }
}

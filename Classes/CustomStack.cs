using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CustomStack<T> : ICustomStack<T> where T : IInterns
    {
        private readonly T[] elementsArray = new T[10];
        private int index;

        public void Push(T element) => elementsArray[index++] = element;
        public T Pop() => elementsArray[--index];

        public int Count() => index;     

    }
}

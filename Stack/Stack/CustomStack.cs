using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack<T>
    {
        //Members
        private T[] stackArray;
        private int maximumLength;

        //Properties
        public int Size { get; private set; }

        public CustomStack(int length)
        {
            maximumLength = length;
            stackArray = new T[length];
        }

        public void Push(T value)
        {
            if (Size == maximumLength)
            {
                throw new PushingAfterLimitException();
            }
            stackArray[Size++] = value;
        }

        public T Pop()
        {
            if (Size == 0)
            {
                throw new NothingToPopException();
            }
            return stackArray[--Size];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt
{
    public class FixedSizeList<T>
    {
        private readonly T[] _items;
        private int _count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }

            _items = new T[capacity];
            _count = 0;
        }

        public int Count => _count;
        public int Capacity => _items.Length;

        public void Add(T item)
        {
            if (_count >= Capacity)
            {
                throw new InvalidOperationException("Cannot add more items: the list is full.");
            }

            _items[_count++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException("Invalid index: index must be within the list bounds.");
            }

            return _items[index];
        }

    }
}

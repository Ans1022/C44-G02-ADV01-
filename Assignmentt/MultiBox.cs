using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt
{
    public class MultiBox<T>
    {
        private List<T> _items;

        public MultiBox()
        {
            _items = new List<T>();
        }

        public void InsertItem(T item)
        {
            _items.Add(item);
        }

        public List<T> GetAllItems()
        {
            return new List<T>(_items); 
        }

        public int Count()
        {
            return _items.Count;
        }

        public bool IsEmpty()
        {
            return _items.Count == 0;
        }
    }
}

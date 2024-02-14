using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class ListIterator<TValue> : IIterator<TValue>
    {
        private int Index { get; set; }
        public List<TValue> List { get; set; }
        public ListIterator()
        {
            List = new List<TValue>();
        }

        public TValue GetCurrent()
        {
            return List[Index];
        }

        public void GoNext()
        {
            Index++;
        }

        public bool HasNext()
        {
            return Index < List.Count;
        }

        public void GoPrevious()
        {
            Index--;
        }

        public void ResetIteration()
        {
            Index = 0;
        }

        public IEnumerable<TValue> GetIterable()
        {
            return List;
        }

        public void SetIterable(IEnumerable<TValue> iterable)
        {
            List = iterable.ToList();
        }
    }
}

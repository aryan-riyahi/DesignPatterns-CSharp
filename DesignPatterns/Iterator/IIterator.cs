using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public interface IIterator<TValue>
    {
        bool HasNext();
        TValue GetCurrent();
        void GoNext();
        void GoPrevious();
        void ResetIteration();
        IEnumerable<TValue> GetIterable();
        void SetIterable(IEnumerable<TValue> iterable);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Memento<TValue>
    {
        public TValue Content { get; private set; }
        public Memento(TValue content)
        {
            Content = content;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Orginator<TValue>
    {
        public TValue Content { get; set; }
        public Orginator(TValue content)
        {
            Content = content;
        }
        public Memento<TValue> CreateState()
        {
            return new Memento<TValue>(Content);
        }
        public void Restore(Memento<TValue> state)
        {
            Content = state.Content;
        }
    }
}

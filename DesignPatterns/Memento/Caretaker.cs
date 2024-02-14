using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Caretaker<TValue>
    {
        public Stack<Memento<TValue>> States { get; private set; }
        public Caretaker()
        {
            States = new Stack<Memento<TValue>>();
        }
        public void Push(Memento<TValue> memento)
        {
            States.Push(memento);
        }
        public Memento<TValue> Pop()
        {
            return States.Pop();
        }
    }
}

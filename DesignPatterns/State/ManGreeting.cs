using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class ManGreeting : IGreeting
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello Mr.{name}");
        }
    }
}

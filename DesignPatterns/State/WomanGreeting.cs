﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class WomanGreeting : IGreeting
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello Mrs/Miss/Ms.{name}");
        }
    }
}

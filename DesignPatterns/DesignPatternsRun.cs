using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using DesignPatterns.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsRuner
{
    public static class DesignPatternsRun
    {
        public static void MementoRun()
        {
            Orginator<string> orginator = new("Aryan");
            Caretaker<string> caretaker = new();

            caretaker.Push(orginator.CreateState());

            orginator.Content = "Khatere";
            caretaker.Push(orginator.CreateState());

            orginator.Content = "Arad";
            orginator.Restore(caretaker.Pop());

            Console.WriteLine(orginator.Content);
            Console.ReadLine();
        }
        public static void StateRun() 
        {
            IGreeting greeting = new ManGreeting();
            greeting.SayHello("Aryan");

            greeting = new WomanGreeting();
            greeting.SayHello("Khatere");
        }
        public static void IteratorRun()
        {
            BrowseHistory history = new();
            history.Push("https://google.com");
            history.Push("https://facebook.com");
            history.Push("https://indeed.com");

            IIterator<string> iterator = new ListIterator<string>();
            iterator.SetIterable(history.Urls);
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.GetCurrent());
                iterator.GoNext();
            }
        }
    }
}

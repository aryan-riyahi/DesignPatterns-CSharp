using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class BrowseHistory
    {
        public List<string> Urls { get; private set; }
        public BrowseHistory()
        {
            Urls = new List<string>();
        }
        public string Pop()
        {
            int lastIndex = Urls.Count() - 1;
            var lastItemInTheList = Urls[Urls.Count() - 1];
            Urls.RemoveAt(lastIndex);
            return lastItemInTheList;
        }
        public void Push(string url) 
        {
            Urls.Add(url);
        }
    }
}

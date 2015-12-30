using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern3
{
    public class NewsSubscriber : IObserver
    {
        public void Update(Message message)
        {
            Console.WriteLine("Breaking News..");
            Console.WriteLine(message.Title);
            Console.WriteLine(message.Content);
            Console.WriteLine(message.PublishDate.ToLongDateString() + " " + message.PublishDate.ToLongTimeString());
            Console.WriteLine(new string('*', 100));
        }
    }
}

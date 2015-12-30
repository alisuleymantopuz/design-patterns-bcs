using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern3
{
    public class NewsPublisher : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        private List<Message> messages = new List<Message>();

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(messages[messages.Count - 1]);
            }
        }

        public void PublishBreakingNews(Message story)
        {
            messages.Add(story);
            ArchiveChanged();
        }

        private void ArchiveChanged()
        {
            NotifyObservers();
        }
    }
}

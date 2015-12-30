using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern4
{
    public class NewsPublisher
    {

        private List<Message> messages = new List<Message>();

        public delegate void NotifyObserversHandler(Message message);

        public event NotifyObserversHandler ArchiveChanged;

        public void PublishBreakingNews(Message message)
        {
            messages.Add(message);
            if (ArchiveChanged != null)
                ArchiveChanged(message);
        }

    }
}

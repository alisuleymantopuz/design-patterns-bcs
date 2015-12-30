using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern4
{
    public interface IObserver
    {
        void Update(Message message);
    }
}

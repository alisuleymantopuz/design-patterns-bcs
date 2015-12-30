using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern
{
    public class Parent
    {
        private Dictionary<string, Kid> _kids = new Dictionary<string, Kid>();

        public Dictionary<string, Kid> Kids
        {
            get { return _kids; }
            set { _kids = value; }
        }

        public void DailyStatusUpdate(string key)
        {
            Console.WriteLine("Parent Daily Status Receiving...");
            Console.WriteLine("Parents received {0}'s daily status.\n" +
                              "updated on {1}, \nNotes: {2} ",
                              Kids[key].Name, Kids[key].DailyStatus.UpdatedOn,
                              Kids[key].DailyStatus.Description);
        }
    }
}

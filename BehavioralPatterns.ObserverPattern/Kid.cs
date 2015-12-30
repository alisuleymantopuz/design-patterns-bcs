using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern
{
    public class Kid : ObservableObject
    {
        public string Name { get; set; }

        private Status _dailyStatus;

        public Status DailyStatus
        {
            get { return _dailyStatus; }
            set
            {
                _dailyStatus = value;
                Notify(this.Name);
            }
        }
    }
}

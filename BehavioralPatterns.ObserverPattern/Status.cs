using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.ObserverPattern
{
    public class Status
    {
        public Status(string description, string name)
        {
            this.UpdatedOn = DateTime.Now;
            this.Description = description;
            this.Name = name;
        }

        public string Name { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Description { get; set; }
    }
}

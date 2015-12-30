using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern
{
    public class FamilyDoctor
    {
        private Dictionary<string, Kid> _kids = new Dictionary<string, Kid>();

        public Dictionary<string, Kid> Patients
        {
            get { return _kids; }
            set { _kids = value; }
        }


        public void ReciveNotes(string patientName)
        {
            Console.WriteLine("Family Doctor receiving notes...");
            Console.WriteLine("Family Doctor received {0}'s new daily status. \n" +
                              "updates on: {1} . \nNotes:{2}",
                             Patients[patientName].Name,
                             Patients[patientName].DailyStatus.UpdatedOn,
                             Patients[patientName].DailyStatus.Description);
        }

    }
}

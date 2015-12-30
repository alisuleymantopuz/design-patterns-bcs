using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.TemplateMethodPattern
{
    public class ITDepartmentHiringProcessor : HiringProcessor
    {
        public override void FirstRoundHrInterview()
        {
            Console.WriteLine("Meetings..");
            Console.WriteLine("Solving Low level it departments tests...");
        }

        public override void TechnicalInterview()
        {
            Console.WriteLine("Solving High level it departments tests...");
        }
    }
}

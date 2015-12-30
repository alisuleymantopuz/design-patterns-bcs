using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.TemplateMethodPattern
{
    public class MarketingDepartmentHiringProcessor : HiringProcessor
    {
        public override void FirstRoundHrInterview()
        {
            Console.WriteLine("Meetings..");
        }

        public override void TechnicalInterview()
        {
            Console.WriteLine("Solving marketing departments tests...");
        }
    }
}

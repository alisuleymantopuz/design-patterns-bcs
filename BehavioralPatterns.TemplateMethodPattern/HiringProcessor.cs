using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BehavioralPatterns.TemplateMethodPattern
{
    public abstract class HiringProcessor
    {
        public void HireEmploye()
        {
            FirstRoundHrInterview();
            Thread.Sleep(1000);
            GroupDiscussion();
            Thread.Sleep(1000);
            TechnicalInterview();
            Thread.Sleep(1000);
            TheLastHrInterviewAndOffering();
        }


        public abstract void FirstRoundHrInterview();

        private void GroupDiscussion()
        {
            Console.WriteLine("Group discussion and assessment of the situation..");
        }

        public abstract void TechnicalInterview();

        private void TheLastHrInterviewAndOffering()
        {
            Console.WriteLine("The last interview and make an offer..");
        }

    }
}

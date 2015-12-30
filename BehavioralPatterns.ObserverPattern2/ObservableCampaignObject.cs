using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern2
{
    public delegate void CampaignStateChangeHandler(object campaignObject, CampaignStatus campaignStatus);

    public class ObservableCampaignObject
    {
        private event CampaignStateChangeHandler _campaignStateChangeEvent;
       
        public event CampaignStateChangeHandler CampaignStateChangeEvent
        {
            add { this._campaignStateChangeEvent += value; }
            remove { this._campaignStateChangeEvent -= value; }
        }

        protected void Notify(object campaignObject, CampaignStatus campaignStatus)
        {
            if (_campaignStateChangeEvent != null)
            {
                _campaignStateChangeEvent(campaignObject, campaignStatus);
            }
        }
    }
}

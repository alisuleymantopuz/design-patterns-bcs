using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern2
{
    public class ProductCampaignController : ObservableCampaignObject
    {
        public Product Product { get; private set; }

        private CampaignStatus _campaignStatus;

        public int DiscountRate { get; set; }

        public CampaignStatus CampaignStatus
        {
            get { return this._campaignStatus; }
        }

        public ProductCampaignController(Product product)
        {
            this.Product = product;
        }

        public decimal CalculateDiscountedPrice()
        {
            switch (CampaignStatus)
            {
                case CampaignStatus.None:
                    return this.Product.Price;
                default:
                    {
                        return this.Product.Price.ComputeDiscountedPrice((int) this.CampaignStatus);
                    }
                    break;
            }
        }

        public void ChangeCampaignStatus(CampaignStatus newStatus)
        {
            this._campaignStatus = newStatus;
            this.DiscountRate = (int)newStatus;
            this.Product.DiscountedPrice = this.CalculateDiscountedPrice();
            this.Notify(this.Product, newStatus);
        }
    }
}

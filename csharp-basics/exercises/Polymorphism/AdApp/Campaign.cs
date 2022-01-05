using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> campaign;

        public Campaign() 
        {
            campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a) 
        {
            campaign.Add(a);
        }

        public int GetCost()
        {
            return campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {
            foreach (var item in campaign)
            {
                return "Advert Campaign " + item.GetType().Name + "\nTotal Cost = " + GetCost();
            }

            return "";
        }
    }
}
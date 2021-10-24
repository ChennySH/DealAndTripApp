using System;
using System.Collections.Generic;


namespace DealAndTripServerBL.Models
{
    public partial class TravelSite
    {
        public TravelSite()
        {
            VacationsTravelSites = new List<VacationsTravelSite>();
        }

        public int Id { get; set; }
        public int CityId { get; set; }
        public string WebSiteLink { get; set; }

        public virtual List<VacationsTravelSite> VacationsTravelSites { get; set; }
    }
}

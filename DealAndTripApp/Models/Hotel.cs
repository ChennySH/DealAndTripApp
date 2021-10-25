using System;
using System.Collections.Generic;



namespace DealAndTripApp.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            HotelsVacactions = new List<HotelsVacaction>();
        }

        public int Id { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
        public string WebSiteLink { get; set; }

        public virtual List<HotelsVacaction> HotelsVacactions { get; set; }
    }
}

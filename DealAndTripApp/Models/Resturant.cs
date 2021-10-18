using System;
using System.Collections.Generic;


namespace DealAndTripApp.Models
{
    public partial class Resturant
    {
        public Resturant()
        {
            VacationsResturants = new List<VacationsResturant>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public string WebSiteLink { get; set; }

        public virtual List<VacationsResturant> VacationsResturants { get; set; }
    }
}

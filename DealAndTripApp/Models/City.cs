using System;
using System.Collections.Generic;


namespace DealAndTripApp.Models
{
    public partial class City
    {
        public City()
        {
            VacationsCities = new List<VacationsCity>();
        }

        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }

        public virtual Country Country { get; set; }
        public virtual List<VacationsCity> VacationsCities { get; set; }
    }
}

using System;
using System.Collections.Generic;



namespace DealAndTripServerBL.Models
{
    public partial class Country
    {
        public Country()
        {
            Cities = new List<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<City> Cities { get; set; }
    }
}

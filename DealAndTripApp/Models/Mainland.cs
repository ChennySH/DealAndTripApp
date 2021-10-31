using System;
using System.Collections.Generic;


namespace DealAndTripApp.Models
{
    public partial class Mainland
    {
        public Mainland()
        {
            Countries = new List<Country>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Country> Countries { get; set; }
    }
}

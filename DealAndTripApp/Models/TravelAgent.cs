using System;
using System.Collections.Generic;


namespace DealAndTripApp.Models
{
    public partial class TravelAgent
    {
        public int Rank { get; set; }
        public string UserName { get; set; }

        public virtual User UserNameNavigation { get; set; }
    }
}

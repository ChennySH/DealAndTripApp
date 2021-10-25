using System;
using System.Collections.Generic;



namespace DealAndTripApp.Models
{
    public partial class TravelAgent
    {
        public TravelAgent()
        {
            Users = new List<User>();
        }

        public int Id { get; set; }
        public int Rank { get; set; }
        public string UserName { get; set; }

        public virtual User UserNameNavigation { get; set; }
        public virtual List<User> Users { get; set; }
    }
}

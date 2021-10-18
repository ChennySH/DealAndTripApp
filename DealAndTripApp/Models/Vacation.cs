using System;
using System.Collections.Generic;


namespace DealAndTripApp.Models
{
    public partial class Vacation
    {
        public Vacation()
        {
            HotelsVacactions = new List<HotelsVacaction>();
            VacationsCities = new List<VacationsCity>();
            VacationsResturants = new List<VacationsResturant>();
            VacationsTravelSites = new List<VacationsTravelSite>();
        }

        public int Id { get; set; }
        public string TravelAgentUserName { get; set; }
        public int TypeId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Rank { get; set; }
        public int EnterFlightId { get; set; }
        public int ExitFlightId { get; set; }
        public int NightsNumber { get; set; }

        public virtual Flight EnterFlight { get; set; }
        public virtual Flight ExitFlight { get; set; }
        public virtual VacationType Type { get; set; }
        public virtual List<HotelsVacaction> HotelsVacactions { get; set; }
        public virtual List<VacationsCity> VacationsCities { get; set; }
        public virtual List<VacationsResturant> VacationsResturants { get; set; }
        public virtual List<VacationsTravelSite> VacationsTravelSites { get; set; }
    }
}

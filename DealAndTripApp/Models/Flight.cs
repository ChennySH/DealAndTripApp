using System;
using System.Collections.Generic;



namespace DealAndTripApp.Models
{
    public partial class Flight
    {
        public Flight()
        {
            VacationEnterFlights = new List<Vacation>();
            VacationExitFlights = new List<Vacation>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime TakeOffTime { get; set; }
        public TimeSpan FlightTime { get; set; }
        public DateTime LandingTime { get; set; }
        public int StartingPointCityId { get; set; }
        public int DestinationCityId { get; set; }

        public virtual List<Vacation> VacationEnterFlights { get; set; }
        public virtual List<Vacation> VacationExitFlights { get; set; }
    }
}

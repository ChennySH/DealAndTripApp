using System;
using System.Collections.Generic;


namespace DealAndTripServerBL.Models
{
    public partial class VacationType
    {
        public VacationType()
        {
            Vacations = new List<Vacation>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }

        public virtual List<Vacation> Vacations { get; set; }
    }
}

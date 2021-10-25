using System;
using System.Collections.Generic;


namespace DealAndTripApp.Models
{
    public partial class VacationsResturant
    {
        public int Id { get; set; }
        public int VacationId { get; set; }
        public int ResturantId { get; set; }

        public virtual Resturant Resturant { get; set; }
        public virtual Vacation Vacation { get; set; }
    }
}

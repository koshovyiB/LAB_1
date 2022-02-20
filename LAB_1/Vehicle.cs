using System;
using System.Collections.Generic;

namespace LAB_1
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Rentals = new HashSet<Rental>();
        }

        public int Id { get; set; }
        public string Vin { get; set; } = null!;
        public string AvaliableIndicator { get; set; } = null!;
        public int Odometr { get; set; }
        public string Mark { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }
        public string ConditionDesc { get; set; } = null!;

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}

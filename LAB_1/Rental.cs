using System;
using System.Collections.Generic;

namespace LAB_1
{
    public partial class Rental
    {
        public int Id { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime DropoffDate { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public int BranchId { get; set; }

        public virtual Branch Branch { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual Vehicle Vehicle { get; set; } = null!;
    }
}

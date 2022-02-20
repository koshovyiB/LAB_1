using System;
using System.Collections.Generic;

namespace LAB_1
{
    public partial class Branch
    {
        public Branch()
        {
            Rentals = new HashSet<Rental>();
        }

        public int Id { get; set; }
        public string BranchName { get; set; } = null!;
        public int AddressId { get; set; }

        public virtual Address Address { get; set; } = null!;
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}

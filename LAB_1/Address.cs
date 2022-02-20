using System;
using System.Collections.Generic;

namespace LAB_1
{
    public partial class Address
    {
        public Address()
        {
            Branches = new HashSet<Branch>();
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string StreetAddress { get; set; } = null!;
        public int StateId { get; set; }

        public virtual State State { get; set; } = null!;
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}

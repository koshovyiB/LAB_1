using System;
using System.Collections.Generic;

namespace LAB_1
{
    public partial class State
    {
        public State()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CityId { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace LAB_1
{
    public partial class City
    {
        public City()
        {
            States = new HashSet<State>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<State> States { get; set; }
    }
}

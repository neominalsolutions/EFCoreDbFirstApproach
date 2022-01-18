using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDbFirstApproach.Data
{
    public partial class Address
    {
        public Guid Id { get; set; }
        public string StreetName { get; set; }
        public string Provience { get; set; }
        public string City { get; set; }
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}

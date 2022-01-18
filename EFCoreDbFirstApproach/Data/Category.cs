using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDbFirstApproach.Data
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public string Information { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace EF_DBFirstApproachDemo.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal? Price { get; set; }
        public byte? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}

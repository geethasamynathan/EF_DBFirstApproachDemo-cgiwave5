﻿using System;
using System.Collections.Generic;

namespace EF_DBFirstApproachDemo.Models
{
    public partial class CardDetail
    {
        public decimal CardNumber { get; set; }
        public string NameOnCard { get; set; } = null!;
        public decimal Cvvnumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal? Balance { get; set; }
    }
}

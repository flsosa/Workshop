﻿using System;

namespace Divergent.Finance.Data.Models
{
    public class Price
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public double ItemPrice { get; set; }
    }
}

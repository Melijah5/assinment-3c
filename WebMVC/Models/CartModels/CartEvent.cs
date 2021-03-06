﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Models.CartModels
{
    public class CartEvent
    {
        public string Id { get; set; }
        public string EventName { get; set; }
        public string EventId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OldUnitprice { get; set; }
        public int Quantity { get; set; }
        public string EventImageUrl { get; set; }

        public int ProductId { get; set; }
    }
}

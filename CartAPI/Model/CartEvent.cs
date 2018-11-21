using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartAPI.Models
{
    public class CartEvent
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string EventName { get; set; }
        public int EventId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OldUnitprice { get; set; }
        public int Quantity { get; set; }
        public string EventImageUrl { get; set; }
    }
}

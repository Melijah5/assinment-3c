using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Models.OrderModels
{
    public class OrderEvent
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }


        public int Units { get; set; }

      
        public string EventImageUrl { get; set; }
        
        public int ProductId { get; private set; }

       
    }
}

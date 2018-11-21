using ShoesOnContainers.Services.OrderApi.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesOnContainers.Services.OrderApi.Models
{
    public class OrderEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
         
         public string ProductName { get; set; }
        public string EventImageUrl { get; set; }
        public decimal UnitPrice { get; set; }
        
        public int Units { get; set; }
        public int ProductId { get; private set; }

        protected OrderEvent() { }
        public Order Order { get; set; }
        public int OrderId { get; set; }

        public OrderEvent(int productId, string productName, decimal unitPrice,   string eventImageUrl, int units = 1)
        {
            if (units <= 0)
            {
                throw new OrderingDomainException("Invalid number of units");
            }

            ProductId = productId;

            ProductName = productName;
            UnitPrice = unitPrice;
            
            Units = units;
            EventImageUrl = eventImageUrl;
        }
        public void SetPictureUri(string pictureUri)
        {
            if (!String.IsNullOrWhiteSpace(pictureUri))
            {
                EventImageUrl = pictureUri;
            }
        }

         

         

        public void AddUnits(int units)
        {
            if (units < 0)
            {
                throw new OrderingDomainException("Invalid units");
            }

            Units += units;
        }

    }
}

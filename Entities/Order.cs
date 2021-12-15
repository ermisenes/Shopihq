using System;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities
{
    public class Order : IEntity
    {
        
        public int Id { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public string StoreName { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedOn { get; set; }
        public OrderStatus Status { get; set; } 
    }
}

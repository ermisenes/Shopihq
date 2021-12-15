using System;
using Entities;

namespace Business.ViewModels
{
    public class OrderFilterListViewModel
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

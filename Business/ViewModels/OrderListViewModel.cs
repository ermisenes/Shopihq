using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModels
{
    public class OrderListViewModel
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public string StoreName { get; set; }
        public string CustomerName { get; set; }
        public string CreatedOn { get; set; }
        public string Status { get; set; }
    }
}

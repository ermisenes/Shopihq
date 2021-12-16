using System.Collections.Generic;
using Business.ViewModels;
using Entities;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<OrderListViewModel> GetAll();
        string Add(Order order);
        OrderFilterModel GetByFilters(OrderFilterModel orderFilterMode);

    }
}

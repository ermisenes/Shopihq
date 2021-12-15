using System.Collections.Generic;
using Business.ViewModels;
using Entities;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<OrderListViewModel> GetAll();
        //Order GetById(int id);
        void Add(Order order);
        void Delete(Order order);
        void Update(Order order);
      
        
        OrderFilterModel GetByFilter(OrderFilterModel orderFilterModel);


        OrderFilterModel GetById(OrderFilterModel orderFilterMode);

    }
}

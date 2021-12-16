using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.ViewModels;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public string Add(Order order)
        {
            var result = _orderDal.Get(x => x.Id == order.Id);
            if (order.BrandId == 0)
            {
                return "Brand ID 0 olduğu için kaydedilemedi";
            }
            else if (result.Count!=0)
            {
                return order.Id + " id'li kayıt bulunmaktadır";
            }
            else
            {
                _orderDal.Add(order);
                return "Kayıt Başarılı";
            }
        }

        public List<OrderListViewModel> GetAll()
        {
            var orderList = _orderDal.GetList().ToList();
            List<OrderListViewModel> orderVMs = new List<OrderListViewModel>();
            foreach (var item in orderList)
            {
                orderVMs.Add(new OrderListViewModel()
                {
                    Id = item.Id,
                    BrandId = item.BrandId,
                    Price = item.Price,
                    StoreName = item.StoreName,
                    CustomerName = item.CustomerName,
                    CreatedOn = item.CreatedOn.Date.ToString("dd/MM/yyyy"),
                    Status = item.Status.ToString(),
                });
            }
            return orderVMs;
        }

        public OrderFilterModel GetByFilters(OrderFilterModel order)
        {
            OrderFilterModel orderFilterModel = new OrderFilterModel();

            order.orders = _orderDal.Get(b => b.CreatedOn >= order.StartDate && b.CreatedOn <= order.EndDate ||
             b.StoreName.ToLower().Contains(order.SearchText.ToLower()) ||
             b.CustomerName.ToLower().Contains(order.SearchText.ToLower())).ToList();

            order.orders = order.orders
            .Skip((order.PageNumber - 1) * order.PageSize)
            .Take(order.PageSize)
            .OrderBy(p => p.GetType().GetProperty(order.SortBy).GetValue(p)).ToList();

            return order;
        }

    }
}

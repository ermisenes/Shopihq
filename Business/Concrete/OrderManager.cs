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

        public void Add(Order order)
        {
            if (order.BrandId == 0)
            {
                throw new InvalidOperationException("Brand Id 0 kaydedilemez");
            }
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            throw new NotImplementedException();
        }

        public OrderFilterModel GetByFilter(OrderFilterModel orderFilterModel)
        {
            return null;
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
        //public Order GetById(int id)
        //{
        //    return _orderDal.Get(b => b.Id == id);
        //}

        public OrderFilterModel GetById(OrderFilterModel order)
        {
            OrderFilterModel orderFilterModel = new OrderFilterModel();

            order.orders = _orderDal.Get(b => b.CreatedOn >= order.StartDate && b.CreatedOn <= order.EndDate ||
             b.StoreName.ToLower().Contains(order.SearchText.ToLower()) ||
             b.CustomerName.ToLower().Contains(order.SearchText.ToLower())).ToList();

            order.orders = order.orders
            .Skip((order.PageNumber - 1) * order.PageSize)
            .Take(order.PageSize)
            .OrderBy(p => p.GetType().GetProperty(order.SortBy).GetValue(p)).ToList();

            var resultx = order;
          
            return order;
        }



        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}

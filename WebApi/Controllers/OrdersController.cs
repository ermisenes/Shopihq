using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ViewModels;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("get/all")]
        public IActionResult GetList()
        {
            return Ok(_orderService.GetAll());
        }

        [HttpPost("add")]
        public void Add(Order order)
        {
            _orderService.Add(order);
        }

        [HttpPut("update")]
        public void Update(Order order)
        {
            _orderService.Update(order);
        }

        //[HttpGet("get/byid")]
        //public IActionResult GetById(int id)
        //{
        //    return Ok(_orderService.GetById(id));
        //}

        [HttpPost("get/byid")]

        public IActionResult GetById([FromBody] OrderFilterModel orderFilterModel)
        {
            return Ok(_orderService.GetById(orderFilterModel));
        }

       // [HttpPost("filters")]
       //public void GetByFilter([FromBody] OrderFilterModel orderFilterModel)
       // {
       //     return null;
       // }
    }
}

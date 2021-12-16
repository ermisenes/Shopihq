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
        public IActionResult Add(Order order)
        {
            return Ok(_orderService.Add(order));
        }

        [HttpPost("get")]
        public IActionResult GetByFilters([FromBody] OrderFilterModel orderFilterModel)
        {
            return Ok(_orderService.GetByFilters(orderFilterModel));
        }
    }
}

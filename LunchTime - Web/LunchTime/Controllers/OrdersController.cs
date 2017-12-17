using AutoMapper;
using LunchTime.Data;
using LunchTime.Data.Entities;
using LunchTime.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchTime.Controllers
{
    [Route("api/[Controller]")] 
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class OrdersController : Controller
    {
        
        private readonly ILunchTimeRepository _repository;
        private readonly ILogger<OrdersController> _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<Customer> _userManager;

        public OrdersController(ILunchTimeRepository repository, 
            ILogger<OrdersController> logger, 
            IMapper mapper,
            UserManager<Customer> userManager)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Get(bool includeItems = true)
        {
            try
            {
                var username = User.Identity.Name;

                var results = _repository.GetAllOrdersByUser(username, includeItems);

                return Ok(_mapper.Map<IEnumerable<Order>, IEnumerable<OrderViewModel>>(results));
            }
            catch (Exception ex)
            {

                _logger.LogError($"Failed to get orders: {ex}");
                return BadRequest("Failed to get orders");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                var order = _repository.GetOrderById(User.Identity.Name, id);
                if (order != null) return Ok(_mapper.Map<Order, OrderViewModel>(order));
                else return NotFound(); // This is preferred than BadRequest
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get orders: {ex}");
                return BadRequest("Failed to get orders");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]OrderViewModel model)
        {
            // add it to the db
            try
            {
                if (ModelState.IsValid)
                {
                    var newOrder = _mapper.Map<OrderViewModel, Order>(model);

                        newOrder.OrderDate = DateTime.Now;

                    var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);
                    newOrder.Customer = currentUser;

                    newOrder.OrderStatus = "Aktiv";

                    _repository.AddOrder(newOrder);
                    if (_repository.SaveAll())
                    {
                        return Created($"/api/orders/{newOrder.Id}", _mapper.Map<Order, OrderViewModel>(newOrder));
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to save a new order: {ex}");
            }

            return BadRequest("Failed to save new order");
        }
    }
}

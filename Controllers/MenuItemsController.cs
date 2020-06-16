using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using yummy_tummy.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using yummy_tummy.Controllers.Resources;

namespace yummy_tummy.Controllers
{
    public class MenuItemsController:Controller 
    {
        private readonly MenuContext context;
        private readonly IMapper mapper;
        public MenuItemsController(MenuContext context,IMapper mapper)
        {
            this.mapper=mapper;
            this.context=context;
        }
        [HttpGet("/api/menuItems")]
        public async Task<IEnumerable<MenuResource>> GetMenuItems()
        {
            var menu= await context.MenuItems.ToListAsync();
            return mapper.Map<List<MenuItem>, List<MenuResource>>(menu);
        }

        [HttpPost("/api/addOrder")]
        public IActionResult AddOrder([FromBody]OrderResource order) //async Task<IEnumerable<Order>>
        {
           // var menu= await context.Orders..ToListAsync();
            return Ok(order); //mapper.Map<Order, OrderResource>(menu);
        }
    }
}
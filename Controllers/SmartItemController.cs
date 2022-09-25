using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingSmart.Services.ItemsCatalog.Entities;
using ShoppingSmart.Services.ItemsCatalog.Repositories;

namespace ShoppingSmart.Services.ItemsCatalog.Controllers
{
    [ApiController]
    [RouteAttribute("api/SmartItem")]
    public class SmartItemController : ControllerBase
    {
        private readonly ISmartItemRepository _smartItemRepository;

        public SmartItemController(ISmartItemRepository smartItemRepository)
        {
            _smartItemRepository = smartItemRepository ?? 
                                   throw new ArgumentNullException(nameof(smartItemRepository));
        }

        [HttpGet]
        [Route("GetAllSmartItems")]
        public async Task<IActionResult> GetAllSmartItems()
        {
            var smartItems = await _smartItemRepository.GetAllSmartItemsAsync();
            return Ok(smartItems);
        }

        [HttpGet]
        [Route("GetSmartItemById")]
        public async Task<IActionResult> GetSmartItemById(Guid Id)
        {
            var smartItem = await _smartItemRepository.GetSmartItemByIdAsync(Id);

            return Ok(smartItem);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoppingSmart.Services.ItemsCatalog.DbContexts;
using ShoppingSmart.Services.ItemsCatalog.Entities;

namespace ShoppingSmart.Services.ItemsCatalog.Repositories
{
    public class SmartItemRepository : ISmartItemRepository
    {
        private readonly ItemCatalogDbContext _itemCatalogDbContext;

        //public SmartItemRepository(ItemCatalogDbContext itemCatalogDbContext)
        //{
        //    //_itemCatalogDbContext = itemCatalogDbContext;
        //}

        public SmartItemRepository()
        {
                
        }

        public async Task<IEnumerable<SmartItem>> GetAllSmartItemsAsync()
        {
            var smartItems = new List<SmartItem>
            {
                new SmartItem
                {
                    Name = "Icol", Description = "Keyboard logi", BrandName = "logiMouse", Price = (decimal) 12.99
                }
            };
            return smartItems;
            //return await _itemCatalogDbContext.SmartItems.ToListAsync();
        }

        public async Task<SmartItem> GetSmartItemByIdAsync(Guid smartItem)
        {
            var smartItemToReturn = new SmartItem();
            smartItemToReturn.Name = "Icol";
            smartItemToReturn.Description = "Keyboard logi";
            smartItemToReturn.BrandName = "logi";
            smartItemToReturn.Price = (decimal)12.99;
            return smartItemToReturn;

            //return await _itemCatalogDbContext.SmartItems.Where(i => i.Id == smartItem).FirstOrDefaultAsync();
        }
    }
}

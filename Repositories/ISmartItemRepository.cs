using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShoppingSmart.Services.ItemsCatalog.Entities;

namespace ShoppingSmart.Services.ItemsCatalog.Repositories
{
    public interface ISmartItemRepository
    {
        Task<IEnumerable<SmartItem>> GetAllSmartItemsAsync();
        Task<SmartItem> GetSmartItemByIdAsync(Guid smartItem);
    }
}
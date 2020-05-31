using System;
using System.Collections.Generic;
using System.Linq;
using GildedRoseBoutique.Models;

namespace GildedRoseBoutique.Persistence
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _appDbContext;
        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Item> GetAllItems
        {
            get
            {
                return _appDbContext.Items;
            }
        }

        public Item GetItemById(int ItemId)
        {
            return _appDbContext.Items.FirstOrDefault(c => c.ItemId == ItemId);
        }

        public void ProcessItemById(int ItemId)
        {
            var item = GetItemById(ItemId);
            if(item != null)
            {
                var quantity = item.Quantity;
                item.Quantity = quantity - 1;
                _appDbContext.SaveChanges();
            }         
        }
    }
}

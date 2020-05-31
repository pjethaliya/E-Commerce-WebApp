using System;
using System.Collections.Generic;
namespace GildedRoseBoutique.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAllItems { get; }

        Item GetItemById(int ItemId);

        void ProcessItemById(int ItemId);
    }
}

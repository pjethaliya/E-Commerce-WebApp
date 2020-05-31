using System;
using System.Collections.Generic;
using GildedRoseBoutique.Models;

namespace GildedRoseBoutique.Persistence
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAllItems { get; }

        Item GetItemById(int ItemId);

        void ProcessItemById(int ItemId);
    }
}

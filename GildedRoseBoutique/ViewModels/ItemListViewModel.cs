using System;
using System.Collections.Generic;
using GildedRoseBoutique.Models;

namespace GildedRoseBoutique.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Items { get; set; }
    }
}

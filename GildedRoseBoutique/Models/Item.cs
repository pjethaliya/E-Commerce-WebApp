using System;
namespace GildedRoseBoutique.Models
{
    public class Item
    {
        

        public int ItemId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        
        public int Quantity { get; set; }

    }
}

using System;
using GildedRoseBoutique.Models;

namespace GildedRoseBoutique.Persistence
{
    public interface IOrderRepository
    {
        
        void CreateOrder(Order order);
    }
}

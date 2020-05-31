using System;
namespace GildedRoseBoutique.Models
{
    public interface IOrderRepository
    {
        
        void CreateOrder(Order order);
    }
}

using System;
namespace GildedRoseBoutique.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        public OrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlacedTime = DateTime.Now;
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}

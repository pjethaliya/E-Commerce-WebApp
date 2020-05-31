using System;
using GildedRoseBoutique.Models;
using GildedRoseBoutique.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GildedRoseBoutique.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {


        private readonly IItemRepository _itemRepository;
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository, IItemRepository itemRepository)
        {
            _orderRepository = orderRepository;
            _itemRepository = itemRepository;
        }
        //CheckOut Contact form when user buy item
        public IActionResult Checkout(int id)
        {
            
            var item = _itemRepository.GetItemById(id);
            if (item == null)
                return NotFound();

            var order = new Order();
            order.Items = item;

            return View(order);
            
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _orderRepository.CreateOrder(order);

            _itemRepository.ProcessItemById(order.ItemId);
            return RedirectToAction("CheckoutComplete");
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.ThankyouMessage = "Thank you for your order!";
            return View();
        }
    }
}

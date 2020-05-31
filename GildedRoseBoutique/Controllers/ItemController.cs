using System;
using GildedRoseBoutique.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace GildedRoseBoutique.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        //List all the items on the home page        
        public IActionResult List()
        {
            
            return View(_itemRepository.GetAllItems);

        }
        //Get details view of the product
        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
                return NotFound();

            return View(item);
        }

    }

}

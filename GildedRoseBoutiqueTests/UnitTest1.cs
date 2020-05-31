using System;
using System.Collections.Generic;
using System.Linq;
using GildedRoseBoutique.Controllers;
using GildedRoseBoutique.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using GildedRoseBoutique.ViewModels;

namespace GildedRoseBoutiqueTests
{
    public class UnitTest1
    {
        [Fact]
        public void GetAllItemsTest()
        {
            //Arrange
            var mockItemRepository = new Mock<IItemRepository>();
            mockItemRepository.Setup(repo => repo.GetAllItems).Returns(GetTestItems());
            var itemController = new ItemController(mockItemRepository.Object);

            //Act
            var result = itemController.List();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<Item>>(viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());

        }

        [Fact]
        public void GetItemByIdTest()
        {
            //Arrange
            var mockItemRepository = new Mock<IItemRepository>();
            mockItemRepository.Setup(repo => repo.GetItemById(1)).Returns(GetTestItemByItemId());
            var itemController = new ItemController(mockItemRepository.Object);

            //Act
            var result = itemController.Details(1);

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<Item>(viewResult.ViewData.Model);
            Assert.Equal("Item1",model.Name);

        }

        private Item GetTestItemByItemId()
        {
            return new Item()
            {
                ItemId = 1,
                Name = "Item1",
                Description = "Item 1 Description",
                Price = 20.00M,
                ImageUrl = "\\Images\\item1.jpeg",
                Quantity = 0
            };
        }

        private IEnumerable<Item> GetTestItems()
        {
            return new List<Item>()
            {


                new Item ()
                {
                    ItemId = 1,
                    Name = "Item1",
                    Description = "Item 1 Description",
                    Price = 20.00M, ImageUrl = "\\Images\\item1.jpeg",
                    Quantity = 0
                },
                new Item {
                    ItemId = 2,
                    Name = "Item2",
                    Description = "Item 2 Description",
                    Price = 45.00M,
                    ImageUrl = "\\Images\\item2.jpeg",
                    Quantity = 5
                }
            
            };
        }
    }
}

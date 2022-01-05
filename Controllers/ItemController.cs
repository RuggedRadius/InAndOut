using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class ItemController : Controller
    {
        private Item[] itemDbSimulation = { 
            new Item { Id = 0, Borrower = "Bob" },
            new Item { Id = 1, Borrower = "Billy" },
            new Item { Id = 2, Borrower = "Bob" },
            new Item { Id = 3, Borrower = "Jill" },
            new Item { Id = 4, Borrower = "Jill" },
            new Item { Id = 5, Borrower = "Sherry" },
            new Item { Id = 6, Borrower = "Bob" },
            new Item { Id = 7, Borrower = "Karyn" },
            new Item { Id = 8, Borrower = "Eddie" },
            new Item { Id = 9, Borrower = "Billy" },
        };

        public IActionResult Index()
        {
            // Get items list from "database"
            List<Item> itemsList = GetItemsList();

            // To test an empty data set, un-comment this:
            //itemsList = new List<Item>();

            return View(itemsList);
        }

        private List<Item> GetItemsList()
        {
            List<Item> items = new List<Item>();

            for (int i = 0; i < 5; i++)
            {
                items.Add(GetRandomItem());
            }

            return items;
        }

        private Item GetRandomItem()
        {
            Random rand = new Random();

            int randomIndex = rand.Next(0, itemDbSimulation.Length);

            return itemDbSimulation[randomIndex];
        }


        public IActionResult Create()
        {
            return View();
        }
    }
}

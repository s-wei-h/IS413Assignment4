using FoodieSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FoodieSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Show list of top 5 restaurants on index
        public IActionResult Index()
        {
            List<string> RestaurantList = new List<string>();

            foreach(Restaurant rest in Restaurant.GetRestaurants())
            {
                string? phone = rest.rPhone ?? "N/A";
                RestaurantList.Add($"Rank {rest.Rank}: {rest.rName}. Favorite Dish: {rest.rFavDish}. Location: {rest.rAddress}. Phone #: {rest.rPhone}. Website link: {rest.rLink}");
            }
            return View(RestaurantList);
        }

        //View all suggestions page
        public IActionResult Suggestions()
        {
            return View(TempStorage.Suggestions);
        }

        //Add Suggestion Page
        [HttpGet]
        public IActionResult AddSuggest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Suggestion NewSuggestion)
        {
            TempStorage.addSuggestion(NewSuggestion);

            return View("AddConfirm", NewSuggestion);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

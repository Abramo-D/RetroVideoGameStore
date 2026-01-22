using Microsoft.AspNetCore.Mvc;
using RetroVideoGameStore.Models;
using System.ComponentModel.DataAnnotations;

namespace RetroVideoGameStore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            // use category modle to make a fake list of 10 categories
            // create an empty list of categories
            var categories = new List<Category>();
            // loop 10 times to create 10 categories
            for (int i = 1; i<= 10; i++)
            {
                categories.Add(new Category
                {
                    CategoryId = i,
                    CategoryName = "Category " + i.ToString()
                });
            }
        //pass the list to the view for display
            return View(categories);
        }
        public IActionResult Browse(string categoryName)
        {
            // Grab the category name passed in with the URL
            ViewBag.CategoryName = categoryName;
            return View();

        }
        public IActionResult AddCategory()
        {
            //display a form for the user to add a new catagory
            return View();
        }

    }
}

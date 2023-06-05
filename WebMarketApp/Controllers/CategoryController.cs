using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarketApp.Data;
using WebMarketApp.Models;

namespace WebMarketApp.Controllers
{
    public class CategoryController : Controller
    {
        //Creat Object From Baster ApllicationDbContext
        private readonly ApplicationDbContext _db;

        //Creat Ctor For give Value to _db
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //Show List Of Data In DataBase
            IEnumerable<Category> CategoryList = _db.Categories.ToList();
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarketApp.Data;

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
            return View();
        }
    }
}

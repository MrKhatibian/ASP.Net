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
        //Make Object From Baster ApllicationDbContext
        private readonly ApplicationDbContext _db;
        public IActionResult Index()
        {
            return View();
        }
    }
}

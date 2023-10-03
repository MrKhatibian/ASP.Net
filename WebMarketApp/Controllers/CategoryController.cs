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
            //var CategoryList = _db.Categories.ToList();
            IEnumerable<Category> CategoryList = _db.Categories;
            return View(CategoryList);
        }

        //Get
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "مقدرا فیلد ها نباید یکسان باشد");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
           
        }

        //Get for Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //Find ID For Edit
            var categoryFromDb = _db.Categories.Find(id);
            //var categoryFromDbFirst = _db.Categories.FirstOrDefault(u => u.ID == id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault( u => u.ID == id);

            //Not Send For UnUnik Id Value
            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View();
        }
    }
}

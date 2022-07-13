using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShop.Data;
using MyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: CategoryController
        public ActionResult Index()
        {
            var data = _db.Categories.ToList();
            return View(data);
        }


        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Category p)
        {
            _db.Categories.Add(p);
            await _db.SaveChangesAsync();
            return Redirect("/Admin/Category/Index");
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var value = _db.Categories.Find(id);
            return View(value);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category p)
        {
            _db.Categories.Update(p);
            _db.SaveChanges();
            return Redirect("/Admin/Category/Index");
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var item = _db.Categories.Find(id);
            _db.Categories.Remove(item);
            _db.SaveChanges();
            return Redirect("/Admin/Category/Index");
        }


    }
}

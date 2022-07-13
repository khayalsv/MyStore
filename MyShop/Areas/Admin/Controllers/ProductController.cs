using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyShop.Data;
using MyShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        private IWebHostEnvironment _we;

        public ProductController(ApplicationDbContext db, IWebHostEnvironment we)
        {
            _db = db;
            _we = we;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            var value = _db.Products.Include(x => x.Category).ToList();
            return View(value);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            ViewData["categoryId"] = new SelectList(_db.Categories.ToList(), "Id", "Name");
            var product = _db.Products.Include(x => x.Category).FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            ViewData["categoryId"] = new SelectList(_db.Categories.ToList(), "Id", "Name");
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product p, IFormFile image)
        {

            if (ModelState.IsValid)
            {
                var searchProduct = _db.Products.FirstOrDefault(x => x.Name == p.Name);
                if (searchProduct != null)
                {
                    ViewBag.message = "This product is already exist";
                    ViewData["categoryId"] = new SelectList(_db.Categories.ToList(), "Id", "Name");
                    return View(p);
                }
                if (image != null)
                {
                    var name = Path.Combine(_we.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    p.Image = "Images/" + image.FileName;
                }
                _db.Products.Add(p);
                await _db.SaveChangesAsync();
                return Redirect("/Admin/Product/Index");
            }
            return View(p);
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewData["categoryId"] = new SelectList(_db.Categories.ToList(), "Id", "Name");
            var product = _db.Products.Include(x => x.Category).FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Product p, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    var name = Path.Combine(_we.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    p.Image = "Images/" + image.FileName;
                }

                _db.Products.Update(p);
                await _db.SaveChangesAsync();
                return Redirect("/Admin/Product/Index");

            }
            return View(p);
        }

        // GET: ProductController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var product = _db.Products.Include(x => x.Category).Where(x => x.Id == id).FirstOrDefault();

            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            return Redirect("/Admin/Product/Index");
        }


    }
}

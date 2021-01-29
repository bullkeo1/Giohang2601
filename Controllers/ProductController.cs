using System;
using System.IO;
using System.Linq;
using Giohang2601.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Giohang2601.Controllers
{
    public class ProductController : Controller
    {
        private ModelSaleContext db;

        public ProductController(ModelSaleContext db)
        {
            this.db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public IActionResult Detail(string id)
        {
            var model = db.Products.Find(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product, IFormFile file )
        {
            try
            {
                var model = db.Products.SingleOrDefault(p => p.ProductId.Equals(product.ProductId));
                if (file.Length > 0)
                {
                    string fileName = Path.GetFileName(file.FileName);
                    string path = Path.Combine("/image", fileName);
                    product.Photo = "images" + fileName;
                }
                if (model == null)
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var model = db.Products.SingleOrDefault(p => p.ProductId.Equals(product.ProductId));
            if (model == null)
            {
                return BadRequest();
            }
            else
            {
                model.ProductName = product.ProductName;
                model.Price = product.Price;
                model.Photo = product.Photo;
                db.SaveChanges();
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = db.Products.SingleOrDefault(p => p.ProductId.Equals(id));
            if (model == null)
            {
                return BadRequest();
            }
            else
            {
                db.Remove(model);
            }

            return View();
        }
    }
   
}
























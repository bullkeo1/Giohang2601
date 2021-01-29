using System.Collections.Generic;
using System.Linq;
using Giohang2601.Models;
using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Giohang2601.Controllers
{
    public class OrderController : Controller
    {
        
        private ModelSaleContext db;

        public OrderController(ModelSaleContext context)
        {
            db = context;
        }

        // GET
        public IActionResult Index()
        {
            List<Orders> order = new List<Orders>();
             var cart = HttpContext.Session.GetString("cartKey");
             order = JsonConvert.DeserializeObject<List<Orders>>(cart);
            return View(order);
        }

        public IActionResult Buy(string id)
        {
            if (HttpContext.Session.GetString("cartKey") == null)
            {
                List<Orders>cart = new List<Orders>();
                cart.Add(new Orders
                {
                    Product=db.Products.SingleOrDefault(p=>p.ProductId.Equals(id)),
                    Quantity = 1
                });
                HttpContext.Session.SetString("cartKey",JsonConvert.SerializeObject(cart));
            }
            else
            {
                List<Orders> cart = JsonConvert.DeserializeObject<List<Orders>>
                    (HttpContext.Session.GetString("cartKey"));
                
                var index = CheckExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Orders
                    {
                        Product=db.Products.SingleOrDefault(p=>p.ProductId.Equals(id)),
                            Quantity= 1
                    });
                }
                HttpContext.Session.SetString("cartKey",JsonConvert.SerializeObject(cart));
            }

            return RedirectToAction("Index");
        }

        public int CheckExist(string id)
        {
            List<Orders> carts = JsonConvert.DeserializeObject<List<Orders>>(HttpContext.Session.GetString("cartKey"));
            for (int i = 0; i < carts.Count; i++)
            {
                if (carts[i].Product.ProductId.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        public ActionResult Remove(string id)
        {
            List<Orders> carts = JsonConvert.DeserializeObject<List<Orders>>(HttpContext.Session.GetString("cartKey"));
            var index = CheckExist(id);
            carts.RemoveAt(index);
            HttpContext.Session.SetString("cartKey",JsonConvert.SerializeObject(carts));
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            List<Orders> carts = JsonConvert.DeserializeObject<List<Orders>>(HttpContext.Session.GetString("cart"));
            var index = CheckExist(id);
            return View();
        }
    }
}































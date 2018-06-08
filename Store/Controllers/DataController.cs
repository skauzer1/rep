using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Store.Data;
using Store.Data.Entities;
using Store.Infrastructure.Providers;

namespace Store.Controllers {
    [Route("api/v1/[Controller]")]
    public class DataController : Controller {
        private readonly IStoreProvider Provider;
        StoreContext db = new StoreContext();

        public ActionResult Index()
        {
            IEnumerable<Goods> goods = db.Goods;
            ViewBag.Goods = goods;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.GoodId = id;
            return View();
        }

        [HttpPost]
        public void Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
        }

        public DataController(IStoreProvider provider) {
            Provider = provider;
        }

        [HttpGet("gds")]
        public async Task<IActionResult> GetGds() {
            throw new NotImplementedException();
        }
    }
}

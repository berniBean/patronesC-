using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Earn._4ConcreteCreator;

namespace PAtronesMVC.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index(decimal total)
        {
            //factories
            LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.2m);
            ForeingEarnFactory foreingEarnFactory = new ForeingEarnFactory(0.30m, 0.2m);

            //product
            var localEarn = localEarnFactory.GetEarn();
            var foreingEarn = foreingEarnFactory.GetEarn();

            //total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeing = total + foreingEarn.Earn(total);
            return View();
        }
    }
}

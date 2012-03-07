using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NinjectControllerFactoryExample.Models.Abstract;

namespace NinjectControllerFactoryExample.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}

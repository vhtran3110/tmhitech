using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMHitech.Models;
using TMHitech.MVC.Data;
using TMHitech.MVC.ViewModels;

namespace TMHitech.MVC.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext db = new AppDbContext();
        public ActionResult Index()
        {
            var model = new HomeViewModel
            {
                FeaturedProduct = new Product()
                {
                    Name = "HỆ THỐNG GÂY MÊ KÈM THỞ PASITHEC HEYER",
                    Model = "Pasithec",
                    Manufacturer = "HEYER",
                    Country = "ĐỨC",
                    Image = "/Content/Images/product-01.jpg"
                },
                LatestNews = db.News
            .OrderByDescending(x => x.CreatedDate)
            .Take(4)
            .ToList()
            };
            model.Manufacturers = db.Manufacturers.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            var model = new HomeViewModel();

            model.LatestNews = db.News
                .OrderByDescending(n => n.CreatedDate)
                .Take(3)
                .ToList();

            return View(model);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
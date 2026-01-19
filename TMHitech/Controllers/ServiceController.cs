using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMHitech.MVC.Data;
using TMHitech.MVC.ViewModels;

namespace TMHitech.Controllers
{
    public class ServiceController : Controller
    {
        AppDbContext db = new AppDbContext();
        public ActionResult Index()
        {
            var model = new HomeViewModel();

            model.LatestNews = db.News
                .OrderByDescending(n => n.CreatedDate)
                .Take(3)
                .ToList();

            return View(model);
        }
    }
}
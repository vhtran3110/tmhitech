using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMHitech.Models;

namespace TMHitech.MVC.ViewModels
{
    public class HomeViewModel
    {
        public Product FeaturedProduct { get; set; }
        public List<Category> Categories { get; set; }
        = new List<Category>();

        public List<News> News { get; set; }
        = new List<News>();
        public List<Manufacturer> Manufacturers { get; set; }
        = new List<Manufacturer>();
    }
}
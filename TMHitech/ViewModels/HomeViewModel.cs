using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMHitech.MVC.ViewModels
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }

        public List<News> News { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProje.Data;
using TestProje.Models.DbModels;

namespace TestProje.Areas.Admin.Controllers
{
    public class KategoriController : Controller
    {
        public ActionResult Index()
        {
            List<Kategori> kategori = new List<Kategori>(); //Db models ismi ile
            using (BlogContext cx=new BlogContext())
            {
                
            }

            return View();
        }
    }
}
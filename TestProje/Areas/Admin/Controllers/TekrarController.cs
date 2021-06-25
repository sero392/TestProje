using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProje.Data;
using TestProje.Models.DbModels;

namespace TestProje.Areas.Admin.Controllers
{
    public class TekrarController : Controller
    {
        // GET: Admin/Tekrar
        public ActionResult Index()
        {
            List<Blog> bloglar = new List<Blog>();
            using (BlogContext n = new BlogContext())
            {
                bloglar = n.Bloglar.ToList();
            }
            return View(bloglar);
        }

        public ActionResult BlogIslemleriTekrar()
        {
            return View();
        }

        [HttpPost]
        public JsonResult PostIslemleriTekrar(Blog blog)
        {
             var sonuc = "";
            try
            {
                using (BlogContext x= new BlogContext())
                {
                    x.Bloglar.Add(blog);
                    x.SaveChanges();
                }
                sonuc = "başarılı";
            }
            catch (Exception ex)
            {

                sonuc = "işlwm hatası";
            }



            return Json(sonuc);
        }
    }
}
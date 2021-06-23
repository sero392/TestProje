using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProje.Data;
using TestProje.Models.DbModels;

namespace TestProje.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            List<Blog> bloglar = new List<Blog>();
            using (BlogContext cx = new BlogContext())
            {
               bloglar =  cx.Bloglar.ToList();
            }
            return View(bloglar);
        }

        public ActionResult BlogIslemleri()
        {
            return View();
        }

        [HttpPost]
        public JsonResult PostBlogIslemleri(Blog blog)
        {
            var sonuc = "";
            try
            {
                using (BlogContext cx = new BlogContext())
                {
                    cx.Bloglar.Add(blog);
                    cx.SaveChanges();
                }
                sonuc = "İşlem Başarılı";
            }
            catch (Exception ex)
            {
                sonuc = "Sunucu Hatası : " + ex.StackTrace;
            }
          
            return Json(sonuc);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProje.Data;
using TestProje.Models.DbModels;

namespace TestProje.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
        // GET: Admin/Blog
        public ActionResult Index()
        {
            List<Blog> blogtekrar = new List<Blog>(); //liste halinde yeni bir blog olusturduk
            using (BlogContext x= new BlogContext() ) //veritabanı bağlantısı açıldı
            {
                blogtekrar = x.Bloglar.ToList(); //blogları oluşturmus olduğumuz listenin içine veritabanından atadık
            }
            return View(blogtekrar); 
        }
        public ActionResult BlogIslemleri(int blogId = 0)
        {
            var blog = BlogGetir(blogId);
            if (blogId == 0)
            {
                blog = new Blog();
            }
            return View(blog);
        }

        #region VeriTabanı İşlemleri
        [HttpPost]
        public JsonResult PostBlog(Blog blog2)
        {
            var islem = "";
            try
            {
                using (BlogContext x = new BlogContext())
                {
                    if (blog2.BlogId > 0)
                    {
                        var oldModel = x.Bloglar.FirstOrDefault(s => s.BlogId == blog2.BlogId);
                        oldModel = blog2;
                        x.SaveChanges();
                        islem = "Kayıt Gündcellendi...";
                    }
                    else
                    {
                        x.Bloglar.Add(blog2);
                        x.SaveChanges();
                        islem = "Kayıt Eklendi";
                    }
                    
                }
            }
            catch (Exception ex)
            {

                islem = "sunucu hatası";
            }
            return Json(islem);

        }

        [HttpPost]
        public JsonResult BlogSilme(int blogId)
        {
            var sonuc = "";
            try
            {
                using (BlogContext cx = new BlogContext())
                {
                    var blog = cx.Bloglar.Find(blogId);
                    cx.Bloglar.Remove(blog);
                    cx.SaveChanges();
                    sonuc = "basarılı";
                }
            }
            catch (Exception ex)
            {

                sonuc = "basarısız";
            }
            return Json(sonuc);
            
        }

        public Blog BlogGetir(int blogId) {
            var blog = new Blog();
            using (BlogContext cx = new BlogContext())
            {
                blog = cx.Bloglar.FirstOrDefault(s => s.BlogId == blogId);
            }

            return blog;
        }
        #endregion


    }
}
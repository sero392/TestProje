using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestProje.Models.DbModels
{
    [Table("Bloglar")]
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogBaslik { get; set; }
        public string BlogIcerik { get; set; }
        public DateTime YazimTarihi { get; set; }
        public int KullaniciId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestProje.Models.DbModels
{
    [Table("BlogKategorileri")]
    public class BlogKategori
    {
        [Key]
        public int BlogKategoriId { get; set; }
        public int BlogId { get; set; }
        public int KategoriId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestProje.Models.DbModels
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public string KategoriAciklama { get; set; }
    }
}
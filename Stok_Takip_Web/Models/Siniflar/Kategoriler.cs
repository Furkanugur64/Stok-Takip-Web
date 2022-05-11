using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stok_Takip_Web.Models.Siniflar
{
    public class Kategoriler
    {
        [Key]
        public int ID { get; set; }
        
        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "Kategori Adı bilgisi 20 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name ="Kategori Adı")]
        public string Ad { get; set; }

        
        public ICollection<Urun> uruns { get; set; }
    }
}
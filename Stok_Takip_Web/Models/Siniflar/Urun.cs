using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stok_Takip_Web.Models.Siniflar
{
    public class Urun
    {
        public int ID { get; set; }
        
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Ürün Adı bilgisi 20 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Ürün Adı")]

        
        public string Ad { get; set; }
       
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Marka bilgisi 30 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Ürün Markası")]
        public string Marka { get; set; }
       
        [Display(Name = "Ürün Kategorisi")]
        public int KategoriID { get; set; }
        public virtual Kategoriler Kategori { get; set; }
       
        
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Stok Adedi")]
        public int Stok { get; set; }


        [Display(Name = "Alış Fiyatı")]
        public decimal AlısFiyat { get; set; }

        
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Satış Fiyatı")]
        public decimal SatisFiyat { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100, ErrorMessage = "Fotoğraf bilgisi 100 karakterden uzun olamaz !")]
        
        [Display(Name = "Fotoğraf")]
        public string Fotograf { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(200, ErrorMessage = "Özellikler bilgisi 20 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Özellikler")]
        public string Ozellikler { get; set; }

       

    }
}
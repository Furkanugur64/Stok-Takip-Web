using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stok_Takip_Web.Models.Siniflar
{
    public class Musteriler
    {
        [Key]       
        public int ID { get; set; }
      
        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "Ad bilgisi 20 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Müşteri Adı")]
        public string Ad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "Soyad bilgisi 20 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Müşteri Soyadı")]
        public string Soyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15, ErrorMessage = "Telefon bilgisi 15 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        public string Telefon { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100, ErrorMessage = "Mail bilgisi 100 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Mail Adresi")]
        public string Mail { get; set; }
       
        [Display(Name = "Şehir")]
        public int SehirID { get; set; }
        public virtual Sehirler Sehir { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(150, ErrorMessage = "Adres bilgisi 150 karakterden uzun olamaz !")]
        [Display(Name = "Adres")]
        public string Adres { get; set; }

        
    }
}
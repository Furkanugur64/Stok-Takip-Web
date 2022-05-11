using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stok_Takip_Web.Models.Siniflar
{
    public class Statu
    {
        [Key]
        public int ID { get; set; }
       
        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "Statü bilgisi 20 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Departman Adı")]
        public String STATUAD { get; set; }

        public ICollection<Personeller> PERSONELLERs { get; set; }
    }
}
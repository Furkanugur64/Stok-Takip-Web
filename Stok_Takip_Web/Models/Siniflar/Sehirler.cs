using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stok_Takip_Web.Models.Siniflar
{
    public class Sehirler
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "Varchar")]    
        public string Sehir { get; set; }

        public ICollection<Musteriler> musterilers { get; set; }
    }
}
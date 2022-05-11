using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stok_Takip_Web.Models.Siniflar
{
    public class Context:DbContext
    {
       
        public DbSet<Kategoriler> Kategorilers { get; set; }
        
        
        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<Personeller> Personellers { get; set; }
        
        
       
        public DbSet<Sehirler> Sehirlers { get; set; }
        public DbSet<Statu> Status { get; set; }
        public DbSet<Urun> Uruns { get; set; }
    }
}
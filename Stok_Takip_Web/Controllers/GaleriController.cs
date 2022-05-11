using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stok_Takip_Web.Models.Siniflar;

namespace Stok_Takip_Web.Controllers
{   [Authorize]
    public class GaleriController : Controller
    {
        Context c = new Context();
        // GET: Galeri
        public ActionResult Index()
        {
            var urun = c.Uruns.ToList();
            return View(urun);
        }
    }
}
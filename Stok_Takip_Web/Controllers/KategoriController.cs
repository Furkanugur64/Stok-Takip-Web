using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stok_Takip_Web.Models.Siniflar;

namespace Stok_Takip_Web.Controllers
{
    [Authorize]
    public class KategoriController : Controller
    {
        Context c = new Context();
        // GET: Kategori
        public ActionResult Index()
        {
            var kategori = c.Kategorilers.ToList();
            return View(kategori);
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(Kategoriler k)
        {
            if (!ModelState.IsValid)
            {
                return View("KategoriEkle");
            }
            c.Kategorilers.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriSil(int id)
        {
            var kategori = c.Kategorilers.Find(id);
            c.Kategorilers.Remove(kategori);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var secilen = c.Kategorilers.Find(id);
            return View("KategoriGetir", secilen);
        }

        public ActionResult KategoriGuncelle(Kategoriler k)
        {
            var ktg = c.Kategorilers.Find(k.ID);
            ktg.Ad = k.Ad;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
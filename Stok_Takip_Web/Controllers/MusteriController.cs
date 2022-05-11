using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stok_Takip_Web.Models.Siniflar;

namespace Stok_Takip_Web.Controllers
{
    [Authorize]
    public class MusteriController : Controller
    {
        Context c = new Context();
        // GET: Musteri
        public ActionResult Index()
        {
            var musteri = c.Musterilers.ToList();
            return View(musteri);
        }
        [HttpGet]
        public ActionResult MusteriEkle()
        {
            List<SelectListItem> sehirlistesi = (from x in c.Sehirlers.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Sehir,
                                                     Value = x.ID.ToString()
                                                 }).ToList();
            ViewBag.dgr1 = sehirlistesi;
            return View();
        }
        [HttpPost]
        public ActionResult MusteriEkle(Musteriler m)
        {
                if (!ModelState.IsValid)
                {
                    return View("MusteriEkle");
                }
                c.Musterilers.Add(m);
                c.SaveChanges();
                return RedirectToAction("Index");          
        }

        public ActionResult MusteriSil(int id)
        {
            var mus = c.Musterilers.Find(id);
            c.Musterilers.Remove(mus);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MusteriGetir(int id)
        {
            List<SelectListItem> sehirlistesi = (from x in c.Sehirlers.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Sehir,
                                                     Value = x.ID.ToString()
                                                 }).ToList();
            ViewBag.dgr1 = sehirlistesi;
            var musteri = c.Musterilers.Find(id);
            return View("MusteriGetir",musteri);
        }

        public ActionResult MusteriGuncelle(Musteriler m)
        {
            var mus = c.Musterilers.Find(m.ID);
            mus.Ad = m.Ad;
            mus.Soyad = m.Soyad;
            mus.Telefon = m.Telefon;
            mus.Mail = m.Mail;
            mus.SehirID = m.SehirID;
            mus.Adres = m.Adres;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
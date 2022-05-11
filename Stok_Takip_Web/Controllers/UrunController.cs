using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stok_Takip_Web.Models.Siniflar;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace Stok_Takip_Web.Controllers
{
    [Authorize]
    public class UrunController : Controller
    {
        Context c = new Context();
        // GET: Urun
        public ActionResult Index(int sayfa=1)
        {
            var urun = c.Uruns.ToList().ToPagedList(sayfa, 5);
            return View(urun);
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            if (!ModelState.IsValid)
            {
                return View("UrunEkle");
            }
            List<SelectListItem> kategori = (from x in c.Kategorilers.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Ad,
                                                     Value = x.ID.ToString()
                                                 }).ToList();
            ViewBag.dgr1 = kategori;
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun u)
        {
            c.Uruns.Add(u);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunSil(int id)
        {
            var urn = c.Uruns.Find(id);
            c.Uruns.Remove(urn);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunGetir(int id)
        {
            List<SelectListItem> kategori = (from x in c.Kategorilers.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Ad,
                                                 Value = x.ID.ToString()
                                             }).ToList();
            ViewBag.dgr1 = kategori;
            var urun = c.Uruns.Find(id);
            return View("UrunGetir", urun);
        }

        public ActionResult UrunGuncelle(Urun u)
        {
            var urun = c.Uruns.Find(u.ID);
            urun.Ad = u.Ad;
            urun.KategoriID = u.KategoriID;
            urun.Marka = u.Marka;
            urun.AlısFiyat = u.AlısFiyat;
            urun.SatisFiyat = u.SatisFiyat;
            urun.Stok = u.Stok;
            urun.Ozellikler = u.Ozellikler;
            urun.Fotograf = u.Fotograf;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
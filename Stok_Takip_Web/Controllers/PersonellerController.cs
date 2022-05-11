using Stok_Takip_Web.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stok_Takip_Web.Controllers
{
    [Authorize]
    public class PersonellerController : Controller
    {
        Context c = new Context();
        // GET: Personeller
        public ActionResult Index()
        {
            var personel = c.Personellers.ToList();
            return View(personel);
        }
        [HttpGet]
        public ActionResult PersonelEkle()
        {
            if (!ModelState.IsValid)
            {
                return View("PersonelEkle");
            }
            List<SelectListItem> statulistesi = (from x in c.Status.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.STATUAD,
                                                     Value = x.ID.ToString()
                                                 }).ToList();
            ViewBag.dgr1 = statulistesi;
            return View();
        }
        [HttpPost]
        public ActionResult PersonelEkle(Personeller p)
        {
            c.Personellers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PersonelSil(int id)
        {
            var per = c.Personellers.Find(id);
            c.Personellers.Remove(per);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PersonelGetir(int id)
        {
            List<SelectListItem> statulistesi = (from x in c.Status.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.STATUAD,
                                                     Value = x.ID.ToString()
                                                 }).ToList();
            ViewBag.dgr1 = statulistesi;
            var per = c.Personellers.Find(id);
            return View("PersonelGetir", per);
        }

        public ActionResult PersonelGuncelle(Personeller p)
        {
            var per = c.Personellers.Find(p.ID);
            per.Ad = p.Ad;
            per.Soyad = p.Soyad;
            per.TC = p.TC;
            per.MAIL = p.MAIL;
            per.TELEFON = p.TELEFON;
            per.Sifre = p.Sifre;
            per.FOTOGRAF = p.FOTOGRAF;
            per.StatuID = p.StatuID;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stok_Takip_Web.Models.Siniflar;
using System.Web.Mvc;

namespace Stok_Takip_Web.Controllers
{
    [Authorize]
    public class DepartmanController : Controller
    {
        Context c = new Context();
        // GET: Departman
        public ActionResult Index()
        {
            var statuler = c.Status.ToList();
            return View(statuler);
        }
        [HttpGet]
        public ActionResult DepartmanEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DepartmanEkle(Statu dep)
        {
            if (!ModelState.IsValid)
            {
                return View("DepartmanEkle");
            }
            c.Status.Add(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanSil(int id)
        {
            var departman = c.Status.Find(id);
            c.Status.Remove(departman);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanGetir(int id)
        {
            var dep = c.Status.Find(id);
            return View("DepartmanGetir", dep);
        }

        public ActionResult DepartmanGuncelle(Statu d)
        {
            var dep = c.Status.Find(d.ID);
            dep.STATUAD = d.STATUAD;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
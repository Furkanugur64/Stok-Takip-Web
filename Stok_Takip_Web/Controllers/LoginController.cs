using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Stok_Takip_Web.Models.Siniflar;

namespace Stok_Takip_Web.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        // GET: Login
        [HttpGet]
        public ActionResult GirisYap()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(Personeller p)
        {
            var kullanıcı = c.Personellers.FirstOrDefault(x => x.TC == p.TC && x.Sifre == p.Sifre);
            if (kullanıcı!=null)
            {
                FormsAuthentication.SetAuthCookie(kullanıcı.Ad, false);
                Session["id"] = kullanıcı.ID;
                Session["ad"] = kullanıcı.Ad;
                Session["soyad"] = kullanıcı.Soyad;
                Session["resim"] = kullanıcı.FOTOGRAF;

                return RedirectToAction("Index", "Urun");

            }
            else
            {
                ViewBag.mesaj = "Kullanıcı Adı Veya Şifre Hatalı !!";
                return View();
            }
           
        }
        [Authorize]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("GirisYap", "Login");
        }
    }
}
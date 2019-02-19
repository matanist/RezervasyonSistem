using RezervasyonSistem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RezerevasyonSistem.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private RezervasyonSistemContext _context;
        public HomeController()
        {
            _context = new RezervasyonSistemContext();

            if (_context.Odalar.Count()<1)
            {
                var yeniOda = new Oda
                {
                    CocukIcinUygunMu = false,
                    Fiyat = 100,
                    KapiNo = "Z01",
                    KisiSayisi = 2
                };
                _context.Odalar.Add(yeniOda);
                _context.SaveChanges();
            }
        }
        // GET: Admin/Home
        public ActionResult Index()
        {
            

            return View();
        }
        public ActionResult Profil()
        {
            return View();
        }
        public ActionResult Musteriler()
        {
            return View();
        }
    }
}
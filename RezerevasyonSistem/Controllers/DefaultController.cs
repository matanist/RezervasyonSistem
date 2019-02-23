using RezervasyonSistem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RezerevasyonSistem.Controllers
{
    public class DefaultController : Controller
    {
        private RezervasyonSistemContext _context;
        public DefaultController()
        {
            //Dependency Injection
            _context = new RezervasyonSistemContext();
        }
        // GET: Default
        public ActionResult Index()
        {
            var odalar = _context.Odalar.ToList();
            ViewBag.Title = "Birşeyler";
            return View(odalar);
        }

        public ActionResult RezervasyonYap(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var seciliOda = _context.Odalar.FirstOrDefault(o => o.Id == id);
            if (seciliOda == null) return RedirectToAction("Index");
            return View(seciliOda);
        }
    }
}
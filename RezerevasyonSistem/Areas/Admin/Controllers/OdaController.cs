using RezervasyonSistem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RezerevasyonSistem.Areas.Admin.Controllers
{
    public class OdaController : Controller
    {
        // GET: Admin/Oda
        public RezervasyonSistemContext _context= new RezervasyonSistemContext();
        public OdaController()
        {
            //_context = new RezervasyonSistemContext();
        }
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Oda oda)
        {
            _context.Odalar.Add(oda);
            var result=_context.SaveChanges();
            var mesaj = result > 0 ? "Başarı ile kaydedildi" : "Kayıt yapılamadı";
            TempData["Mesaj"] = mesaj;
            return View();
        }
        public ActionResult OdaListe()
        {
            List<Oda> odalar=_context.Odalar.ToList();
            
              
                        
            return View(odalar);
        }
        [HttpPost]
        public JsonResult OdaDetay(int id)
        {
            var seciliOda = _context.Odalar.FirstOrDefault(o => o.Id == id);
            return Json(seciliOda);
        }
    }
}
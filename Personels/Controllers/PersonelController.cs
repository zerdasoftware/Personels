using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Personels.Models;
using System.Collections.Generic;
using System.Linq;

namespace Personels.Controllers
{
    public class PersonelController : Controller
    {
        Contexts c = new Contexts();
        public IActionResult Index()
        {
            var PersonelList = c.Personels.Include(x=> x.Birim).ToList();
            return View(PersonelList);
        }

        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> birimList = (from x in c.Birims.ToList()
                                             select new SelectListItem
                                             {
                                                 Text=x.BirimAdı,
                                                 Value=x.BirimId.ToString()
                                             }).ToList();  
            ViewBag.dgr = birimList;
            return View();
        }
        [HttpPost]
        public IActionResult YeniPersonel(Personel personel)
        {

            var birimVal = c.Birims.Where(x => x.BirimId == personel.Birim.BirimId).FirstOrDefault();
            personel.Birim= birimVal;
            c.Personels.Add(personel);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult PersonelSil(int id)
        {
            var PersonelVal = c.Personels.Find(id);
            c.Personels.Remove(PersonelVal);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Personel(int id)
        {
            List<SelectListItem> birimList = (from x in c.Birims.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.BirimAdı,
                                                  Value = x.BirimId.ToString()
                                              }).ToList();
            ViewBag.dgr = birimList;

            var personelVal = c.Personels.Find(id);
            return View("Personel", personelVal);
        }

        public IActionResult PersonelGuncelle(Personel personel)
        {
            var personelVal = c.Personels.Find(personel.PersonelID);
            personelVal.Ad = personel.Ad;
            var birimVal = c.Birims.Where(x => x.BirimId == personel.Birim.BirimId).FirstOrDefault();
            personel.Birim = birimVal;
            personelVal.Soyad = personel.Soyad;
            personelVal.Birim = personel.Birim;
            personelVal.Sehir = personel.Sehir;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

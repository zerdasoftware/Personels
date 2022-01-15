using Microsoft.AspNetCore.Mvc;
using Personels.Models;
using System.Linq;

namespace Personels.Controllers
{
    public class BirimController : Controller
    {
        Contexts c = new Contexts();
        public IActionResult Index()
        {
            var birimList = c.Birims.ToList();
            return View(birimList);
        }

        [HttpGet]
        public IActionResult YeniBirim()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniBirim(Birim birim)
        {
            c.Birims.Add(birim);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BirimiSil(int id)
        {
            var birimVal = c.Birims.Find(id);
            c.Birims.Remove(birimVal);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Birim(int id)
        {
            var birimVal = c.Birims.Find(id);
            return View("Birim", birimVal);
        }

        public IActionResult BirimiGuncelle(Birim  birim)
        {
            var birimVal = c.Birims.Find(birim.BirimId);
            birimVal.BirimAdı = birim.BirimAdı;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

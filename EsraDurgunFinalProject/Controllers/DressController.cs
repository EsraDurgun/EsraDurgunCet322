using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EsraDurgunFinalProject.Respositories;
using EsraDurgunFinalProject.Data.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EsraDurgunFinalProject.Controllers
{
    public class DressController : Controller
    {
        Context c = new Context();
        DressRepository dressRepository = new DressRepository();
        public IActionResult Index()
        {

            return View(dressRepository.TList("Category"));
        }
        [HttpGet]
        public IActionResult AddDress()
        {
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CatName,
                                               Value = x.CatId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddDress(Dress p)
        {
            dressRepository.TAdd(p);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteDress(int id)
        {
            dressRepository.TDelete(new Dress { DressId = id });
            return RedirectToAction("Index");
        }
        public IActionResult DressGet(int id)
        {
            var x = dressRepository.TGet(id);
            List<SelectListItem> values = (from y in c.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = y.CatName,
                                              Value = y.CatId.ToString()
                                          }).ToList();
            ViewBag.v1 = values;
            return View();
            Dress d = new Dress()
            {
                CategoryId = x.CategoryId,
                DressName = x.DressName,
                Price = x.Price,
                Stocak = x.Stocak,
                DressDes = x.DressDes,
                Image = x.Image
            };
            return View(d);
        }
        [HttpPost]
        public IActionResult DressUpdate(Dress p)
        {
            var x = dressRepository.TGet(p.DressId);
            x.DressName = p.DressName;
            x.Stocak = p.Stocak;
            x.Price = p.Price;
            x.Image = p.Image;
            x.DressDes = p.DressDes;
            x.CategoryId = x.CategoryId;
            dressRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
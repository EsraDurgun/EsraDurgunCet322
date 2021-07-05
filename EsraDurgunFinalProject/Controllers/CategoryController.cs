using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EsraDurgunFinalProject.Respositories;
using EsraDurgunFinalProject.Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EsraDurgunFinalProject.Controllers
{
    public class CategoryController : Controller
    {
        CatRepository catRepository = new CatRepository();
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {

            return View(catRepository.TList());
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            catRepository.TAdd(p);

            return RedirectToAction("Index");
        }
        public IActionResult CategoryGet(int id)
        {
            var x = catRepository.TGet(id);
            List<SelectListItem> values = (from y in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CatName,
                                               Value = y.CatId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
            Category d = new Category()
            {
                CatId=d.CatId,
                CatName=d.CatName,
                CatDes=d.CatDes,
            };
            return View(d);
        }
        public IActionResult CategoryUpdate(Category p)
        {
            var x = catRepository.TGet(p.CatId);
            x.CatName = p.CatName;   
            x.CatDes = p.CatDes;
            catRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
using EsraDurgunFinalProject.Respositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsraDurgunFinalProject.ViewComponents
{
    public class CategoryGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CatRepository catRepository = new CatRepository();
            var categorylist = catRepository.TList();
            return View(categorylist);
        }
    }
}
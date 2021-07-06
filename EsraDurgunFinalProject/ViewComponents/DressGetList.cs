using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsraDurgunFinalProject.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace EsraDurgunFinalProject.ViewComponents
{
    public class DressGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DressRepository dressRepository = new DressRepository();
            var dresslist = dressRepository.TList();
            return View(dresslist);
        }
    }
}
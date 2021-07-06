using EsraDurgunFinalProject.Respositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsraDurgunFinalProject.ViewComponents
{
    public class DressListByCategory : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            
            DressRepository dressRepository = new DressRepository();
            var dresslist = dressRepository.List(x => x.CategoryId == id);
            return View(dresslist);
        }
    }
}
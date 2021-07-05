using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EsraDurgunFinalProject.Controllers
{
    public class DefaultController: Controller
    {
        [AllowAnonymous]
        public IActionResult MainPage()
        {
            return View();
        }
    }
}
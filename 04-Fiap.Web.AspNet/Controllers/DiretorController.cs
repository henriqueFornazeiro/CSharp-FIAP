using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _04_Fiap.Web.AspNet.Controllers
{
    public class DiretorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
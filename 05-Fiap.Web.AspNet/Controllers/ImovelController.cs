using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class ImovelController : Controller
    {
        private CondominioContext _context;

        

        public ImovelController(CondominioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarSelectCondominio();
            return View();
        }

        private void CarregarSelectCondominio()
        {
            var lista = _context.Condominios.ToList();
            ViewBag.condominios = new SelectList(lista, "CondominioId", "Nome");
        }

        [HttpPost]
        public IActionResult Cadastrar (Imovel imovel) {
            _context.Imoveis.Add(imovel);
            _context.SaveChanges();
            TempData["msg"] = "Imóvel Cadastrado";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Listar(int idBusca)
        {
            CarregarSelectCondominio();
            return View(_context.Imoveis
                .Include(i => i.Condominio)
                .Where(i => i.CondominioId == idBusca || idBusca == 0).ToList());
        }

        


    }
}
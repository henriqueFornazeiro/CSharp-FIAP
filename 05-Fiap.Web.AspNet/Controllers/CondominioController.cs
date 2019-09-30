using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class CondominioController : Controller
    {

        private CondominioContext _context;

        public CondominioController(CondominioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Condominio condomino)
        {
            _context.Condominios.Add(condomino);
            _context.SaveChanges();
            TempData["mensagem"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Listar(String termoPesquisa)
        {
            //.Include -> inclui o relacionamento na pesquisa
            return View(_context.Condominios
                .Include(c => c.Sindico)
                .Where(c => c.Nome.Contains(termoPesquisa)).ToList());
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var cond = _context.Condominios.Include(c => c.Sindico)
                .Where(c => c.CondominioId == id);
            return View(cond);
        }

        [HttpPost]
        public IActionResult Editar(Condominio condominio)
        {
            _context.Condominios.Update(condominio);
            _context.SaveChanges();
            TempData["mensagem"] = "Editado com sucesso!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var cond = _context.Condominios.Find(id);
            _context.Condominios.Remove(cond);
            _context.SaveChanges();
            TempData["mensagem"] = "Excluido com sucesso!";
            return RedirectToAction("Listar");
        }

    }
}
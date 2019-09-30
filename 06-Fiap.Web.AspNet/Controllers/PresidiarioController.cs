using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Models;
using _06_Fiap.Web.AspNet.Persistence;
using _06_Fiap.Web.AspNet.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class PresidiarioController : Controller
    {
        private ICelaRepository _celaRepository;
        private IPresidiarioRepository _presidiarioRepository;

        public PresidiarioController(IPresidiarioRepository presidiarioRepository, ICelaRepository celaRepository)
        {
            _presidiarioRepository = presidiarioRepository;
            _celaRepository = celaRepository;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            var lista = _celaRepository.Listar();
            ViewBag.celas = new SelectList(lista, "CelaId", "Nome");
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Presidiario presidiario)
        {
            _presidiarioRepository.Cadastrar(presidiario);
            _presidiarioRepository.Salvar();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}
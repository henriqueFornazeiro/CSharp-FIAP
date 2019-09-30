using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02_Fiap.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_Fiap.AspNet.Controllers
{
    public class UserController : Controller
    {

        //Simular o banco de dados
        private static IList<Usuario> _banco = new List<Usuario>();

        [HttpGet]
        public IActionResult Index()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Index(Usuario usuario)
        {
            //Enviar Informações para a Tela
            ViewData["nome"] = usuario.Nome;
            ViewData["data"] = usuario.DataNascimento;
            ViewBag.endEletronico = usuario.Email;
            TempData["msg"] = "Usuário Cadastrado!";
            //Cadastrar no "banco" de dados
            _banco.Add(usuario);
            //Enviar o objeto para a tela
            return View(usuario);
        }

        public IActionResult Listar()
        {
            //Enviar lista de usuário para a tela
            return View(_banco);
        }

    }
}
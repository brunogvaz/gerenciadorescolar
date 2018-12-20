using System;
using Microsoft.AspNetCore.Mvc;
using GerenciadorEscolar.Models;
using GerenciadorEscolar.Services;

namespace GerenciadorEscolar.Controllers
{
    public class HomeController:Controller
    {
        private IAlunoData _alunoData;

        public HomeController(IAlunoData alunoData)
        {
            _alunoData = alunoData;
        }
        public IActionResult Index()
        {
            var model = _alunoData.GetAll();
            return View(model);

        }
    }
}

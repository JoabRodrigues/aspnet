using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            MeuModel mm = new MeuModel
            {
                nome = "Joab",
                sexo = 0
            };

            var array = new[]
            {
                new {value = 0, text = "Masculino"},
                new {value = 1, text = "Feminino"}
            };

            SelectList opcoes = new SelectList(array,"value","text",0);

            ViewData["opcoes"] = opcoes;

            return View(mm);


        }

        [HttpPost]
        public IActionResult Index(MeuModel meuModel)
        {

            return View();
        }

            public IActionResult Soma(int a, int b)
        {
            int c = a + b;
            Resposta resp = new Resposta
            {
                a = a,
                b = b,
                s = c
            };

            return View(resp);
        }

        
    }

    public class Resposta
    {
        public int a { get; set; }
        public int b { get; set; }
        public int s { get; set; }
    }

    public class MeuModel
    {
        public string nome { get; set; }
        public int sexo { get; set; }
    }
}
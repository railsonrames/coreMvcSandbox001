using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcSandbox001.Controllers
{
    public class AmigosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public String[] Listar(int id)
        {
            String listaConsolidada = "";
            String[] listaDeAmigos = { "Mateus", "Marquinhos do Pipe", "Tiago Jardel Herter", "Mario Bittar", "Bernardo" };
            int[] numeros = { 10, 22, 12, 6, 7};
            Console.WriteLine(numeros.Length);
            return listaDeAmigos;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica_2_lab.Models;

namespace Practica_2_lab.Controllers
{
    public class FormularioController : Controller 
    {

        public IActionResult Index(){

            return View("Views/Formulario/Index.cshtml");
        }
        
        [HttpPost]
        
        public IActionResult Guardar(string nombre , string apePat , string apeMat , string tipo , string telefono ,
        string distrito , string dire , string descripcion){

               Console.WriteLine(nombre);

               return RedirectToAction("Mostrar");

        }

        public IActionResult Mostrar() {
             
              return View("Views/Formulario/Confirmacion.cshtml");

        }



    }
}
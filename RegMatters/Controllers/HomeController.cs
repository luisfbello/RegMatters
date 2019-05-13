using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegMatters.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            //si inicia sesión admin retornar vistas de administración
            //si es un estudiante retornar vista de inscribir materias
            //si el calendario aún lo permite 
            return View();
        }

    }
}
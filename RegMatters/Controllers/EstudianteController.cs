using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegMatters.Controllers
{
    public class EstudianteController : Controller
    {
        public ActionResult RegisterSubject()
        {
            return View();
        }

        public ActionResult InscribedSubjects()
        {
            //muestra todas las materias inscritas de un estudiante
            return View();
        }

        public ActionResult StudentProfile()
        {
            //muestra los datos del estudiante
            return View();
        }

    }
}

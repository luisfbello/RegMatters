using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegMatters.Controllers
{
    public class MateriaController : Controller
    {
        public ActionResult Index()
        {
            //Listar todas las materias
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit()
        {
            //no tiene archivo de vista porque va tener un botón que abrirá un modal 
            //para editarlo desde la vista index
            return View();
        }

        public ActionResult Delete()
        {
            //no tiene archivo de vista porque va tener un botón que abrirá un modal 
            //para eliminarlo desde la vista index
            return View();
        }

    }
}

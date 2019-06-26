using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPC.Controllers
{
    public class DisciplinaController : Controller
    {
        // GET: Disciplina
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar() {
            return View();
        }

        public ActionResult Pesquisar() {
            return View();
        }
    }
}
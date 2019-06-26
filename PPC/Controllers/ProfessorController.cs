using Newtonsoft.Json;
using PPC.Domain.Service;
using PPC.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPC.Controllers
{
    public class ProfessorController : Controller
    {
        private ProfessorService _professorService;

        public ProfessorController()
        {
            _professorService = new ProfessorService();
        }

        // GET: Professor
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

        public ActionResult Gerenciar(int id) {

            ViewBag.ProfessorId = id;
            return View();
        }

        public JsonResult ObterDadosPesquisar() {

            try
            {
                var lst = _professorService.ObterTodos();

                return Json(new { Ok = true, Result = lst }, JsonRequestBehavior.AllowGet);

            }
            catch (System.Exception ex)
            {
                return Json(new
                {
                    Ok = false,
                    Msg = ex.Message
                }, JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult ObterGerenciar(int id) {

            try
            {
                var lst = _professorService.ObterTodos().FirstOrDefault(p => p.ProfessorId == id);

                lst.StrCursoDistancia = lst.CursoDistancia.GetValueOrDefault().ToShortDateString();
                lst.StrDataAdminissao = lst.DataAdminissao.GetValueOrDefault().ToShortDateString();
                lst.StrDataAtualizacao = lst.DataAtualizacao.GetValueOrDefault().ToShortDateString();
                lst.StrExperienciaProfissional = lst.ExperienciaProfissional.GetValueOrDefault().ToShortDateString();
                lst.StrTempoIniterrupto = lst.TempoIniterrupto.GetValueOrDefault().ToShortDateString();
                lst.StrTempoMagisterio = lst.TempoMagisterio.GetValueOrDefault().ToShortDateString();
              

                return Json(new { Ok = true, Result = lst }, JsonRequestBehavior.AllowGet);

            }
            catch (System.Exception ex)
            {
                return Json(new
                {
                    Ok = false,
                    Msg = ex.Message
                }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult Salvar(string obj) {

            try
            {
                var item = JsonConvert.DeserializeObject<ProfessorVM>(obj);

                _professorService.Salvar(item);

                return Json(new { Ok = true }, JsonRequestBehavior.AllowGet);

            }
            catch (System.Exception ex)
            {
                return Json(new
                {
                    Ok = false,
                    Msg = ex.Message
                }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
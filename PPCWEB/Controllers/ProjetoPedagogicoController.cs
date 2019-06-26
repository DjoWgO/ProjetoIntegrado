using PPC.Domain.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PPC.Controllers
{
    public class ProjetoPedagogicoController : Controller
    {
        // GET: ProjetoPedagogico
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {

            return View();
        }

        public ActionResult Pesquisar()
        {
            return View();
        }

        public JsonResult ObterDadosProjetoPedagogico()
        {

            try
            {
                var projetoPedagogico = new ProjetoPedagogicoVM();
                projetoPedagogico.Cursos = new List<object>();
                projetoPedagogico.Cursos.Add(new { CursoId = "1", Descricao = "Análise e Desenvolvimento de Sistema" });
                projetoPedagogico.Cursos.Add(new { CursoId = "2", Descricao = "Ciência da Computação" });
                projetoPedagogico.Cursos.Add(new { CursoId = "3", Descricao = "Sistemas de Informação" });

                return Json(new { Ok = true, Result = projetoPedagogico }, JsonRequestBehavior.AllowGet);

            }
            catch (System.Exception ex)
            {
                return Json(new { Ok = true, Msg = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult ObterDadosPesquisa()
        {

            try
            {
                var lst = new List<ProjetoPedagogicoVM>();
                lst.Add(new ProjetoPedagogicoVM { DescricaoCurso = "Analise e Desenvolvimento de Sistema", Curso = 1, ProjetoPedagogicoId = 6 });
                lst.Add(new ProjetoPedagogicoVM { DescricaoCurso = "Engenharia Civil", Curso = 2, ProjetoPedagogicoId = 7 });
                lst.Add(new ProjetoPedagogicoVM { DescricaoCurso = "Ciência da Computação", Curso = 3, ProjetoPedagogicoId = 8 });
                lst.Add(new ProjetoPedagogicoVM { DescricaoCurso = "Nutrição", Curso = 4, ProjetoPedagogicoId = 9 });
                lst.Add(new ProjetoPedagogicoVM { DescricaoCurso = "Sistemas da Informação", Curso = 5, ProjetoPedagogicoId = 1 });

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
    }
}
using Newtonsoft.Json;
using PPC.Domain.Service;
using PPC.Domain.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PPC.Controllers
{
    public class CursoController : Controller
    {
        private CursoService _cursoService;
        private TipoCursoService _tipoCursoService;
        private ModalidadeService _modalidadeService;
        private HabilitacaoService _habilitacaoService;
        private ProfessorService _professorService;
        private LocaisOfertaService _locaisOfertaservice;
        private TurnoService _turnoService;

        public CursoController()
        {
            _cursoService = new CursoService();
            _tipoCursoService = new TipoCursoService();
            _modalidadeService = new ModalidadeService();
            _habilitacaoService = new HabilitacaoService();
            _professorService = new ProfessorService();
            _locaisOfertaservice = new LocaisOfertaService();
            _turnoService = new TurnoService();
        }

        // GET: Curso
        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Pesquisar()
        {
            return View();
        }

        public JsonResult ObterDadosCurso()
        {

            try
            {
                var lstTipoCurso = _tipoCursoService.ObterTodos();
                
                var lstModalidade = _modalidadeService.ObterTodos();

                var lstHabilitacao = _habilitacaoService.ObterTodos();

                var lstProfessor =  _professorService.ObterTodos();

                var lstLocais = _locaisOfertaservice.ObterTodos();

                var lstTurno = _turnoService.ObterTodos();

                var curso = new CursoVM();

                curso.TiposCursos = lstTipoCurso;
                curso.TipoCurso = 1;

                curso.Modalidades = lstModalidade;
                curso.Modalidade = 1;

                curso.Habilitacoes = lstHabilitacao;
                curso.Habilitacao = 1;

                curso.LocaisOferta = lstLocais;

                curso.Professores = lstProfessor;

                curso.TurnosFuncionamento = lstTurno;
                
                return Json(new { Ok = true, Result = curso }, JsonRequestBehavior.AllowGet);

            }
            catch (System.Exception ex)
            {

                return Json(new { Ok = false, Msg = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult ObterDadosPesquisar()
        {
            try
            {

                //TODO: IMPLEMENTAR O RETORNO DO TIPO DE CURSO.

                #region MOCK

                var curso = new List<CursoVM>();
                curso.Add(new CursoVM { CursoId = 1, Denominacao = "Analise e desenvolvimento de sistemas", TipoCursoDescricao = "Bacharelado" });
                curso.Add(new CursoVM { CursoId = 2, Denominacao = "Ciencia da computacao", TipoCursoDescricao = "Bacharelado" });
                curso.Add(new CursoVM { CursoId = 3, Denominacao = "Sistemas da informacao", TipoCursoDescricao = "Bacharelado" });
                curso.Add(new CursoVM { CursoId = 4, Denominacao = "Engenharia de Software", TipoCursoDescricao = "Bacharelado" });

                #endregion

                return Json(new { Ok = true, Result = curso }, JsonRequestBehavior.AllowGet);

            }
            catch (System.Exception ex)
            {

                return Json(new { Ok = false, Msg = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult Salvar(string obj)
        {
            try
            {
                dynamic objCurso = JsonConvert.DeserializeObject(obj);

                var curso = new CursoVM();
                curso.TipoCurso = objCurso["TipoCurso"];
                curso.Denominacao = objCurso["Denominacao"];
                curso.Habilitacao = objCurso["Habilitacao"];
                curso.RegimeLetivo = objCurso["RegimeLetivo"];
                curso.Periodos = objCurso["Periodos"];
                curso.Professor = objCurso["CoordenadorId"];

                curso.Modalidades = new List<ModalidadeVM>();
                curso.LocaisOferta = new List<LocalOfertaVM>();
                curso.TurnosFuncionamento = new List<TurnoFuncionamentoVM>();

                var arrModalidades = objCurso["Modalidades"];

                foreach (var mod in arrModalidades)
                {
                    curso.Modalidades.Add(new ModalidadeVM { ModalidadeId = mod["ModalidadeId"] });
                }
                
                var arrLocaisOferta = objCurso["LocaisOferta"];

                foreach (var localOferta in arrLocaisOferta)
                {
                    curso.LocaisOferta.Add(new LocalOfertaVM { LocalOfertaId = localOferta["LocalOfertaId"] });
                }

                var arrTurnosFuncionamento = objCurso["TurnosFuncionamento"];

                foreach (var turnoFuncionamento in arrTurnosFuncionamento)
                {
                    curso.TurnosFuncionamento.Add(new TurnoFuncionamentoVM { TurnoFuncionamentoId = turnoFuncionamento["TurnoFuncionamentoId"], Vagas = turnoFuncionamento["Vagas"] });
                }

                _cursoService.Salvar(curso);


                return Json(new { Ok = true, Result = string.Empty }, JsonRequestBehavior.AllowGet);

            }
            catch (System.Exception ex)
            {

                return Json(new { Ok = false, Msg = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
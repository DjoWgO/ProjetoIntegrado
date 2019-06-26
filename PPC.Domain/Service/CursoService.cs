using PPC.Data;
using PPC.Domain.ViewModel;
using PPC.Entities.Entities;
using System.Collections.Generic;
using System.Linq;



namespace PPC.Domain.Service
{
    public class CursoService
    {
        private CursoRepository _cursoRepository;
        private TipoCursoRepository _tipoCursoRepository;
        private ModalidadeRepository _modalidadeRepository;
        private InstituicaoRepository _instituicaoRepository;
        private TurnoRepository _turnoRepository;

        public CursoService()
        {
            _cursoRepository = new CursoRepository();
            _tipoCursoRepository = new TipoCursoRepository();
            _modalidadeRepository = new ModalidadeRepository();
            _instituicaoRepository = new InstituicaoRepository();
            _turnoRepository = new TurnoRepository();
        }

        public void Salvar(CursoVM cursoVM) {

            try
            {

        
            var cursoMap = CursoVM.Map(cursoVM);
            var tipoCurso = _tipoCursoRepository.Buscar(p => p.TipoCursoId == cursoVM.TipoCurso).FirstOrDefault();

            var modalidadeTodos = _modalidadeRepository.ObterTodos();

            var modalidades = modalidadeTodos.Where(p => cursoVM.Modalidades.Select(o => o.ModalidadeId).Contains(p.ModalidadeId)).ToList();

            var instituicaoTodos = _instituicaoRepository.ObterTodos();
            
            var instituicao = instituicaoTodos.Where(p => cursoVM.LocaisOferta.Select(o => o.LocalOfertaId).Contains(p.InstituicaoId)).ToList();

            var turnoTodos = _turnoRepository.ObterTodos();

            var turno = turnoTodos.Where(p => cursoVM.TurnosFuncionamento.Select(o => o.TurnoFuncionamentoId).Contains(p.TurnoId)).ToList();

                cursoMap.Modalidade = new List<Modalidade>();
                cursoMap.Instituicao = new List<Instituicao>();
                cursoMap.Turno = new List<Turno>();
                cursoMap.Modalidade.AddRange(modalidades);
                cursoMap.Instituicao.AddRange(instituicao);
                cursoMap.Turno.AddRange(turno);

                _cursoRepository.Criar(cursoMap);


                //modalidades.ForEach(e =>
                //{
                //    e.Cursos = new List<Curso>();
                //    e.Cursos.Add(cursoMap);

                //    _modalidadeRepository.Criar(e);
                //});

                //instituicao.ForEach(e =>
                //{
                //    e.Cursos = new List<Curso>();
                //    e.Cursos.Add(cursoMap);

                //    _instituicaoRepository.Criar(e);
                //});


                //turno.ForEach(e =>
                //{
                //    e.Cursos = new List<Curso>();
                //    e.Cursos.Add(cursoMap);
                //    _turnoRepository.Criar(e);
                //});

                _cursoRepository.SaveChanges();
                
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }
    }
}

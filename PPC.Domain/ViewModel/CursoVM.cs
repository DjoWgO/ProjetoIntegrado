using PPC.Entities.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PPC.Domain.ViewModel
{
    public class CursoVM
    {
        public int CursoId { get; set; }

        public List<TipoCursoVM> TiposCursos { get; set; }
        public int TipoCurso { get; set; }
        public string TipoCursoDescricao { get; set; }

        public List<ModalidadeVM> Modalidades { get; set; }
        public int Modalidade { get; set; }

        public string Denominacao { get; set; }

        public List<HabilitacaoVM> Habilitacoes { get; set; }
        public int Habilitacao { get; set; }

        public List<LocalOfertaVM> LocaisOferta { get; set; }

        public List<TurnoFuncionamentoVM> TurnosFuncionamento { get; set; }

        public string RegimeLetivo { get; set; }
        public string Periodos { get; set; }

        public CoordenadorVM Coordenador { get; set; }

        public string TempoDedicacao { get; set; }

        public string Titulacao { get; set; }

        public IEnumerable<ProfessorVM> Professores { get; set; }
        public int Professor { get; set; }

        public static Curso Map(CursoVM vm) {

            var curso = new Curso();
            curso.CursoId = vm.CursoId;
            //curso.TipoCurso = new List<TipoCurso>();
            //curso.TipoCurso = TipoCursoVM.Map(vm.TiposCursos);
            

            //curso.Modalidade = new List<Modalidade>();
            //curso.Modalidade = ModalidadeVM.Map(vm.Modalidades);
            curso.Denominacao = vm.Denominacao;
            curso.HabilitacaoId = vm.Habilitacao;
            //curso.Instituicao = new List<Instituicao>();
            //curso.Instituicao = LocalOfertaVM.Map(vm.LocaisOferta);
            //curso.Turno = new List<Turno>();
            //curso.Turno = TurnoFuncionamentoVM.Map(vm.TurnosFuncionamento);
            curso.RegimeLetivo = vm.RegimeLetivo;
            curso.Periodos = vm.Periodos;
            curso.ProfessorId = vm.Professor;

            return curso;
    }

    }
}

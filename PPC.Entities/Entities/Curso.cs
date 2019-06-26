using PPC.Entities.Entities;
using System.Collections.Generic;

namespace PPC.Entities.Entities
{
    public class Curso
    {
        public int CursoId { get; set; }
        public virtual List<TipoCurso> TipoCurso { get; set; }
        public virtual List<Modalidade> Modalidade { get; set; }
        public string Denominacao { get; set; }
        public virtual Habilitacao Habilitacao { get; set; }
        public int HabilitacaoId { get; set; }
        public int Vagas { get; set; }
        public int CargaHoraria { get; set; }
        public virtual List<Instituicao> Instituicao { get; set; }
        public virtual List<Turno> Turno { get; set; }

        public string RegimeLetivo { get; set; }
        public string Periodos { get; set; }

        public virtual Professor Professor { get; set; }
        public int ProfessorId { get; set; }
    }
}

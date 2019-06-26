using System.Collections.Generic;

namespace PPC.Entities.Entities
{
    public class TipoCurso
    { 
        public int TipoCursoId { get; set; }
        public string Descricao { get; set; }
        public virtual List<Curso> Cursos { get; set; }


    }
}
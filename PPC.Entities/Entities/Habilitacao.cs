using System.Collections.Generic;

namespace PPC.Entities.Entities
{
    public class Habilitacao
    {
        public int HabilitacaoId { get; set; }
        public string Descricao { get; set; }

        public virtual List<Curso> Cursos { get; set; }
    }
}

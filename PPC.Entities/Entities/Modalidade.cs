using System.Collections.Generic;

namespace PPC.Entities.Entities
{
    public class Modalidade
    {
        public int ModalidadeId { get; set; }
        public string Descricao { get; set; }

        public virtual List<Curso> Cursos { get; set; }
    }
}
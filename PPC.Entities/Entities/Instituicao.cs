using System.Collections.Generic;

namespace PPC.Entities.Entities
{
    public class Instituicao
    {
        public int InstituicaoId { get; set; }
        public string Descricao { get; set; }

        public virtual List<Curso> Cursos { get; set; }

        

    }
}
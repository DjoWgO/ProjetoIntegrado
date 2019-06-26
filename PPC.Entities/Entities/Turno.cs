using System.Collections.Generic;

namespace PPC.Entities.Entities
{
    public class Turno { 
        public int TurnoId { get; set; }
        public string Descricao { get; set; }

        public List<Vagas> Vagas { get; set; }

        public List<Curso> Cursos { get; set; }

    }
}
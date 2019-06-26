using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC.Entities.Entities
{
    public class Vagas
    {
        public int VagaId { get; set; }

        public Turno Turno { get; set; }

        public int TurnoId { get; set; }

        public int NumeroVagas { get; set; }
    }
}

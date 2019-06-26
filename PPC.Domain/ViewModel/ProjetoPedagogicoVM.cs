using System.Collections;
using System.Collections.Generic;

namespace PPC.Domain.ViewModel
{
    public class ProjetoPedagogicoVM
    {
        public IList<object> Cursos { get; set; }

        public int Curso { get; set; }

        public string DescricaoCurso { get; set; }

        public int ProjetoPedagogicoId { get; set; }
    }
}

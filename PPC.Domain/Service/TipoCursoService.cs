using PPC.Data;
using PPC.Domain.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace PPC.Domain.Service
{
      public class TipoCursoService
    {
        private TipoCursoRepository _tipoCursoRepository;

        public TipoCursoService()
        {
            _tipoCursoRepository = new TipoCursoRepository();
        }

        public List<TipoCursoVM> ObterTodos() {

            var lst = _tipoCursoRepository.ObterTodos().ToList();

            var lstMap = TipoCursoVM.Map(lst);

            return lstMap;
        }
    }
}

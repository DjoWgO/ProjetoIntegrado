using PPC.Data;
using PPC.Domain.ViewModel;
using PPC.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC.Domain.Service
{
    public class LocaisOfertaService
    {
        private InstituicaoRepository _instituicaoRepository;

        public LocaisOfertaService()
        {
            _instituicaoRepository = new InstituicaoRepository();
        }

        public List<LocalOfertaVM> ObterTodos() {

            var lst = _instituicaoRepository.ObterTodos().ToList();

            var lstMap = LocalOfertaVM.Map(lst);

            return lstMap;

        }
    }
}

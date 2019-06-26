using PPC.Data;
using PPC.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC.Domain.Service
{
    public class HabilitacaoService
    {
        private HabilitacaoRepository _habilitacaoRepository;

        public HabilitacaoService()
        {
            _habilitacaoRepository = new HabilitacaoRepository();
        }

        public List<HabilitacaoVM> ObterTodos() {

            var lst = _habilitacaoRepository.ObterTodos().ToList();

            var lstMap = HabilitacaoVM.Map(lst);

            return lstMap;
        }
    }
}

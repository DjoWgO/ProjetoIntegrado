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
    public class TurnoService
    {
        private TurnoRepository _turnoRepository;

        public TurnoService()
        {
            _turnoRepository = new TurnoRepository();
        }

        public List<TurnoFuncionamentoVM> ObterTodos() {

            var lst = _turnoRepository.ObterTodos().ToList();

            var lstMap = TurnoFuncionamentoVM.Map(lst);

            return lstMap;
        }

    }
}

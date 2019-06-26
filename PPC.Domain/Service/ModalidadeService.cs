using PPC.Data;
using PPC.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PPC.Domain.Service
{
    public class ModalidadeService
    {
        private ModalidadeRepository _modalidadeRepository;

        public ModalidadeService()
        {
            _modalidadeRepository = new ModalidadeRepository();
        }

        public List<ModalidadeVM> ObterTodos()
        {

            try
            {
                var lst = _modalidadeRepository.ObterTodos().ToList();

                var lstMap = ModalidadeVM.Map(lst);

                return lstMap;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}

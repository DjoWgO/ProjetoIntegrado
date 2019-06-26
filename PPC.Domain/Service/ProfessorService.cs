using PPC.Data;
using PPC.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC.Domain.Service
{
    public class ProfessorService
    {
        private ProfessorRepository _professorRepository;

        public ProfessorService()
        {
            _professorRepository = new ProfessorRepository();
        }

        public List<ProfessorVM> ObterTodos()
        {
            var lst = _professorRepository.ObterTodos().ToList();

            var lstMap = ProfessorVM.Map(lst);


            return lstMap;
        }

        public void Salvar(ProfessorVM vm) {

            var professor = ProfessorVM.Map(vm);

            if (vm.ProfessorId > 0)
            {
                var pf = _professorRepository.Obter(p => p.ProfessorId == vm.ProfessorId);

                if (pf != null)
                {
                    professor.Nome = pf.Nome;
                    professor.CPF = pf.CPF;
                    professor.Titulacao = pf.Titulacao;
                    professor.AreaFormacao = pf.AreaFormacao;
                    professor.DataAtualizacao = pf.DataAtualizacao;
                    professor.CurriculoLetters = pf.CurriculoLetters;

                    _professorRepository.Editar(professor, p => p.ProfessorId == vm.ProfessorId);
                }

               
            }
            else
            {
                _professorRepository.Criar(professor);
            }


        }
    }
}

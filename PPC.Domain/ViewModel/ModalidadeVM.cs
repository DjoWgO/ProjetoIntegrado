using PPC.Entities.Entities;
using System.Collections.Generic;

namespace PPC.Domain.ViewModel
{
    public class ModalidadeVM
    {
        public int ModalidadeId { get; set; }
        public string Descricao { get; set; }

        public static Modalidade Map(ModalidadeVM vm) {

            var modalidade = new Modalidade();
            modalidade.ModalidadeId = vm.ModalidadeId;
            modalidade.Descricao = vm.Descricao;

            return modalidade;

        }

        public static List<Modalidade> Map(List<ModalidadeVM> vm)
        {

            var modalidade = new List<Modalidade>();

            foreach (var item in vm)
            {
                modalidade.Add(Map(item));
            }

            return modalidade;

        }

        public static ModalidadeVM Map(Modalidade obj)
        {

            var modalidade = new ModalidadeVM();
            modalidade.ModalidadeId = obj.ModalidadeId;
            modalidade.Descricao = obj.Descricao;

            return modalidade;

        }

        public static List<ModalidadeVM> Map(List<Modalidade> obj)
        {

            var modalidade = new List<ModalidadeVM>();

            foreach (var item in obj)
            {
                modalidade.Add(Map(item));
            }

            return modalidade;

        }
    }
}

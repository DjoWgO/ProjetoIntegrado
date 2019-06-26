using PPC.Entities.Entities;
using System.Collections.Generic;

namespace PPC.Domain.ViewModel
{
    public class HabilitacaoVM
    {
        public int HabilitacaoId { get; set; }
        public string Descricao { get; set; }

        public static Habilitacao Map(HabilitacaoVM vm) {

            var habilitacao = new Habilitacao();
            habilitacao.HabilitacaoId = vm.HabilitacaoId;
            habilitacao.Descricao = vm.Descricao;

            return habilitacao;

        }

        public static List<Habilitacao> Map(List<HabilitacaoVM> vm)
        {

            var habilitacao = new List<Habilitacao>();

            foreach (var item in vm)
            {
                habilitacao.Add(Map(item));
            }

            return habilitacao;

        }

        public static HabilitacaoVM Map(Habilitacao obj)
        {

            var habilitacao = new HabilitacaoVM();
            habilitacao.HabilitacaoId = obj.HabilitacaoId;
            habilitacao.Descricao = obj.Descricao;

            return habilitacao;

        }

        public static List<HabilitacaoVM> Map(List<Habilitacao> obj)
        {

            var habilitacao = new List<HabilitacaoVM>();

            foreach (var item in obj)
            {
                habilitacao.Add(Map(item));
            }

            return habilitacao;

        }

    }
}

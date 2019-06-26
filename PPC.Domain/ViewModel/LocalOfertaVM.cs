using PPC.Entities.Entities;
using System.Collections.Generic;

namespace PPC.Domain.ViewModel
{
    public class LocalOfertaVM
    {
        public int LocalOfertaId { get; set; }
        public string Descricao { get; set; }

        public static Instituicao Map(LocalOfertaVM vm) {

            var instituicao = new Instituicao();
            instituicao.InstituicaoId = vm.LocalOfertaId;
            instituicao.Descricao = vm.Descricao;

            return instituicao;
        }

        public static List<Instituicao> Map(List<LocalOfertaVM> vm)
        {

            var instituicao = new List<Instituicao>();

            foreach (var item in vm)
            {
                instituicao.Add(Map(item));
            }

            return instituicao;
        }

        public static LocalOfertaVM Map(Instituicao obj)
        {

            var instituicao = new LocalOfertaVM();
            instituicao.LocalOfertaId = obj.InstituicaoId;
            instituicao.Descricao = obj.Descricao;

            return instituicao;
        }

        public static List<LocalOfertaVM> Map(List<Instituicao> vm)
        {

            var instituicao = new List<LocalOfertaVM>();

            foreach (var item in vm)
            {
                instituicao.Add(Map(item));
            }

            return instituicao;
        }
    }
}

using PPC.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PPC.Domain.ViewModel
{
    public class TipoCursoVM
    {
        public int TipoCursoId { get; set; }
        public string Descricao { get; set; }

        public static TipoCurso Map(TipoCursoVM vm) {

            var tipoCurso = new TipoCurso();
            tipoCurso.TipoCursoId = vm.TipoCursoId;
            tipoCurso.Descricao = vm.Descricao;

            return tipoCurso;

        }

        public static List<TipoCurso> Map(List<TipoCursoVM> vm)
        {

            var lst = new List<TipoCurso>();

            foreach (var item in vm)
            {
                lst.Add(Map(item));
            }

            return lst;

        }

        public static TipoCursoVM Map(TipoCurso obj)
        {

            var tipoCurso = new TipoCursoVM();
            tipoCurso.TipoCursoId = obj.TipoCursoId;
            tipoCurso.Descricao = obj.Descricao;

            return tipoCurso;

        }

        public static List<TipoCursoVM> Map(List<TipoCurso> obj)
        {

            var lst = new List<TipoCursoVM>();

            foreach (var item in obj)
            {
                lst.Add(Map(item));
            }

            return lst;

        }
    }
}

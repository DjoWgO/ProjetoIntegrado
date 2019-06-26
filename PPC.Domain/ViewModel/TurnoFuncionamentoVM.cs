using PPC.Entities.Entities;
using System.Collections.Generic;

namespace PPC.Domain.ViewModel
{
    public class TurnoFuncionamentoVM
    {
        public int TurnoFuncionamentoId { get; set; }

        public string Descricao { get; set; }

        public int Vagas { get; set; }
        
        public static Turno Map(TurnoFuncionamentoVM vm) {

            var turno = new Turno();
            turno.TurnoId = vm.TurnoFuncionamentoId;
            turno.Descricao = vm.Descricao;
            turno.Vagas = new List<Vagas>();
            turno.Vagas.Add(new Vagas { NumeroVagas = vm.Vagas });

            return turno;
        }

        public static List<Turno> Map(List<TurnoFuncionamentoVM> vm)
        {

            var turno = new List<Turno>();

            foreach (var item in vm)
            {
                turno.Add(Map(item));
            }

            return turno;
        }

        public static TurnoFuncionamentoVM Map(Turno obj)
        {

            var turno = new TurnoFuncionamentoVM();
            turno.TurnoFuncionamentoId = obj.TurnoId;
            turno.Descricao = obj.Descricao;
            //turno.Vagas = obj.Vagas;

            return turno;
        }

        public static List<TurnoFuncionamentoVM> Map(List<Turno> obj)
        {

            var turno = new List<TurnoFuncionamentoVM>();

            foreach (var item in obj)
            {
                turno.Add(Map(item));
            }

            return turno;
        }
    }
}

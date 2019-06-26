namespace PPC.Data.Migrations
{
    using PPC.Entities.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PPC.Data.PPCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PPC.Data.PPCContext context)
        {
            //var lstHabilitacao = new List<Habilitacao>();
            //lstHabilitacao.Add(new Habilitacao { Descricao = "Bacharelado" });
            //lstHabilitacao.Add(new Habilitacao { Descricao = "Tecnólogo" });
            
            //var lstTipoCurso = new List<TipoCurso>();
            //lstTipoCurso.Add(new TipoCurso { Descricao = "Graduação"});
            //lstTipoCurso.Add(new TipoCurso { Descricao = "Tecnólogo" });
            //lstTipoCurso.Add(new TipoCurso { Descricao = "Pós-Graduação" });
            
            //var lstModalidade = new List<Modalidade>();
            //lstModalidade.Add(new Modalidade { Descricao = "Presencial"});
            //lstModalidade.Add(new Modalidade { Descricao = "EAD" });

            //var lstInstituicao = new List<Instituicao>();
            //lstInstituicao.Add(new Instituicao { Descricao = "Campus Norte"});
            //lstInstituicao.Add(new Instituicao { Descricao = "Campus Sul" });
            //lstInstituicao.Add(new Instituicao { Descricao = "Campus Matriz" });

            //var lstProfessor = new List<Professor>();
            //lstProfessor.Add(new Professor { Nome = "Luiz Alberto", CPF = "15926548715", Titulacao = "Mestre"});
            //lstProfessor.Add(new Professor { Nome = "Fabio Henrique", CPF = "26539835458", Titulacao = "PHD" });
            //lstProfessor.Add(new Professor { Nome = "Lucas Santos", CPF =   "85479632587", Titulacao = "Doutor" });
            //lstProfessor.Add(new Professor { Nome = "José de Sá", CPF =   "25136525995", Titulacao = "Mestre" });

            //var lstTurnos = new List<Turno>();
            //lstTurnos.Add(new Turno { Descricao = "Matutino" });
            //lstTurnos.Add(new Turno { Descricao = "Vespertino" });
            //lstTurnos.Add(new Turno { Descricao = "Noturno" });
            //lstTurnos.Add(new Turno { Descricao = "Integral" });

            //lstHabilitacao.ForEach(e => {
            //    context.Habilitacao.AddOrUpdate(e);
            //});

            //lstTipoCurso.ForEach(e => {
            //    context.TipoCurso.AddOrUpdate(e);
            //});

            //lstModalidade.ForEach(e => {
            //    context.Modalidade.AddOrUpdate(e);
            //});

            //lstInstituicao.ForEach(e => {
            //    context.Instituicao.AddOrUpdate(e);
            //});

            //lstProfessor.ForEach(e => {
            //    context.Professor.AddOrUpdate(e);
            //});

            //lstTurnos.ForEach(e => {
            //    context.Turno.AddOrUpdate(e);
            //});

            //base.Seed(context); //PARA ADICIONAR OS DADOS DEVE-SE DESCOMENTAR ESSA LINHA
        }
    }
}

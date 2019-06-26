namespace PPC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AJUSTE_PROPRIEDADES_PROFESSOR : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Professor", "AreaFormacao", c => c.String());
            AddColumn("dbo.Professor", "CurriculoLetters", c => c.String());
            AddColumn("dbo.Professor", "DataAtualizacao", c => c.DateTime());
            AddColumn("dbo.Professor", "Matricula", c => c.String());
            AddColumn("dbo.Professor", "DataAdminissao", c => c.DateTime());
            AddColumn("dbo.Professor", "HorasNDE", c => c.Int());
            AddColumn("dbo.Professor", "ExtraClasseCurso", c => c.Int());
            AddColumn("dbo.Professor", "OrientacaoTCC", c => c.Int());
            AddColumn("dbo.Professor", "ExtraClasseOutrosCursos", c => c.Int());
            AddColumn("dbo.Professor", "CoordenacaoCurso", c => c.Int());
            AddColumn("dbo.Professor", "QtdeHorasCurso", c => c.Int());
            AddColumn("dbo.Professor", "CoordenacaoOutrosCursos", c => c.Int());
            AddColumn("dbo.Professor", "QtdeHorasOutrosCursos", c => c.Int());
            AddColumn("dbo.Professor", "PesquisaSemestreAtual", c => c.Int());
            AddColumn("dbo.Professor", "MembroNDE", c => c.Int());
            AddColumn("dbo.Professor", "MembroColegiado", c => c.Int());
            AddColumn("dbo.Professor", "DocenteExperiencia", c => c.Int());
            AddColumn("dbo.Professor", "TempoIniterrupto", c => c.DateTime());
            AddColumn("dbo.Professor", "TempoIniterruptoTotal", c => c.String());
            AddColumn("dbo.Professor", "TempoMagisterio", c => c.DateTime());
            AddColumn("dbo.Professor", "TempoMagisterioTotal", c => c.String());
            AddColumn("dbo.Professor", "CursoDistancia", c => c.DateTime());
            AddColumn("dbo.Professor", "CursoDistanciaTotal", c => c.String());
            AddColumn("dbo.Professor", "ExperienciaProfissional", c => c.DateTime());
            AddColumn("dbo.Professor", "ExperienciaProfissionalTotal", c => c.String());
            AddColumn("dbo.Professor", "NaArea", c => c.Int());
            AddColumn("dbo.Professor", "OutrasAreas", c => c.Int());
            AddColumn("dbo.Professor", "LivrosPublicados", c => c.Int());
            AddColumn("dbo.Professor", "OutrosLivrosPublicados", c => c.Int());
            AddColumn("dbo.Professor", "PublicadosAnaisCompleto", c => c.Int());
            AddColumn("dbo.Professor", "PublicadosAnaisResumo", c => c.Int());
            AddColumn("dbo.Professor", "PropriedadeIntelectualDepositado", c => c.Int());
            AddColumn("dbo.Professor", "PropriedadeIntelectualRegistrada", c => c.Int());
            AddColumn("dbo.Professor", "TraducaoLivros", c => c.Int());
            AddColumn("dbo.Professor", "ProducoesTecnicas", c => c.Int());
            AddColumn("dbo.Professor", "ProducaoDidaticoPedagogico", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Professor", "ProducaoDidaticoPedagogico");
            DropColumn("dbo.Professor", "ProducoesTecnicas");
            DropColumn("dbo.Professor", "TraducaoLivros");
            DropColumn("dbo.Professor", "PropriedadeIntelectualRegistrada");
            DropColumn("dbo.Professor", "PropriedadeIntelectualDepositado");
            DropColumn("dbo.Professor", "PublicadosAnaisResumo");
            DropColumn("dbo.Professor", "PublicadosAnaisCompleto");
            DropColumn("dbo.Professor", "OutrosLivrosPublicados");
            DropColumn("dbo.Professor", "LivrosPublicados");
            DropColumn("dbo.Professor", "OutrasAreas");
            DropColumn("dbo.Professor", "NaArea");
            DropColumn("dbo.Professor", "ExperienciaProfissionalTotal");
            DropColumn("dbo.Professor", "ExperienciaProfissional");
            DropColumn("dbo.Professor", "CursoDistanciaTotal");
            DropColumn("dbo.Professor", "CursoDistancia");
            DropColumn("dbo.Professor", "TempoMagisterioTotal");
            DropColumn("dbo.Professor", "TempoMagisterio");
            DropColumn("dbo.Professor", "TempoIniterruptoTotal");
            DropColumn("dbo.Professor", "TempoIniterrupto");
            DropColumn("dbo.Professor", "DocenteExperiencia");
            DropColumn("dbo.Professor", "MembroColegiado");
            DropColumn("dbo.Professor", "MembroNDE");
            DropColumn("dbo.Professor", "PesquisaSemestreAtual");
            DropColumn("dbo.Professor", "QtdeHorasOutrosCursos");
            DropColumn("dbo.Professor", "CoordenacaoOutrosCursos");
            DropColumn("dbo.Professor", "QtdeHorasCurso");
            DropColumn("dbo.Professor", "CoordenacaoCurso");
            DropColumn("dbo.Professor", "ExtraClasseOutrosCursos");
            DropColumn("dbo.Professor", "OrientacaoTCC");
            DropColumn("dbo.Professor", "ExtraClasseCurso");
            DropColumn("dbo.Professor", "HorasNDE");
            DropColumn("dbo.Professor", "DataAdminissao");
            DropColumn("dbo.Professor", "Matricula");
            DropColumn("dbo.Professor", "DataAtualizacao");
            DropColumn("dbo.Professor", "CurriculoLetters");
            DropColumn("dbo.Professor", "AreaFormacao");
        }
    }
}

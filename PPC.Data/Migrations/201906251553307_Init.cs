namespace PPC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Denominacao = c.String(),
                        HabilitacaoId = c.Int(nullable: false),
                        Vagas = c.Int(nullable: false),
                        CargaHoraria = c.Int(nullable: false),
                        RegimeLetivo = c.String(),
                        Periodos = c.String(),
                        ProfessorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CursoId)
                .ForeignKey("dbo.Habilitacao", t => t.HabilitacaoId)
                .ForeignKey("dbo.Professor", t => t.ProfessorId)
                .Index(t => t.HabilitacaoId)
                .Index(t => t.ProfessorId);
            
            CreateTable(
                "dbo.Habilitacao",
                c => new
                    {
                        HabilitacaoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.HabilitacaoId);
            
            CreateTable(
                "dbo.Instituicao",
                c => new
                    {
                        InstituicaoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.InstituicaoId);
            
            CreateTable(
                "dbo.Modalidade",
                c => new
                    {
                        ModalidadeId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.ModalidadeId);
            
            CreateTable(
                "dbo.Professor",
                c => new
                    {
                        ProfessorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.String(),
                        Titulacao = c.String(),
                    })
                .PrimaryKey(t => t.ProfessorId);
            
            CreateTable(
                "dbo.TipoCurso",
                c => new
                    {
                        TipoCursoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.TipoCursoId);
            
            CreateTable(
                "dbo.Turno",
                c => new
                    {
                        TurnoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Vagas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TurnoId);
            
            CreateTable(
                "dbo.Curso_Instituicao",
                c => new
                    {
                        CursoId = c.Int(nullable: false),
                        InstituicaoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CursoId, t.InstituicaoId })
                .ForeignKey("dbo.Curso", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Instituicao", t => t.InstituicaoId, cascadeDelete: true)
                .Index(t => t.CursoId)
                .Index(t => t.InstituicaoId);
            
            CreateTable(
                "dbo.Curso_Modalidade",
                c => new
                    {
                        CursoId = c.Int(nullable: false),
                        ModalidadeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CursoId, t.ModalidadeId })
                .ForeignKey("dbo.Curso", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Modalidade", t => t.ModalidadeId, cascadeDelete: true)
                .Index(t => t.CursoId)
                .Index(t => t.ModalidadeId);
            
            CreateTable(
                "dbo.Curso_TipoCurso",
                c => new
                    {
                        CursoId = c.Int(nullable: false),
                        TipoCursoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CursoId, t.TipoCursoId })
                .ForeignKey("dbo.Curso", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.TipoCurso", t => t.TipoCursoId, cascadeDelete: true)
                .Index(t => t.CursoId)
                .Index(t => t.TipoCursoId);
            
            CreateTable(
                "dbo.Curso_Turno",
                c => new
                    {
                        CursoId = c.Int(nullable: false),
                        TurnoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CursoId, t.TurnoId })
                .ForeignKey("dbo.Curso", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Turno", t => t.TurnoId, cascadeDelete: true)
                .Index(t => t.CursoId)
                .Index(t => t.TurnoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Curso_Turno", "TurnoId", "dbo.Turno");
            DropForeignKey("dbo.Curso_Turno", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.Curso_TipoCurso", "TipoCursoId", "dbo.TipoCurso");
            DropForeignKey("dbo.Curso_TipoCurso", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.Curso", "ProfessorId", "dbo.Professor");
            DropForeignKey("dbo.Curso_Modalidade", "ModalidadeId", "dbo.Modalidade");
            DropForeignKey("dbo.Curso_Modalidade", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.Curso_Instituicao", "InstituicaoId", "dbo.Instituicao");
            DropForeignKey("dbo.Curso_Instituicao", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.Curso", "HabilitacaoId", "dbo.Habilitacao");
            DropIndex("dbo.Curso_Turno", new[] { "TurnoId" });
            DropIndex("dbo.Curso_Turno", new[] { "CursoId" });
            DropIndex("dbo.Curso_TipoCurso", new[] { "TipoCursoId" });
            DropIndex("dbo.Curso_TipoCurso", new[] { "CursoId" });
            DropIndex("dbo.Curso_Modalidade", new[] { "ModalidadeId" });
            DropIndex("dbo.Curso_Modalidade", new[] { "CursoId" });
            DropIndex("dbo.Curso_Instituicao", new[] { "InstituicaoId" });
            DropIndex("dbo.Curso_Instituicao", new[] { "CursoId" });
            DropIndex("dbo.Curso", new[] { "ProfessorId" });
            DropIndex("dbo.Curso", new[] { "HabilitacaoId" });
            DropTable("dbo.Curso_Turno");
            DropTable("dbo.Curso_TipoCurso");
            DropTable("dbo.Curso_Modalidade");
            DropTable("dbo.Curso_Instituicao");
            DropTable("dbo.Turno");
            DropTable("dbo.TipoCurso");
            DropTable("dbo.Professor");
            DropTable("dbo.Modalidade");
            DropTable("dbo.Instituicao");
            DropTable("dbo.Habilitacao");
            DropTable("dbo.Curso");
        }
    }
}

namespace PPC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AJUSTE_RELACIONAMENTO_TURNO_E_VAGAS2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Curso_Turno", "TurnoId", "dbo.Turno");
            DropIndex("dbo.Turno", new[] { "TurnoId" });
            DropPrimaryKey("dbo.Turno");
            AlterColumn("dbo.Turno", "TurnoId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Turno", "TurnoId");
            CreateIndex("dbo.Vagas", "TurnoId");
            AddForeignKey("dbo.Vagas", "TurnoId", "dbo.Turno", "TurnoId");
            AddForeignKey("dbo.Curso_Turno", "TurnoId", "dbo.Turno", "TurnoId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Curso_Turno", "TurnoId", "dbo.Turno");
            DropForeignKey("dbo.Vagas", "TurnoId", "dbo.Turno");
            DropIndex("dbo.Vagas", new[] { "TurnoId" });
            DropPrimaryKey("dbo.Turno");
            AlterColumn("dbo.Turno", "TurnoId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Turno", "TurnoId");
            CreateIndex("dbo.Turno", "TurnoId");
            AddForeignKey("dbo.Curso_Turno", "TurnoId", "dbo.Turno", "TurnoId", cascadeDelete: true);
        }
    }
}

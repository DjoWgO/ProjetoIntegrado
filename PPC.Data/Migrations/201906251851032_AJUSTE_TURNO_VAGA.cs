namespace PPC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AJUSTE_TURNO_VAGA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vagas",
                c => new
                    {
                        VagaId = c.Int(nullable: false, identity: true),
                        TurnoId = c.Int(nullable: false),
                        NumeroVagas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VagaId)
                .ForeignKey("dbo.Turno", t => t.TurnoId)
                .Index(t => t.TurnoId);
            
            DropColumn("dbo.Turno", "Vagas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Turno", "Vagas", c => c.Int(nullable: false));
            DropForeignKey("dbo.Vagas", "TurnoId", "dbo.Turno");
            DropIndex("dbo.Vagas", new[] { "TurnoId" });
            DropTable("dbo.Vagas");
        }
    }
}

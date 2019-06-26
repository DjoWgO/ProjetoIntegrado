using PPC.Entities.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;

namespace PPC.Data
{
    public class PPCContext : DbContext
    {
        public PPCContext() : base("PPC") { }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<TipoCurso> TipoCurso { get; set; }
        public DbSet<Modalidade> Modalidade { get; set; }
        public DbSet<Habilitacao> Habilitacao { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Professor> Professor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //configurações
            #region CONFIG KEY

            modelBuilder.Entity<Curso>()
                .HasKey(e => e.CursoId);

            modelBuilder.Entity<TipoCurso>()
               .HasKey(e => e.TipoCursoId);

            modelBuilder.Entity<Modalidade>()
               .HasKey(e => e.ModalidadeId);

            modelBuilder.Entity<Habilitacao>()
               .HasKey(e => e.HabilitacaoId);

            modelBuilder.Entity<Instituicao>()
               .HasKey(e => e.InstituicaoId);

            modelBuilder.Entity<Turno>()
               .HasKey(e => e.TurnoId);

            modelBuilder.Entity<Professor>()
               .HasKey(e => e.ProfessorId);

            modelBuilder.Entity<Vagas>()
              .HasKey(e => e.VagaId);

            #endregion

            #region RELACIONAMENTOS MANY X MANY

            //CURSO X TIPO CURSO
            modelBuilder.Entity<Curso>().HasMany<TipoCurso>(s => s.TipoCurso).WithMany(c => c.Cursos).Map(c =>
            {
                c.MapLeftKey("CursoId");
                c.MapRightKey("TipoCursoId");
                c.ToTable("Curso_TipoCurso");
            });

            //CURSO X MODALIDADE
            modelBuilder.Entity<Curso>().HasMany<Modalidade>(s => s.Modalidade).WithMany(c => c.Cursos).Map(c =>
            {
                c.MapLeftKey("CursoId");
                c.MapRightKey("ModalidadeId");
                c.ToTable("Curso_Modalidade");
            });


            //CURSO X INSTITUICAO
            modelBuilder.Entity<Curso>().HasMany<Instituicao>(s => s.Instituicao).WithMany(c => c.Cursos).Map(c =>
            {
                c.MapLeftKey("CursoId");
                c.MapRightKey("InstituicaoId");
                c.ToTable("Curso_Instituicao");
            });

            //CURSO X TURNO
            modelBuilder.Entity<Curso>().HasMany<Turno>(s => s.Turno).WithMany(c => c.Cursos).Map(c =>
            {
                c.MapLeftKey("CursoId");
                c.MapRightKey("TurnoId");
                c.ToTable("Curso_Turno");
            });


            #endregion

            #region OUTROS RELACIONAMENTOS

            modelBuilder.Entity<Curso>().HasRequired<Professor>(s => s.Professor)
               .WithMany(c => c.Cursos).HasForeignKey(s => s.ProfessorId);

            modelBuilder.Entity<Curso>().HasRequired<Habilitacao>(s => s.Habilitacao)
               .WithMany(c => c.Cursos).HasForeignKey(s => s.HabilitacaoId);


            modelBuilder.Entity<Vagas>().HasRequired<Turno>(s => s.Turno)
             .WithMany(c => c.Vagas).HasForeignKey(s => s.TurnoId);

            #endregion


            ////Registra as configurações das entidades
            //var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            //                      .Where(type => !String.IsNullOrEmpty(type.Namespace))
            //                      .Where(type => type.BaseType != null && type.BaseType.IsGenericType
            //                            && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            //foreach (var type in typesToRegister)
            //{
            //    dynamic configurationInstance = Activator.CreateInstance(type);
            //    modelBuilder.Configurations.Add(configurationInstance);
            //}


            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}

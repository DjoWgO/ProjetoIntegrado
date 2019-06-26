using System;
using System.Collections.Generic;

namespace PPC.Entities.Entities
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Titulacao { get; set; }

        public string AreaFormacao { get; set; }

        public string CurriculoLetters { get; set; }
        public DateTime? DataAtualizacao { get; set; }

        public string Matricula { get; set; }
        public DateTime? DataAdminissao { get; set; }
        public int? HorasNDE { get; set; }
        public int? ExtraClasseCurso { get; set; }
        public int? OrientacaoTCC { get; set; }
        public int? ExtraClasseOutrosCursos { get; set; }
        public int? CoordenacaoCurso { get; set; }
        public int? QtdeHorasCurso { get; set; }
        public int? CoordenacaoOutrosCursos { get; set; }
        public int? QtdeHorasOutrosCursos { get; set; }
        public int? PesquisaSemestreAtual { get; set; }
        public int? MembroNDE { get; set; }
        public int? MembroColegiado { get; set; }
        public int? DocenteExperiencia { get; set; }
        public DateTime? TempoIniterrupto { get; set; }
        public string TempoIniterruptoTotal { get; set; }
        public DateTime? TempoMagisterio { get; set; }
        public string TempoMagisterioTotal { get; set; }
        public DateTime? CursoDistancia { get; set; }
        public string CursoDistanciaTotal { get; set; }
        public DateTime? ExperienciaProfissional { get; set; }
        public string ExperienciaProfissionalTotal { get; set; }


        public int? NaArea { get; set; }
        public int? OutrasAreas { get; set; }
        public int? LivrosPublicados { get; set; }
        public int? OutrosLivrosPublicados { get; set; }
        public int? PublicadosAnaisCompleto { get; set; }
        public int? PublicadosAnaisResumo { get; set; }


        public int? PropriedadeIntelectualDepositado { get; set; }
        public int? PropriedadeIntelectualRegistrada { get; set; }
        public int? TraducaoLivros { get; set; }
        public int? ProducoesTecnicas { get; set; }
        public int? ProducaoDidaticoPedagogico { get; set; }

               
        public virtual List<Curso> Cursos { get; set; }

    }
}

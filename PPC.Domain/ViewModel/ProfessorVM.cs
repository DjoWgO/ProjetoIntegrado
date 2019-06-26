using PPC.Entities.Entities;
using System;
using System.Collections.Generic;

namespace PPC.Domain.ViewModel
{
    public class ProfessorVM
    {
        public int ProfessorId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Titulacao { get; set; }

        public string AreaFormacao { get; set; }

        public string CurriculoLetters { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public string StrDataAtualizacao { get; set; }

        public string Matricula { get; set; }
        public DateTime? DataAdminissao { get; set; }
        public string StrDataAdminissao { get; set; }

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
        public string StrTempoIniterrupto { get; set; }
        public string TempoIniterruptoTotal { get; set; }
        public DateTime? TempoMagisterio { get; set; }
        public string StrTempoMagisterio { get; set; }
        public string TempoMagisterioTotal { get; set; }
        public DateTime? CursoDistancia { get; set; }
        public string StrCursoDistancia { get; set; }
        public string CursoDistanciaTotal { get; set; }
        public DateTime? ExperienciaProfissional { get; set; }
        public string StrExperienciaProfissional { get; set; }
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

        public static Professor Map(ProfessorVM vm)
        {

            var professor = new Professor();
            professor.ProfessorId = vm.ProfessorId;
            professor.Nome = vm.Nome;
            professor.CPF = vm.CPF;
            professor.Titulacao = vm.Titulacao;
            professor.AreaFormacao = vm.AreaFormacao;
            professor.CurriculoLetters = vm.CurriculoLetters;
            professor.DataAtualizacao = vm.DataAtualizacao;
            professor.Matricula = vm.Matricula;
            professor.DataAdminissao = vm.DataAdminissao;
            professor.HorasNDE = vm.HorasNDE;
            professor.ExtraClasseCurso = vm.ExtraClasseCurso;
            professor.OrientacaoTCC = vm.OrientacaoTCC;
            professor.ExtraClasseOutrosCursos = vm.ExtraClasseOutrosCursos;
            professor.CoordenacaoCurso = vm.CoordenacaoCurso;
            professor.QtdeHorasCurso = vm.QtdeHorasCurso;
            professor.CoordenacaoOutrosCursos = vm.CoordenacaoOutrosCursos;
            professor.QtdeHorasOutrosCursos = vm.QtdeHorasOutrosCursos;
            professor.PesquisaSemestreAtual = vm.PesquisaSemestreAtual;
            professor.MembroNDE = vm.MembroNDE;
            professor.MembroColegiado = vm.MembroColegiado;
            professor.DocenteExperiencia = vm.DocenteExperiencia;
            professor.TempoIniterrupto = vm.TempoIniterrupto;
            professor.TempoIniterruptoTotal = vm.TempoIniterruptoTotal;
            professor.TempoMagisterio = vm.TempoMagisterio;
            professor.TempoMagisterioTotal = vm.TempoMagisterioTotal;
            professor.CursoDistancia = vm.CursoDistancia;
            professor.CursoDistanciaTotal = vm.CursoDistanciaTotal;
            professor.ExperienciaProfissional = vm.ExperienciaProfissional;
            professor.ExperienciaProfissionalTotal = vm.ExperienciaProfissionalTotal;
            professor.NaArea = vm.NaArea;
            professor.OutrasAreas = vm.OutrasAreas;
            professor.LivrosPublicados = vm.LivrosPublicados;
            professor.OutrosLivrosPublicados = vm.OutrosLivrosPublicados;
            professor.PublicadosAnaisCompleto = vm.PublicadosAnaisCompleto;
            professor.PublicadosAnaisResumo = vm.PublicadosAnaisResumo;
            professor.PropriedadeIntelectualDepositado = vm.PropriedadeIntelectualDepositado;
            professor.PropriedadeIntelectualRegistrada = vm.PropriedadeIntelectualRegistrada;
            professor.TraducaoLivros = vm.TraducaoLivros;
            professor.ProducoesTecnicas = vm.ProducoesTecnicas;
            professor.ProducaoDidaticoPedagogico = vm.ProducaoDidaticoPedagogico;

            return professor;

        }

        public static List<Professor> Map(List<ProfessorVM> vm)
        {

            var professor = new List<Professor>();

            foreach (var item in vm)
            {
                professor.Add(Map(item));
            }

            return professor;

        }

        public static ProfessorVM Map(Professor obj)
        {

            var professor = new ProfessorVM();
            professor.ProfessorId = obj.ProfessorId;
            professor.Nome = obj.Nome;
            professor.CPF = obj.CPF;
            professor.Titulacao = obj.Titulacao;
            professor.AreaFormacao = obj.AreaFormacao;
            professor.CurriculoLetters = obj.CurriculoLetters;
            professor.DataAtualizacao = obj.DataAtualizacao;
            professor.Matricula = obj.Matricula;
            professor.DataAdminissao = obj.DataAdminissao;
            professor.HorasNDE = obj.HorasNDE;
            professor.ExtraClasseCurso = obj.ExtraClasseCurso;
            professor.OrientacaoTCC = obj.OrientacaoTCC;
            professor.ExtraClasseOutrosCursos = obj.ExtraClasseOutrosCursos;
            professor.CoordenacaoCurso = obj.CoordenacaoCurso;
            professor.QtdeHorasCurso = obj.QtdeHorasCurso;
            professor.CoordenacaoOutrosCursos = obj.CoordenacaoOutrosCursos;
            professor.QtdeHorasOutrosCursos = obj.QtdeHorasOutrosCursos;
            professor.PesquisaSemestreAtual = obj.PesquisaSemestreAtual;
            professor.MembroNDE = obj.MembroNDE;
            professor.MembroColegiado = obj.MembroColegiado;
            professor.DocenteExperiencia = obj.DocenteExperiencia;
            professor.TempoIniterrupto = obj.TempoIniterrupto;
            professor.TempoIniterruptoTotal = obj.TempoIniterruptoTotal;
            professor.TempoMagisterio = obj.TempoMagisterio;
            professor.TempoMagisterioTotal = obj.TempoMagisterioTotal;
            professor.CursoDistancia = obj.CursoDistancia;
            professor.CursoDistanciaTotal = obj.CursoDistanciaTotal;
            professor.ExperienciaProfissional = obj.ExperienciaProfissional;
            professor.ExperienciaProfissionalTotal = obj.ExperienciaProfissionalTotal;
            professor.NaArea = obj.NaArea;
            professor.OutrasAreas = obj.OutrasAreas;
            professor.LivrosPublicados = obj.LivrosPublicados;
            professor.OutrosLivrosPublicados = obj.OutrosLivrosPublicados;
            professor.PublicadosAnaisCompleto = obj.PublicadosAnaisCompleto;
            professor.PublicadosAnaisResumo = obj.PublicadosAnaisResumo;
            professor.PropriedadeIntelectualDepositado = obj.PropriedadeIntelectualDepositado;
            professor.PropriedadeIntelectualRegistrada = obj.PropriedadeIntelectualRegistrada;
            professor.TraducaoLivros = obj.TraducaoLivros;
            professor.ProducoesTecnicas = obj.ProducoesTecnicas;
            professor.ProducaoDidaticoPedagogico = obj.ProducaoDidaticoPedagogico;

            return professor;

        }

        public static List<ProfessorVM> Map(List<Professor> obj)
        {

            var professor = new List<ProfessorVM>();

            foreach (var item in obj)
            {
                professor.Add(Map(item));
            }

            return professor;

        }
    }
}

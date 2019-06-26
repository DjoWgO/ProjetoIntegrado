var appProfessor = new Vue({
    el: '#app-professor',
    data: {
        professor: {}
    },
    methods: {
        salvar: function () {

            var obj = {
                ProfessorId: idProfessor,
                Matricula: this.professor.Matricula,
                DataAdminissao: this.professor.DataAdminissao,
                HorasNDE: this.professor.HorasNDE,
                ExtraClasseCurso: this.professor.ExtraClasseCurso,
                OrientacaoTCC: this.professor.OrientacaoTCC,
                ExtraClasseOutrosCursos: this.professor.ExtraClasseOutrosCursos,
                CoordenacaoCurso: this.professor.CoordenacaoCurso,
                QtdeHorasCurso: this.professor.QtdeHorasCurso,
                CoordenacaoOutrosCursos: this.professor.CoordenacaoOutrosCursos,
                QtdeHorasOutrosCursos: this.professor.QtdeHorasOutrosCursos,
                PesquisaSemestreAtual: this.professor.PesquisaSemestreAtual,
                MembroNDE: (this.professor.MembroNDE) ? 1 : 0,
                MembroColegiado: (this.professor.MembroColegiado) ? 1 : 0,
                DocenteExperiencia: (this.professor.DocenteExperiencia) ? 1 : 0,
                TempoIniterrupto: this.professor.TempoIniterrupto,
                TempoIniterruptoTotal: this.professor.TempoIniterruptoTotal,
                TempoMagisterio: this.professor.TempoMagisterio,
                TempoMagisterioTotal: this.professor.TempoMagisterioTotal,
                CursoDistancia: this.professor.CursoDistancia,
                CursoDistanciaTotal: this.professor.CursoDistanciaTotal,
                ExperienciaProfissional: this.professor.ExperienciaProfissional,
                ExperienciaProfissionalTotal: this.professor.ExperienciaProfissionalTotal,
                NaArea: this.professor.NaArea,
                OutrasAreas: this.professor.OutrasAreas,
                LivrosPublicados: this.professor.LivrosPublicados,
                OutrosLivrosPublicados: this.professor.OutrosLivrosPublicados,
                PublicadosAnaisCompleto: this.professor.PublicadosAnaisCompleto,
                PublicadosAnaisResumo: this.professor.PublicadosAnaisResumo,
                PropriedadeIntelectualDepositado: this.professor.PropriedadeIntelectualDepositado,
                PropriedadeIntelectualRegistrada: this.professor.PropriedadeIntelectualRegistrada,
                TraducaoLivros: this.professor.TraducaoLivros,
                ProducoesTecnicas: this.professor.ProducoesTecnicas,
                ProducaoDidaticoPedagogico: this.professor.ProducaoDidaticoPedagogico
            };


            var str = JSON.stringify(obj);
            salvar(str).done(function (data) {

                if (!data.Ok) {
                    toastr.error(data.Msg);
                    return;
                }

                toastr.success("Salvo com sucesso!");

                setTimeout(function () { window.location = '/Professor/Pesquisar'; }, 1000);
            });
        }
    },
    created: function () {

        var self = this;

        obterDadosProfessor(idProfessor).done(function (data) {

            if (!data.Ok) toastr.error(data.Msg);

            if (data.Result) {

                data.Result.CursoDistancia = data.Result.StrCursoDistancia;
                data.Result.DataAdminissao = data.Result.StrDataAdminissao;
                data.Result.DataAtualizacao = data.Result.StrDataAtualizacao;
                data.Result.ExperienciaProfissional = data.Result.StrExperienciaProfissional;
                data.Result.TempoIniterrupto = data.Result.StrTempoIniterrupto;
                data.Result.TempoMagisterio = data.Result.StrTempoMagisterio;


                self.professor = data.Result;
            }

        });
    }
});

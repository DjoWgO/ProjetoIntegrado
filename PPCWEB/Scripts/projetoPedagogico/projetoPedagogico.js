/// <reference path="projetopedagogicorepository.js" />
var appProjetoPedagogico = new Vue({
    el: '#app-pp',
    data: {
        pp: {
            Curso: 1,
            TrabalhoConclusao: 'S',
            EstagioCurricular: 'S'
        }

    },
    methods: {
        salvar: function () {
         
            var projeto = {
                Curso: this.pp.Curso,
                EstagioCurricular: this.pp.EstagioCurricular,
                FormaAcesso: this.pp.FormaAcesso,
                PerfilCurso: this.pp.PerfilCurso,
                PerfilEgresso: this.pp.PerfilEgresso,
                PraticaAtendimento: this.pp.PraticaAtendimento,
                RepresentacaoGrafica: this.pp.RepresentacaoGrafica,
                SistemaAprendizagem: this.pp.SistemaAprendizagem,
                TrabalhoConclusao: this.TrabalhoConclusao
            };


        }
    },
    created: function () {

        var self = this;

        obterDadosProjetoPedagogico().done(function (data) {

            if (!data.Ok) toastr.error(data.Msg);

            self.pp = data.Result;
            self.pp.Curso = 1;
            self.pp.TrabalhoConclusao = 'S';
            self.pp.EstagioCurricular = 'S';

        });

        initDatatables();
    }
});

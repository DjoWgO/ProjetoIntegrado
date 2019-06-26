/// <reference path="servicecurso.js" />
/// <reference path="cursovm.js" />

var appCurso = new Vue({
    el: '#app-curso',
    data: {
        mTipoCurso: 1,
        lstTipoCurso: [],
        curso: { TipoCurso: null, CPF: null, MaiorTitulacao: null, TempoDedicacao: null },
        lstVagasTurno: []
    },
    methods: {
        adicionarVagasLocal: function (e) {

            if (!this.inArray(e.id, this.lstVagasTurno)) {
                this.lstVagasTurno.push({ value: e.id, text: e.text.trim() });
            }

        },
        adicionarProfessor: function (id) {

            var self = this;

            if (self.curso.Professores) {

                var cont = self.curso.Professores.length;
                for (var i = 0; i < cont; i++) {
                    var item = self.curso.Professores[i];
                    if (item.ProfessorId == id) {

                        $('#cpfCoordenador').val(item.CPF);
                        $('#titulacao').val(item.MaiorTitulacao);
                        $('#tempoDedicacao').val(item.TempoDedicacao);

                    }
                }
            }           

        },
        limparCoordenador: function () {
            this.curso.CPF = "";
            this.curso.MaiorTitulacao = "";
            this.curso.TempoDedicacao = "";
        },
        inArray: function (valor, array) {
            var length = array.length;
            for (var i = 0; i < length; i++) {
                if (array[i].value == valor) return true;
            }
            return false;
        },
        salvar: function () {

            cursoVM.TipoCurso = this.curso.TipoCurso;
            cursoVM.Denominacao = this.curso.Denominacao;
            cursoVM.Habilitacao = this.curso.Habilitacao;
            cursoVM.RegimeLetivo = this.curso.RegimeLetivo;
            cursoVM.Periodos = this.curso.Periodos;
            cursoVM.Coordenador.Nome = this.curso.CoordenadorId;
            cursoVM.Coordenador.CPF = this.curso.CPF;
            cursoVM.Titulacao = this.curso.MaiorTitulacao;
            cursoVM.TempoDedicacao = this.curso.TempoDedicacao;

            cursoVM.Modalidades = obterModalidades();
            cursoVM.LocaisOferta = obterLocaisOferta();
            cursoVM.TurnosFuncionamento = obterTurnoFuncionamento();
            cursoVM.CoordenadorId = $('#NomeCoordenador').val();

            var strCurso = JSON.stringify(cursoVM);

            salvar(strCurso).done(function (data) {

                if (!data.Ok) toastr.error(data.Msg);

                toastr.success("Curso salvo com sucesso!");

            });

        }
    },
    created: function () {

        var self = this;

        //Popula o tipo do curso
        obterDadosCurso().done(function (data) {

            if (!data.Ok) toastr.error(data.Msg);

            self.curso = data.Result;

            $('.select2-mult').select2();

            verificarTurnos();


        });

        popularCoordenador();
    }
});

function popularCoordenador() {

    setTimeout(function () {

        $('.select2-coordenador').on("change", function (e) {
            var data = $('.select2-coordenador').select2('data');

            if (data.length > 0) {
                var professorId = data[0].id;

                if (professorId == 0) {
                    appCurso.limparCoordenador();
                    return;
                }

                appCurso.adicionarProfessor(professorId);
            }
        });
    }, 500);
}

function verificarTurnos() {
    $('.select2-turnos').on("change", function (e) {

        var data = $('.select2-turnos').select2('data');

        $.map(data, function (value) {
            appCurso.adicionarVagasLocal(value);
        });
    });

    $('.select2-turnos').on('select2:unselecting', function (e) {
        appCurso.lstVagasTurno = [];

        setTimeout(function () { $('.select2-turnos').change(); }, 500);

    });
}

function obterModalidades() {

    var arrModalidade = $('#modalidade').val();

    var map = $.map(arrModalidade, function (e) {
        return { ModalidadeId: e };
    });

    return map;
}

function obterLocaisOferta() {

    var arrLocalOferta = $('#localOferta').val();

    var map = $.map(arrLocalOferta, function (e) {
        return { LocalOfertaId: e };
    });

    return map;
}

function obterTurnoFuncionamento() {

    var arrTurnoFuncionamento = $('#turnoFuncionamento').val();

    var map = $.map(arrTurnoFuncionamento, function (e) {

        var vagas = $('#numeroVagasTurno' + e).val();

        return { TurnoFuncionamentoId: e, Vagas: vagas };
    });

    return map;
}

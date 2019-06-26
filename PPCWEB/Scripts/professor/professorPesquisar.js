/// <reference path="professorrepository.js" />
var appProfessorPesquisar = new Vue({
    el: '#app-pesquisar',
    data: {
        lstProfessores: []
    },
    methods: {
        gerenciar: function (e) {
            window.location = "/Professor/Gerenciar/" + e;
        },
        alterar: function (e) {
            window.location = "/Professor/Alterar/" + e;
        },
        remover: function (e) {
            window.location = "/Professor/Remover/" + e;
        }
    },
    created: function () {

        var self = this;

        //Popula o tipo do curso
        obterDadosPesquisar().done(function (data) {

            if (!data.Ok) toastr.error(data.Msg);

            self.lstProfessores = data.Result;

        });

    }
});

$(function () {
    setTimeout(function () {
        initDatatables();
    }, 1000);
});
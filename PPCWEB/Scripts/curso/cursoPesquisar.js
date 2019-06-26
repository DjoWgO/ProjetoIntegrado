/// <reference path="servicecurso.js" />

var appCursoPesquisar = new Vue({
    el: '#app-pesquisar',
    data: {
        lstCursos: [],
        pesquisa: null
    },
    methods: {
      
    },
    created: function () {

        var self = this;

        //Popula o tipo do curso
        obterDadosPesquisar().done(function (data) {

            if (!data.Ok) toastr.error(data.Msg);

            self.lstCursos = data.Result;

        });

    }
});

$(function () {
    initDatatables();
});
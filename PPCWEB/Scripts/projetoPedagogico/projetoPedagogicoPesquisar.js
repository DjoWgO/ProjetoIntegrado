var appPesquisar = new Vue({
    el: '#app-pesquisar',
    data: {
        lstPP: []
    },
    methods: {
       
    },
    created: function () {

        var self = this;

        obterDadosPesquisa().done(function (data) {

            if (!data.Ok) toastr.error(data.Msg);

            self.lstPP = data.Result;
            //initDatatables();
        });

       
    }
});

$(function () {
    initDatatables();
});
var appProfessor = new Vue({
    el: '#app-professor',
    data: {
       professor: []
    },
    methods: {
        salvar: function () {

            var obj = {
                Nome: this.professor.Nome,
                CPF: this.professor.CPF,
                CurriculoLetters: this.professor.CurriculoLetters,
                DataAtualizacao: this.professor.DataAtualizacao,
                AreaFormacao: this.professor.AreaFormacao,
                Titulacao: this.professor.Titulacao
            };


            var str = JSON.stringify(obj);
            salvar(str).done(function (data) {

                if (!data.Ok) {
                    toastr.error(data.Msg);
                    return;
                }

                toastr.success("Salvo com sucesso!");
            });
        }
    },
    created: function () {

    }
});

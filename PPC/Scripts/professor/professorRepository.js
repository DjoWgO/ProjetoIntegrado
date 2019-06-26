function obterDadosPesquisar() {

    return $.get('/Professor/ObterDadosPesquisar');

}

function salvar(obj) {

    return $.post('/Professor/Salvar', { obj: obj });

}

function obterDadosProfessor(e) {
    return $.get('/Professor/ObterGerenciar', { id: e });
}
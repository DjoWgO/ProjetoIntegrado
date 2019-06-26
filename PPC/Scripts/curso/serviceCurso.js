function obterDadosCurso() {

    return $.get('/Curso/ObterDadosCurso');

}

function obterDadosPesquisar() {
    return $.get('/Curso/ObterDadosPesquisar');
 
}

function salvar(obj) {
    return $.post("/Curso/Salvar", { obj: obj });
}

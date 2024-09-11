const prompt = require('prompt-sync')();

function saudacao(nome){
    console.log(' oi ' +  nome )
}
function entradaNome(callbak) {
    var nome  =prompt('fale seu nome  ')
    callbak(nome)
}

entradaNome(saudacao)
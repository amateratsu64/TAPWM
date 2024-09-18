function exibeMensagensNaOrdem(messagem, callback){
    console,console.log(messagem);
    callback();

}
exibeMensagensNaOrdem('Essa e a primeira messagem exibida na ordem',function(){
    console.log("essa e a segunda messagem exibida na ordem")
})
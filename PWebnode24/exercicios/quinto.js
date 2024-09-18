var eventos = require('events')
var emissoreventos = eventos.EventEmitter
var ee = new emissoreventos()

ee.on('dados',function(fechar){
    console.log(fechar)
})

setlnterval(function(){
    ee.emit('dados',Date.now())
}, 500)
    


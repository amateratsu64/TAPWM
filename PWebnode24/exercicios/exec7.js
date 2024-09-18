var http = require('http')
var server = http.createServer(function(req,res){
    var opcao = req.url
    if(opcao=='/historia'){
        res.end("<html><body>site da fatec sorocaba</body></html>")
    }
    else if (opcao=='/cursos'){
        res.end("<html><body>cusos</body></html>")
    }
    else if (opcao=='porfessores') {
        res.end("<html><body>professores</body></html>")    
    }
    else
    res.end("<html><body>site da fatec sorocaba</body></html>")
})
server.listen(3000)
var app = require('./atividade22/app/config/server')
app.get('/', function(red,res){
    res.send("home/index");
})
app.get('/fomulario_adicionar_usuario', function(red,res){
   res.render("admin/adicionar_usuario")
})
app.get('/informacao/historia', function(red,res){
    res.render("informacao/historia")
})
app.get('/informacao/curso', function(red,res){
    res.render("informacao/curso")
})
app.get('/informacao/professores', function(red,res){
    res.render("informacao/professores")
})
app.listen(3000, function(){
 console.log("server iniciado ")   
}
)

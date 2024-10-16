var express = require('express');
var texto= require('../modulo1.js')
var app = require('../app/config/server.js')
app.get('/', function(req,res){
    res.render("home/index");
})

app.get('/adicionar_usuario', function(req,res){
    res.render("admin/adicionarUsuarios");
})

app.get('/historia', function(req,res){
    res.render("informacao/historia")
})

app.get('/cursos', function(req,res){
    res.render("informacao/cursos")
})

app.get('/professores', function(req,res){
    res.send("informacao/professores")
})

app.get('/professores', function(req,res){
    res.send("informacao/professores")
})

app.listen(3000, function(){
    console.log(texto)
})
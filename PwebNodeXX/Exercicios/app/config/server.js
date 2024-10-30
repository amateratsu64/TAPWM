var express = require('express');
var consign = require('consign');
var bodyPaerser = require('body-parser');
 
var app = express();
 
app.set('view engine', 'ejs');
app.set('views', './app/views');
 
app.use(bodyPaerser.urlencoded({extended:true})) 
consign({cwd:'app'}) // para incluir a pasta app
  .include('routes')
  .then('models')
  .then('config/dbConnection.js')
  .into(app);
 
module.exports = app;
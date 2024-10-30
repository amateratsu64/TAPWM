
//var dbConnection = require('../config/dbConnections');   
 
module.exports = function(app){
  app.get('/informacao/professores', function(req,res){
    async function getProfessores() {
           try {
                var connection = app.config.dbConnections

                const pool = await connection();
 
               const results = await pool.request().query('SELECT * from PROFESSORES');
 
               res.render('informacao/professores',{profs :  results.recordset});
 
           } catch (err) {
               console.log(err)
           }
       }
 
  getProfessores();
   });
};
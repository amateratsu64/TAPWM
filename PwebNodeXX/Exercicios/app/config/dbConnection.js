var sql = require ('mssql');
 
var connSQLServer = function(){
   const sqlConfig = {
       user: 'BD2412024',
       password: 'Mp14032006#',
       database:'BD',
       server: 'APOLO',
       options:{
           encrypt: false,
           trustServerCertificate: true
       }
   }       
   module.exports = function(){
    console.log ('foi eu acho')
    return connSQLServer;
   }
}
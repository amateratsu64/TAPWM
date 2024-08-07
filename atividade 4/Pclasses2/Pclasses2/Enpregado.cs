using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses2
{
    abstract internal class Empregado
    {
        private int matricula;
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;



        public int Maricula {
            get { return matricula; }
            set {  matricula = value; } 
        }

        public string NomeEmpregado {
            get { return nomeEmpregado; }
            set {  nomeEmpregado = value; } 
        }
        public DateTime DataEntradaEmpresa 
        {
            get {  return dataEntradaEmpresa; } 
            set { dataEntradaEmpresa = value; }
        }
        public virtual int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days);
        }
        public abstract double salarioBruto();
    }
}

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

        public Empregado()
        {
            System.Windows.Forms.MessageBox.Show("tu e empregado");
        }
         public Empregado(int mat, string nome,DateTime datax)
        {
            matricula = mat;
            nomeEmpregado = nome;
            dataEntradaEmpresa = datax;
        }



        public int Matricula {
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
        public abstract double SalarioBruto();
    }
}

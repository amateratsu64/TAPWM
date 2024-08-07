using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses2
{
    internal class Mensalista : Empregado
    {
        public double salarioMensal { get; set; }

        public static String Empresa = "tomas turbano";
        public const String filial = "filial brasil";


        public Mensalista(int matx, String nomex, DateTime datax,double salx)
        {
            this.NomeEmpregado = nomex;
            this.Matricula = matx;
            this.DataEntradaEmpresa = datax;
            this.salarioMensal = salx;         
        }

        public Mensalista()
        {
            System.Windows.Forms.MessageBox.Show("tu e mensal");
        }


        public override double SalarioBruto()
        {
            return salarioMensal;
        }

    }
}

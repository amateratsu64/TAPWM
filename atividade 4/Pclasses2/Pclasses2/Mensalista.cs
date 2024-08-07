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

        public static string Empresa = "";


        public override double salarioBruto()
        {
            return salarioMensal;
        }

    }
}

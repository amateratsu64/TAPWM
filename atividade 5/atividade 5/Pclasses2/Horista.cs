using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses2
{
    internal class Horista : Empregado
    {
        public double SalarioHora { get; set; }
        public double NUmeroHora { get; set; }
        public int DiasFalta { get; set; }
        public override double SalarioBruto()
        {
            return SalarioHora * NUmeroHora;
        }
        public double SalarioBruto(double aumento)
        {
            double sal = SalarioHora * NUmeroHora;
            return (sal + sal * (aumento / 100));
        }
        public override int TempoTrabalho()
        {
            TimeSpan span = 
                DateTime.Today.Subtract(DataEntradaEmpresa);
            return (Convert.ToInt32(span.Days) - DiasFalta);
        }
    }
}

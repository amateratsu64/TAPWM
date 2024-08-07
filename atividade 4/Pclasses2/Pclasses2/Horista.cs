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
        public override double salarioBruto()
        {
            return SalarioHora * NUmeroHora;
        }
        public override int TempoTrabalho()
        {
            TimeSpan span = 
                DateTime.Today.Subtract(DataEntradaEmpresa);
            return (Convert.ToInt32(span.Days) - DiasFalta);
        }
    }
}

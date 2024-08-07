using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasses2
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInstancia1_Click(object sender, EventArgs e)
        {
            Mensalista objmensalista = new Mensalista(); 

            objmensalista.NomeEmpregado = txtnome.Text;
            objmensalista.Matricula = Convert.ToInt32(txtmatricula.Text);
            objmensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objmensalista.salarioMensal = Convert.ToDouble(txtSalario.Text);

            MessageBox.Show("nome=" + objmensalista.NomeEmpregado + "\n" +
                            "matricula=" + objmensalista.Matricula + "\n" +
                            "tempo trabalho:" + objmensalista.TempoTrabalho() + "\n" +
                            "salario final=" +
                            objmensalista.SalarioBruto().ToString("N2"));
            MessageBox.Show(Mensalista.Empresa);
            MessageBox.Show(Mensalista.filial);

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInstancia2_Click(object sender, EventArgs e)
        {
            Mensalista objmensalista = new Mensalista(
            Convert.ToInt32(txtmatricula.Text),
                txtnome.Text,
            Convert.ToDateTime(txtData.Text),
            Convert.ToDouble(txtSalario.Text));
            
            MessageBox.Show("nome=" + objmensalista.NomeEmpregado + "\n" +
                            "matricula=" + objmensalista.Matricula + "\n" +
                            "tempo trabalho:" + objmensalista.TempoTrabalho() + "\n" +
                            "salario final=" +
                            objmensalista.SalarioBruto().ToString("N2"));
        }
    }
}

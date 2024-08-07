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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void txtsalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBAox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInstancia1_Click(object sender, EventArgs e)
        {
            Horista objhorista = new Horista();

            objhorista.NomeEmpregado = txtNome.Text;
            objhorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objhorista.SalarioHora = Convert.ToDouble(Salario.Text);
            objhorista.NUmeroHora= Convert.ToDouble(Hora.Text);
            objhorista.DataEntradaEmpresa = Convert.ToDateTime(textData.Text);
            objhorista.DiasFalta = Convert.ToInt32(txtFalta.Text);

            MessageBox.Show("nome:" + objhorista.NomeEmpregado +
                "\n" + "matricula" + objhorista.Matricula + "\n" +
                "tempo trabalho" + objhorista.TempoTrabalho().ToString() +
                "\n" + "salario" + objhorista.SalarioBruto().ToString("N2"));

            MessageBox.Show($"Salario com aumento : {objhorista.SalarioBruto(50).ToString("N2")}");

                
        }

        private void Hora_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHorista_Load(object sender, EventArgs e)
        {

        }
    }
}

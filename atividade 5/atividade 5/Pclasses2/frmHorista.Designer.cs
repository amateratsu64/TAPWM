namespace Pclasses2
{
    partial class frmHorista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInstancia2 = new System.Windows.Forms.Button();
            this.btnInstancia1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Salario = new System.Windows.Forms.TextBox();
            this.Hora = new System.Windows.Forms.TextBox();
            this.txtFalta = new System.Windows.Forms.TextBox();
            this.textData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "salario por hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Data Entrada na Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "numero de faltas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Matricula";
            // 
            // btnInstancia2
            // 
            this.btnInstancia2.Location = new System.Drawing.Point(431, 293);
            this.btnInstancia2.Name = "btnInstancia2";
            this.btnInstancia2.Size = new System.Drawing.Size(231, 110);
            this.btnInstancia2.TabIndex = 33;
            this.btnInstancia2.Text = "Instancia Mensalista Passado Paremetro";
            this.btnInstancia2.UseVisualStyleBackColor = true;
            // 
            // btnInstancia1
            // 
            this.btnInstancia1.Location = new System.Drawing.Point(128, 293);
            this.btnInstancia1.Name = "btnInstancia1";
            this.btnInstancia1.Size = new System.Drawing.Size(193, 110);
            this.btnInstancia1.TabIndex = 32;
            this.btnInstancia1.Text = "INstancia hora";
            this.btnInstancia1.UseVisualStyleBackColor = true;
            this.btnInstancia1.Click += new System.EventHandler(this.btnInstancia1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "numero horas";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(91, 6);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 26);
            this.txtMatricula.TabIndex = 45;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(241, 26);
            this.txtNome.TabIndex = 46;
            // 
            // Salario
            // 
            this.Salario.Location = new System.Drawing.Point(136, 94);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(136, 26);
            this.Salario.TabIndex = 47;
            // 
            // Hora
            // 
            this.Hora.Location = new System.Drawing.Point(125, 131);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(147, 26);
            this.Hora.TabIndex = 48;
            this.Hora.TextChanged += new System.EventHandler(this.Hora_TextChanged);
            // 
            // txtFalta
            // 
            this.txtFalta.Location = new System.Drawing.Point(146, 163);
            this.txtFalta.Name = "txtFalta";
            this.txtFalta.Size = new System.Drawing.Size(147, 26);
            this.txtFalta.TabIndex = 49;
            this.txtFalta.TextChanged += new System.EventHandler(this.textBAox5_TextChanged);
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(213, 204);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(153, 26);
            this.textData.TabIndex = 50;
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.txtFalta);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInstancia2);
            this.Controls.Add(this.btnInstancia1);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.Load += new System.EventHandler(this.frmHorista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInstancia2;
        private System.Windows.Forms.Button btnInstancia1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox Salario;
        private System.Windows.Forms.TextBox Hora;
        private System.Windows.Forms.TextBox txtFalta;
        private System.Windows.Forms.TextBox textData;
    }
}
namespace Pclasses2
{
    partial class frmMensalista
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.btnInstancia2 = new System.Windows.Forms.Button();
            this.btnInstancia1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data Entrada na Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Salario Mensal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Matricula";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(325, 191);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(116, 26);
            this.txtData.TabIndex = 15;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(325, 144);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(153, 26);
            this.txtSalario.TabIndex = 14;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(325, 89);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(319, 26);
            this.txtnome.TabIndex = 13;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(325, 41);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 26);
            this.txtmatricula.TabIndex = 12;
            this.txtmatricula.TextChanged += new System.EventHandler(this.txtmatricula_TextChanged);
            // 
            // btnInstancia2
            // 
            this.btnInstancia2.Location = new System.Drawing.Point(440, 279);
            this.btnInstancia2.Name = "btnInstancia2";
            this.btnInstancia2.Size = new System.Drawing.Size(231, 110);
            this.btnInstancia2.TabIndex = 11;
            this.btnInstancia2.Text = "Instancia Mensalista Passado Paremetro";
            this.btnInstancia2.UseVisualStyleBackColor = true;
            this.btnInstancia2.Click += new System.EventHandler(this.btnInstancia2_Click);
            // 
            // btnInstancia1
            // 
            this.btnInstancia1.Location = new System.Drawing.Point(137, 279);
            this.btnInstancia1.Name = "btnInstancia1";
            this.btnInstancia1.Size = new System.Drawing.Size(193, 110);
            this.btnInstancia1.TabIndex = 10;
            this.btnInstancia1.Text = "Instancia Mensalista";
            this.btnInstancia1.UseVisualStyleBackColor = true;
            this.btnInstancia1.Click += new System.EventHandler(this.btnInstancia1_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.btnInstancia2);
            this.Controls.Add(this.btnInstancia1);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Button btnInstancia2;
        private System.Windows.Forms.Button btnInstancia1;
    }
}
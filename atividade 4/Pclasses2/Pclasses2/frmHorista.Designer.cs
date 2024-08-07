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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.btnInstancia2 = new System.Windows.Forms.Button();
            this.btnInstancia1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Data Entrada na Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Salario Mensal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Matricula";
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(341, 201);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(116, 26);
            this.txtdata.TabIndex = 25;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(341, 154);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(153, 26);
            this.txtsalario.TabIndex = 24;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(341, 99);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(319, 26);
            this.txtnome.TabIndex = 23;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(341, 51);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 26);
            this.txtmatricula.TabIndex = 22;
            // 
            // btnInstancia2
            // 
            this.btnInstancia2.Location = new System.Drawing.Point(456, 289);
            this.btnInstancia2.Name = "btnInstancia2";
            this.btnInstancia2.Size = new System.Drawing.Size(231, 110);
            this.btnInstancia2.TabIndex = 21;
            this.btnInstancia2.Text = "Instancia Mensalista Passado Paremetro";
            this.btnInstancia2.UseVisualStyleBackColor = true;
            // 
            // btnInstancia1
            // 
            this.btnInstancia1.Location = new System.Drawing.Point(153, 289);
            this.btnInstancia1.Name = "btnInstancia1";
            this.btnInstancia1.Size = new System.Drawing.Size(193, 110);
            this.btnInstancia1.TabIndex = 20;
            this.btnInstancia1.Text = "INstancia Mensalista";
            this.btnInstancia1.UseVisualStyleBackColor = true;
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.btnInstancia2);
            this.Controls.Add(this.btnInstancia1);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Button btnInstancia2;
        private System.Windows.Forms.Button btnInstancia1;
    }
}
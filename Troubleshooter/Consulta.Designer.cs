
namespace Troubleshooter
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.gboxSolucao = new System.Windows.Forms.GroupBox();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.lblCriador = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rctSolucao = new System.Windows.Forms.RichTextBox();
            this.gboxDefeito = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rctDefeito = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCMDGEN = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gboxSolucao.SuspendLayout();
            this.gboxDefeito.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSolucao
            // 
            this.gboxSolucao.Controls.Add(this.btnHistorico);
            this.gboxSolucao.Controls.Add(this.lblCriador);
            this.gboxSolucao.Controls.Add(this.label6);
            this.gboxSolucao.Controls.Add(this.button1);
            this.gboxSolucao.Controls.Add(this.label5);
            this.gboxSolucao.Controls.Add(this.rctSolucao);
            this.gboxSolucao.Location = new System.Drawing.Point(373, 77);
            this.gboxSolucao.Name = "gboxSolucao";
            this.gboxSolucao.Size = new System.Drawing.Size(329, 246);
            this.gboxSolucao.TabIndex = 11;
            this.gboxSolucao.TabStop = false;
            this.gboxSolucao.Text = "Solução";
            // 
            // btnHistorico
            // 
            this.btnHistorico.Enabled = false;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Image = global::Troubleshooter.Properties.Resources.modfs;
            this.btnHistorico.Location = new System.Drawing.Point(283, 12);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(35, 35);
            this.btnHistorico.TabIndex = 7;
            this.btnHistorico.UseVisualStyleBackColor = true;
            // 
            // lblCriador
            // 
            this.lblCriador.AutoSize = true;
            this.lblCriador.Location = new System.Drawing.Point(139, 50);
            this.lblCriador.Name = "lblCriador";
            this.lblCriador.Size = new System.Drawing.Size(17, 15);
            this.lblCriador.TabIndex = 6;
            this.lblCriador.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alterador por:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Troubleshooter.Properties.Resources.files;
            this.button1.Location = new System.Drawing.Point(7, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Essa solução não possui anexos";
            // 
            // rctSolucao
            // 
            this.rctSolucao.Enabled = false;
            this.rctSolucao.Location = new System.Drawing.Point(6, 71);
            this.rctSolucao.Name = "rctSolucao";
            this.rctSolucao.Size = new System.Drawing.Size(317, 169);
            this.rctSolucao.TabIndex = 2;
            this.rctSolucao.Text = "";
            // 
            // gboxDefeito
            // 
            this.gboxDefeito.Controls.Add(this.label4);
            this.gboxDefeito.Controls.Add(this.label3);
            this.gboxDefeito.Controls.Add(this.textBox2);
            this.gboxDefeito.Controls.Add(this.rctDefeito);
            this.gboxDefeito.Location = new System.Drawing.Point(12, 77);
            this.gboxDefeito.Name = "gboxDefeito";
            this.gboxDefeito.Size = new System.Drawing.Size(344, 246);
            this.gboxDefeito.TabIndex = 10;
            this.gboxDefeito.TabStop = false;
            this.gboxDefeito.Text = "Defeito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição completa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resumo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 23);
            this.textBox2.TabIndex = 4;
            // 
            // rctDefeito
            // 
            this.rctDefeito.Enabled = false;
            this.rctDefeito.Location = new System.Drawing.Point(6, 71);
            this.rctDefeito.Name = "rctDefeito";
            this.rctDefeito.Size = new System.Drawing.Size(332, 169);
            this.rctDefeito.TabIndex = 3;
            this.rctDefeito.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Categoria: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Software",
            "Hardware"});
            this.comboBox1.Location = new System.Drawing.Point(81, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cód. erro:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 23);
            this.textBox1.TabIndex = 13;
            // 
            // btnBusca
            // 
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Image = global::Troubleshooter.Properties.Resources.bsc;
            this.btnBusca.Location = new System.Drawing.Point(185, 19);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(40, 40);
            this.btnBusca.TabIndex = 14;
            this.btnBusca.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(285, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 57);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções avançadas";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Enabled = false;
            this.btnAddUser.Location = new System.Drawing.Point(316, 22);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(95, 23);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Gravar técnico";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Nova solução";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Enabled = false;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Image = global::Troubleshooter.Properties.Resources.new_file;
            this.btnGerar.Location = new System.Drawing.Point(231, 19);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(40, 40);
            this.btnGerar.TabIndex = 16;
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(285, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(34, 15);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID: --";
            // 
            // lblCMDGEN
            // 
            this.lblCMDGEN.AutoSize = true;
            this.lblCMDGEN.Location = new System.Drawing.Point(426, 60);
            this.lblCMDGEN.Name = "lblCMDGEN";
            this.lblCMDGEN.Size = new System.Drawing.Size(92, 15);
            this.lblCMDGEN.TabIndex = 18;
            this.lblCMDGEN.Text = "CMD Gerável: --";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Solução permanente: --";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 335);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCMDGEN);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gboxSolucao);
            this.Controls.Add(this.gboxDefeito);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.gboxSolucao.ResumeLayout(false);
            this.gboxSolucao.PerformLayout();
            this.gboxDefeito.ResumeLayout(false);
            this.gboxDefeito.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gboxSolucao;
        private System.Windows.Forms.RichTextBox rctSolucao;
        private System.Windows.Forms.GroupBox gboxDefeito;
        private System.Windows.Forms.RichTextBox rctDefeito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Label lblCriador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCMDGEN;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddUser;
    }
}
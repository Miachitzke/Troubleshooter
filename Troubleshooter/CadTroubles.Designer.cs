
namespace Troubleshooter
{
    partial class frmCadTroubles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadTroubles));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txbCodErro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxSolucao = new System.Windows.Forms.GroupBox();
            this.rctSolucao = new System.Windows.Forms.RichTextBox();
            this.gboxProblema = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRsmProblema = new System.Windows.Forms.TextBox();
            this.rctDefeito = new System.Windows.Forms.RichTextBox();
            this.pnCMD = new System.Windows.Forms.Panel();
            this.btnCMDCancela = new System.Windows.Forms.Button();
            this.btnCMDSalvar = new System.Windows.Forms.Button();
            this.rctCMD = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCMD = new System.Windows.Forms.Button();
            this.chbSoluPerm = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.chbGenCMD = new System.Windows.Forms.CheckBox();
            this.gboxSolucao.SuspendLayout();
            this.gboxProblema.SuspendLayout();
            this.pnCMD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Troubleshooter.Properties.Resources.save;
            this.btnSalvar.Location = new System.Drawing.Point(249, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(40, 40);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txbCodErro
            // 
            this.txbCodErro.Location = new System.Drawing.Point(82, 41);
            this.txbCodErro.Name = "txbCodErro";
            this.txbCodErro.Size = new System.Drawing.Size(115, 23);
            this.txbCodErro.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cód. erro:";
            // 
            // gboxSolucao
            // 
            this.gboxSolucao.Controls.Add(this.rctSolucao);
            this.gboxSolucao.Location = new System.Drawing.Point(373, 110);
            this.gboxSolucao.Name = "gboxSolucao";
            this.gboxSolucao.Size = new System.Drawing.Size(355, 246);
            this.gboxSolucao.TabIndex = 23;
            this.gboxSolucao.TabStop = false;
            this.gboxSolucao.Text = "Solução";
            // 
            // rctSolucao
            // 
            this.rctSolucao.Location = new System.Drawing.Point(6, 76);
            this.rctSolucao.Name = "rctSolucao";
            this.rctSolucao.Size = new System.Drawing.Size(340, 170);
            this.rctSolucao.TabIndex = 2;
            this.rctSolucao.Text = "";
            // 
            // gboxProblema
            // 
            this.gboxProblema.Controls.Add(this.label4);
            this.gboxProblema.Controls.Add(this.label3);
            this.gboxProblema.Controls.Add(this.txbRsmProblema);
            this.gboxProblema.Controls.Add(this.rctDefeito);
            this.gboxProblema.Location = new System.Drawing.Point(12, 110);
            this.gboxProblema.Name = "gboxProblema";
            this.gboxProblema.Size = new System.Drawing.Size(355, 246);
            this.gboxProblema.TabIndex = 22;
            this.gboxProblema.TabStop = false;
            this.gboxProblema.Text = "Problema ";
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
            // txbRsmProblema
            // 
            this.txbRsmProblema.Location = new System.Drawing.Point(62, 22);
            this.txbRsmProblema.Name = "txbRsmProblema";
            this.txbRsmProblema.Size = new System.Drawing.Size(276, 23);
            this.txbRsmProblema.TabIndex = 4;
            // 
            // rctDefeito
            // 
            this.rctDefeito.Location = new System.Drawing.Point(5, 76);
            this.rctDefeito.Name = "rctDefeito";
            this.rctDefeito.Size = new System.Drawing.Size(340, 170);
            this.rctDefeito.TabIndex = 3;
            this.rctDefeito.Text = "";
            // 
            // pnCMD
            // 
            this.pnCMD.Controls.Add(this.btnCMDCancela);
            this.pnCMD.Controls.Add(this.btnCMDSalvar);
            this.pnCMD.Controls.Add(this.rctCMD);
            this.pnCMD.Controls.Add(this.label7);
            this.pnCMD.Location = new System.Drawing.Point(98, 19);
            this.pnCMD.Name = "pnCMD";
            this.pnCMD.Size = new System.Drawing.Size(500, 310);
            this.pnCMD.TabIndex = 34;
            this.pnCMD.Visible = false;
            // 
            // btnCMDCancela
            // 
            this.btnCMDCancela.Location = new System.Drawing.Point(270, 284);
            this.btnCMDCancela.Name = "btnCMDCancela";
            this.btnCMDCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCMDCancela.TabIndex = 3;
            this.btnCMDCancela.Text = "Cancelar";
            this.btnCMDCancela.UseVisualStyleBackColor = true;
            this.btnCMDCancela.Click += new System.EventHandler(this.btnCMDCancela_Click);
            // 
            // btnCMDSalvar
            // 
            this.btnCMDSalvar.Location = new System.Drawing.Point(171, 284);
            this.btnCMDSalvar.Name = "btnCMDSalvar";
            this.btnCMDSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnCMDSalvar.TabIndex = 2;
            this.btnCMDSalvar.Text = "Registrar";
            this.btnCMDSalvar.UseVisualStyleBackColor = true;
            this.btnCMDSalvar.Click += new System.EventHandler(this.btnCMDSalvar_Click);
            // 
            // rctCMD
            // 
            this.rctCMD.Location = new System.Drawing.Point(3, 32);
            this.rctCMD.Name = "rctCMD";
            this.rctCMD.Size = new System.Drawing.Size(494, 247);
            this.rctCMD.TabIndex = 1;
            this.rctCMD.Text = "";
            this.rctCMD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rctCMD_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(492, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Insira APENAS os comandos CMD no formato correto e separando por linha cada coman" +
    "do.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Categoria: ";
            // 
            // btnAddCMD
            // 
            this.btnAddCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCMD.Image = global::Troubleshooter.Properties.Resources.commandline;
            this.btnAddCMD.Location = new System.Drawing.Point(203, 19);
            this.btnAddCMD.Name = "btnAddCMD";
            this.btnAddCMD.Size = new System.Drawing.Size(40, 40);
            this.btnAddCMD.TabIndex = 0;
            this.btnAddCMD.UseVisualStyleBackColor = true;
            this.btnAddCMD.Click += new System.EventHandler(this.btnAddCMD_Click);
            // 
            // chbSoluPerm
            // 
            this.chbSoluPerm.AutoSize = true;
            this.chbSoluPerm.Location = new System.Drawing.Point(12, 70);
            this.chbSoluPerm.Name = "chbSoluPerm";
            this.chbSoluPerm.Size = new System.Drawing.Size(135, 19);
            this.chbSoluPerm.TabIndex = 32;
            this.chbSoluPerm.Text = "Solução permanente";
            this.chbSoluPerm.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(676, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 15);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Retornar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txbCategoria
            // 
            this.txbCategoria.Location = new System.Drawing.Point(82, 12);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(115, 23);
            this.txbCategoria.TabIndex = 34;
            // 
            // chbGenCMD
            // 
            this.chbGenCMD.AutoSize = true;
            this.chbGenCMD.Location = new System.Drawing.Point(153, 72);
            this.chbGenCMD.Name = "chbGenCMD";
            this.chbGenCMD.Size = new System.Drawing.Size(15, 14);
            this.chbGenCMD.TabIndex = 35;
            this.chbGenCMD.UseVisualStyleBackColor = true;
            this.chbGenCMD.Visible = false;
            // 
            // frmCadTroubles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 371);
            this.Controls.Add(this.pnCMD);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.chbSoluPerm);
            this.Controls.Add(this.btnAddCMD);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbCodErro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gboxSolucao);
            this.Controls.Add(this.gboxProblema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbGenCMD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadTroubles";
            this.Text = "Cadastro de incidentes";
            this.Load += new System.EventHandler(this.frmCadTroubles_Load);
            this.gboxSolucao.ResumeLayout(false);
            this.gboxProblema.ResumeLayout(false);
            this.gboxProblema.PerformLayout();
            this.pnCMD.ResumeLayout(false);
            this.pnCMD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txbCodErro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxSolucao;
        private System.Windows.Forms.RichTextBox rctSolucao;
        private System.Windows.Forms.GroupBox gboxProblema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbRsmProblema;
        private System.Windows.Forms.RichTextBox rctDefeito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCMD;
        private System.Windows.Forms.CheckBox chbSoluPerm;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pnCMD;
        private System.Windows.Forms.Button btnCMDCancela;
        private System.Windows.Forms.Button btnCMDSalvar;
        private System.Windows.Forms.RichTextBox rctCMD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.CheckBox chbGenCMD;
    }
}
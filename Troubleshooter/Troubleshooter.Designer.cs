
namespace Troubleshooter
{
    partial class frmCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.gboxCadastro = new System.Windows.Forms.GroupBox();
            this.pctVisib = new System.Windows.Forms.PictureBox();
            this.pctNoVisib = new System.Windows.Forms.PictureBox();
            this.txbFNome = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cxbUserAdmin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRepSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.dtgConsulta = new System.Windows.Forms.DataGridView();
            this.gboxCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVisib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNoVisib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(392, 297);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 19;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(311, 297);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 18;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // gboxCadastro
            // 
            this.gboxCadastro.Controls.Add(this.pctVisib);
            this.gboxCadastro.Controls.Add(this.pctNoVisib);
            this.gboxCadastro.Controls.Add(this.txbFNome);
            this.gboxCadastro.Controls.Add(this.txbUsuario);
            this.gboxCadastro.Controls.Add(this.label1);
            this.gboxCadastro.Controls.Add(this.btnGravar);
            this.gboxCadastro.Controls.Add(this.btnAtualizar);
            this.gboxCadastro.Controls.Add(this.label2);
            this.gboxCadastro.Controls.Add(this.cxbUserAdmin);
            this.gboxCadastro.Controls.Add(this.label3);
            this.gboxCadastro.Controls.Add(this.txbRepSenha);
            this.gboxCadastro.Controls.Add(this.label4);
            this.gboxCadastro.Controls.Add(this.txbSenha);
            this.gboxCadastro.Location = new System.Drawing.Point(12, 18);
            this.gboxCadastro.Name = "gboxCadastro";
            this.gboxCadastro.Size = new System.Drawing.Size(290, 171);
            this.gboxCadastro.TabIndex = 17;
            this.gboxCadastro.TabStop = false;
            this.gboxCadastro.Text = "Cadastro de usuário";
            // 
            // pctVisib
            // 
            this.pctVisib.Image = global::Troubleshooter.Properties.Resources.visible;
            this.pctVisib.Location = new System.Drawing.Point(228, 80);
            this.pctVisib.Name = "pctVisib";
            this.pctVisib.Size = new System.Drawing.Size(25, 25);
            this.pctVisib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVisib.TabIndex = 13;
            this.pctVisib.TabStop = false;
            this.pctVisib.Click += new System.EventHandler(this.pctVisib_Click);
            // 
            // pctNoVisib
            // 
            this.pctNoVisib.Image = global::Troubleshooter.Properties.Resources.not_visible;
            this.pctNoVisib.Location = new System.Drawing.Point(228, 80);
            this.pctNoVisib.Name = "pctNoVisib";
            this.pctNoVisib.Size = new System.Drawing.Size(25, 25);
            this.pctNoVisib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctNoVisib.TabIndex = 12;
            this.pctNoVisib.TabStop = false;
            this.pctNoVisib.Click += new System.EventHandler(this.pctNoVisib_Click);
            // 
            // txbFNome
            // 
            this.txbFNome.Location = new System.Drawing.Point(122, 22);
            this.txbFNome.Name = "txbFNome";
            this.txbFNome.Size = new System.Drawing.Size(158, 23);
            this.txbFNome.TabIndex = 0;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(122, 51);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(124, 23);
            this.txbUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome completo: ";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(142, 138);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(61, 23);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(211, 138);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(69, 23);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome usuário: ";
            // 
            // cxbUserAdmin
            // 
            this.cxbUserAdmin.AutoSize = true;
            this.cxbUserAdmin.Location = new System.Drawing.Point(15, 141);
            this.cxbUserAdmin.Name = "cxbUserAdmin";
            this.cxbUserAdmin.Size = new System.Drawing.Size(125, 19);
            this.cxbUserAdmin.TabIndex = 9;
            this.cxbUserAdmin.Text = "Admin de usuários";
            this.cxbUserAdmin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // txbRepSenha
            // 
            this.txbRepSenha.Location = new System.Drawing.Point(122, 109);
            this.txbRepSenha.Name = "txbRepSenha";
            this.txbRepSenha.PasswordChar = '●';
            this.txbRepSenha.Size = new System.Drawing.Size(100, 23);
            this.txbRepSenha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Repetir senha:";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(122, 80);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '●';
            this.txbSenha.Size = new System.Drawing.Size(100, 23);
            this.txbSenha.TabIndex = 7;
            // 
            // dtgConsulta
            // 
            this.dtgConsulta.AllowUserToAddRows = false;
            this.dtgConsulta.AllowUserToDeleteRows = false;
            this.dtgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsulta.Location = new System.Drawing.Point(308, 18);
            this.dtgConsulta.Name = "dtgConsulta";
            this.dtgConsulta.ReadOnly = true;
            this.dtgConsulta.RowTemplate.Height = 25;
            this.dtgConsulta.Size = new System.Drawing.Size(398, 269);
            this.dtgConsulta.TabIndex = 16;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 338);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.gboxCadastro);
            this.Controls.Add(this.dtgConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.Text = "Cadastro de técnicos";
            this.gboxCadastro.ResumeLayout(false);
            this.gboxCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVisib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNoVisib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.GroupBox gboxCadastro;
        private System.Windows.Forms.PictureBox pctVisib;
        private System.Windows.Forms.PictureBox pctNoVisib;
        private System.Windows.Forms.TextBox txbFNome;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cxbUserAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbRepSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.DataGridView dtgConsulta;
    }
}


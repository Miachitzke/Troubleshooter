
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
            this.lblCMDGEN = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddINC = new System.Windows.Forms.Button();
            this.lblDefTbs = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cxbChaveBSC = new System.Windows.Forms.ComboBox();
            this.txbBusca = new System.Windows.Forms.TextBox();
            this.dtgBusca = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCMDGEN
            // 
            this.lblCMDGEN.AutoSize = true;
            this.lblCMDGEN.Location = new System.Drawing.Point(191, 57);
            this.lblCMDGEN.Name = "lblCMDGEN";
            this.lblCMDGEN.Size = new System.Drawing.Size(82, 15);
            this.lblCMDGEN.TabIndex = 18;
            this.lblCMDGEN.Text = "CMD Gerável: ";
            // 
            // btnGerar
            // 
            this.btnGerar.Enabled = false;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Image = global::Troubleshooter.Properties.Resources.codegen;
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGerar.Location = new System.Drawing.Point(343, 12);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(40, 40);
            this.btnGerar.TabIndex = 16;
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            this.btnGerar.MouseHover += new System.EventHandler(this.btnGerar_MouseHover);
            // 
            // btnBusca
            // 
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Image = global::Troubleshooter.Properties.Resources.bsc;
            this.btnBusca.Location = new System.Drawing.Point(297, 12);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(40, 40);
            this.btnBusca.TabIndex = 14;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            this.btnBusca.MouseHover += new System.EventHandler(this.btnBusca_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.btnAddINC);
            this.groupBox1.Location = new System.Drawing.Point(403, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 57);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções avançadas";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Enabled = false;
            this.btnAddUser.Location = new System.Drawing.Point(151, 22);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(95, 23);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Gravar técnico";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddINC
            // 
            this.btnAddINC.Location = new System.Drawing.Point(6, 22);
            this.btnAddINC.Name = "btnAddINC";
            this.btnAddINC.Size = new System.Drawing.Size(139, 23);
            this.btnAddINC.TabIndex = 0;
            this.btnAddINC.Text = "Registrar  solução";
            this.btnAddINC.UseVisualStyleBackColor = true;
            this.btnAddINC.Click += new System.EventHandler(this.btnAddINC_Click);
            // 
            // lblDefTbs
            // 
            this.lblDefTbs.AutoSize = true;
            this.lblDefTbs.Location = new System.Drawing.Point(12, 57);
            this.lblDefTbs.Name = "lblDefTbs";
            this.lblDefTbs.Size = new System.Drawing.Size(125, 15);
            this.lblDefTbs.TabIndex = 7;
            this.lblDefTbs.Text = "Solução permanente:  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Filtrar por: ";
            // 
            // cxbChaveBSC
            // 
            this.cxbChaveBSC.FormattingEnabled = true;
            this.cxbChaveBSC.Items.AddRange(new object[] {
            "Resumo do Problema",
            "Problema",
            "Categoria",
            "Código do erro",
            "Solução",
            "Criador por"});
            this.cxbChaveBSC.Location = new System.Drawing.Point(82, 22);
            this.cxbChaveBSC.Name = "cxbChaveBSC";
            this.cxbChaveBSC.Size = new System.Drawing.Size(103, 23);
            this.cxbChaveBSC.TabIndex = 22;
            // 
            // txbBusca
            // 
            this.txbBusca.Location = new System.Drawing.Point(191, 22);
            this.txbBusca.Name = "txbBusca";
            this.txbBusca.Size = new System.Drawing.Size(100, 23);
            this.txbBusca.TabIndex = 23;
            // 
            // dtgBusca
            // 
            this.dtgBusca.AllowUserToAddRows = false;
            this.dtgBusca.AllowUserToDeleteRows = false;
            this.dtgBusca.AllowUserToOrderColumns = true;
            this.dtgBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBusca.Location = new System.Drawing.Point(2, 86);
            this.dtgBusca.Name = "dtgBusca";
            this.dtgBusca.ReadOnly = true;
            this.dtgBusca.RowTemplate.Height = 25;
            this.dtgBusca.Size = new System.Drawing.Size(709, 246);
            this.dtgBusca.TabIndex = 24;
            this.dtgBusca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBusca_CellContentClick);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::Troubleshooter.Properties.Resources.logout1;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(662, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(40, 40);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseHover += new System.EventHandler(this.btnLogout_MouseHover);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 335);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dtgBusca);
            this.Controls.Add(this.txbBusca);
            this.Controls.Add(this.lblCMDGEN);
            this.Controls.Add(this.cxbChaveBSC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblDefTbs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBusca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblCMDGEN;
        private System.Windows.Forms.Button btnAddINC;
        private System.Windows.Forms.Label lblDefTbs;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cxbChaveBSC;
        private System.Windows.Forms.TextBox txbBusca;
        private System.Windows.Forms.DataGridView dtgBusca;
        private System.Windows.Forms.Button btnLogout;
    }
}
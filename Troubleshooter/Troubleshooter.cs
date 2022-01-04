using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Troubleshooter.CLS;
using Troubleshooter.Model;

namespace Troubleshooter
{    
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        private bool verifSenha(string senha, string confSenha)
        {
            if (senha.Equals(confSenha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from usuarios";

            DataTable dt = new DataTable();

            dt = bd.executarConsulta(sql);

            dtgConsulta.DataSource = dt;
            this.dtgConsulta.Columns["senha"].Visible = false;
            this.dtgConsulta.Columns["dt_cadastro"].Visible = false;
            this.dtgConsulta.Columns["adm_user"].Visible = false;
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            int adm = 0;
            if (cxbUserAdmin.Checked) { adm = 1; }
            if (verifSenha(txbSenha.Text, txbRepSenha.Text)){
            
            controle.user = txbUsuario.Text;
            controle.nome = txbFNome.Text;
            controle.senha = txbSenha.Text;
            controle.dt_cadastro = DateTime.Now.ToString();
            controle.tbs_criados = 0;
            controle.adm_user = adm;
            }
            else
            {
                MessageBox.Show("As senhas fornecidas não conferem! Verifique e tente novamente.");
            }


            bool retorno = controle.gravarUsuario();
            if (retorno)
            {
                MessageBox.Show("Gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao gravar!");
            }
        }

        private void pctVisib_Click(object sender, EventArgs e)
        {
            if (txbSenha.PasswordChar == '●')
            {
                pctNoVisib.BringToFront();
                txbSenha.PasswordChar = '\0';
                txbRepSenha.PasswordChar = '\0';
            }
        }

        private void pctNoVisib_Click(object sender, EventArgs e)
        {
            if (txbSenha.PasswordChar == '\0')
            {
                pctVisib.BringToFront();
                txbSenha.PasswordChar = '●';
                txbRepSenha.PasswordChar = '●';
            }
        }
    }
}

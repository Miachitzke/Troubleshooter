using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using Troubleshooter.Model;

namespace Troubleshooter
{    
    public partial class frmCadastro : Form
    {

        Thread frm1;
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
            _ = new DataTable();

            DataTable dt = bd.executarConsulta(sql);

            dtgConsulta.DataSource = dt;
            this.dtgConsulta.Columns["senha"].Visible = false;
            this.dtgConsulta.Columns["dt_cadastro"].Visible = false;
            this.dtgConsulta.Columns["adm_user"].Visible = false;
            dtgConsulta.Columns["id"].HeaderText = "User ID";
            dtgConsulta.Columns["usuario"].HeaderText = "Usuário";
            dtgConsulta.Columns["nome"].HeaderText = "Nome completo";
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
            limpaCampos();
            btnConsulta_Click(sender, e);
        }

        private void limpaCampos()
        {
            txbFNome.Text = "";
            txbUsuario.Text = "";
            txbSenha.Text = "";
            txbRepSenha.Text = "";
            cxbUserAdmin.Checked = false;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.id = int.Parse(txbID.Text);

            controle = controle.consultaUsuario(controle.id);
            
            if (controle == null)
            {
                MessageBox.Show("Erro ao excluir: O usuário não foi encontrado (404)!");
                return;
            }

            bool retorno = controle.excluirUsuario();

            if (retorno == true)
            {
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao executar a exclusão!");
            }
            txbID.Text = "";
            btnConsulta_Click(sender, e);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frm1 = new Thread(Controle.abreConsulta);

            frm1.SetApartmentState(ApartmentState.STA);
            frm1.Start();
        }
    }
}
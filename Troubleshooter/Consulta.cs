using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using Troubleshooter.CLS;
using Troubleshooter.Model;

namespace Troubleshooter
{
    public partial class frmConsulta : Form
    {
        Thread frm1;
        GlobalVar gv = new();
        ControleINC ctrlINC = new();
        Banco bd = new();
        SqlDataReader dr;
        DataTable dt = new();
        string chave_bsc;
        public frmConsulta()
        {
            InitializeComponent();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
                this.Close();
                frm1 = new Thread(Controle.abreCadUser);

                frm1.SetApartmentState(ApartmentState.STA);
                frm1.Start();            
        }
        private void frmConsulta_Load(object sender, EventArgs e)
        {
            btnAddUser.Enabled = gv.vld;            
        }
        private void consultaGenerica()
        {
            SqlConnection cn = bd.Conectar();
            SqlCommand command = new SqlCommand("select probl_conhecidos.rsm_problema,problema,cat_problema,cod_erro,troubleshoot,tbs_definitiva,tbs_console,cod_console, usuarios.nome" +
                    " from probl_conhecidos, usuarios where usuarios.id = probl_conhecidos.fk_usuario", cn);
            dr = command.ExecuteReader();            
            dt.Load(dr);

        }    
        private void btnAddINC_Click(object sender, EventArgs e)
        {
            this.Close();
            frm1 = new Thread(Controle.abreTBS);

            frm1.SetApartmentState(ApartmentState.STA);
            frm1.Start();
        }
        private void btnBusca_Click(object sender, EventArgs e)
        {//inserir breakpoint se der erro na busca
            dt.Clear();
            gv.dt.Clear();
            if (cxbChaveBSC.Text.Equals("") && txbBusca.Text.Equals(""))
            {
                consultaGenerica();
                dtgBusca.DataSource = this.dt;

            }
            else
            {
                selectChave(cxbChaveBSC.Text);
                ctrlINC.consultaProblemas(chave_bsc, txbBusca.Text);
                dtgBusca.DataSource = gv.dt;
            }
            dtgBusca.Columns["id"].Visible = false;
            dtgBusca.Columns["tbs_definitiva"].Visible = false;
            dtgBusca.Columns["tbs_console"].Visible = false;
            dtgBusca.Columns["fk_usuario"].Visible = false;
        }

        public void selectChave(string Chave)
        {
            switch (Chave)
            {
                case "Resumo do Problema": chave_bsc ="rsm_problema" ;break;
                case "Problema": chave_bsc = "problema"; break;
                case "Categoria": chave_bsc = "cat_problema"; break;
                case "Código do erro": chave_bsc = "cod_erro"; break;
                case "Solução": chave_bsc = "troubleshoot"; break;
                case "Criador por": chave_bsc = "fk_usuario"; break;

            }
        }
    }
}

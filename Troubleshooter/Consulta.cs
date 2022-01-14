using System;
using System.IO;
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
        string COMMA;
        string nmBAT;
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
            dtgBusca.Columns["tbs_definitiva"].Visible = false;
            dtgBusca.Columns["tbs_console"].Visible = false;
            dtgBusca.Columns["rsm_problema"].HeaderText = "Resumo";
            dtgBusca.Columns["problema"].HeaderText = "Problema detalhado";
            dtgBusca.Columns["cat_problema"].HeaderText = "Categoria";
            dtgBusca.Columns["cod_erro"].HeaderText = "Código do erro";
            dtgBusca.Columns["troubleshoot"].HeaderText = "Solução";
            dtgBusca.Columns["cod_console"].HeaderText = "Linhas de código";
            dtgBusca.Columns["nome"].HeaderText = "Registrado por";
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

        private void dtgBusca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nmBAT = dtgBusca.CurrentRow.Cells[3].FormattedValue.ToString();
            string def_tbs = dtgBusca.CurrentRow.Cells[5].FormattedValue.ToString();
            string cmd_gen = dtgBusca.CurrentRow.Cells[6].FormattedValue.ToString();
            COMMA = dtgBusca.CurrentRow.Cells[7].FormattedValue.ToString();
            if (def_tbs == "1") { lblDefTbs.Text = "Solução permanente: Sim"; } else { lblDefTbs.Text = "Solução permanente: Não"; }
            if (cmd_gen == "1") 
            { 
                lblCMDGEN.Text = "CMD Gerável: Sim";
                btnGerar.Enabled = true;
            } 
            else
            { 
                lblCMDGEN.Text = "CMD Gerável: Não";
                btnGerar.Enabled = false;
            }

        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarBAT();
            MessageBox.Show("Solução gerada com sucesso.");
        }

        private void GerarBAT()
        {
            verfDir();
            try
            {

                StreamWriter sw = new StreamWriter("C:\\Temp\\Fix "+ nmBAT +".bat");                
                sw.WriteLine(COMMA);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void verfDir()
        {
            string path = @"c:\Temp";
           
                if (!Directory.Exists(path))
                {
                Directory.CreateDirectory("C:\\Temp");
                }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            gv.limpaVar();
            this.Close();
            frm1 = new Thread(abreAuth);            
            frm1.SetApartmentState(ApartmentState.STA);
            frm1.Start();
        }

        private void abreAuth(object obj)
        {
            Application.Run(new frmAuth());
        }

        private void btnBusca_MouseHover(object sender, EventArgs e)
        {
            ToolTip ttp = new();
            ttp.SetToolTip(btnBusca, "Buscar");
        }

        private void btnGerar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ttp = new();
            ttp.SetToolTip(btnGerar, "Gerar script");
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            ToolTip ttp = new();
            ttp.SetToolTip(btnLogout, "Desconectar");
        }
    }
}

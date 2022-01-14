using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Troubleshooter.Model;
using Troubleshooter.CLS;

namespace Troubleshooter
{
    public partial class frmCadTroubles : Form
    {

        Login login = new Login();
        Thread frm1;
        public frmCadTroubles()
        {
            InitializeComponent();
        }

        string rsm_problema; //not null
        string problema; //not null
        string cat_problema; //not null
        string cod_erro; //not null
        string troubleshoot; //not null        
        int tbs_definitiva; //not null
        int tbs_console; //not null
        string cod_console;

        ControleINC CSTINC = new ControleINC();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frm1 = new Thread(Controle.abreConsulta);

            frm1.SetApartmentState(ApartmentState.STA);
            frm1.Start();
        }
        private void chbGenCMD_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGenCMD.Checked) { btnAddCMD_Click(sender, e); }
            if(!chbGenCMD.Checked) { btnCMDCancela_Click(sender, e); }
        }
        private void btnAddCMD_Click(object sender, EventArgs e)
        {
            chbGenCMD.Checked =true;
            pnCMD.Visible = true;
        }
        private void btnCMDCancela_Click(object sender, EventArgs e)
        {
            chbGenCMD.Checked = false;
            this.cod_console = "";
            pnCMD.Visible = false;
        }
        private void btnCMDSalvar_Click(object sender, EventArgs e)
        {
            if(rctCMD.Text == "") 
            { 
                MessageBox.Show("A lista de comandos não pode estar vazia!"); } 
            else
            {
            cod_console = rctCMD.Text;
                pnCMD.Visible = false;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            atribuiCampos();
             CSTINC.rsm_problema = this.rsm_problema;
             CSTINC.problema = this.problema;
             CSTINC.cat_problema = this.cat_problema;
             CSTINC.cod_erro = this.cod_erro;
             CSTINC.troubleshoot = this.troubleshoot;
             CSTINC.tbs_definitiva = this.tbs_definitiva;
             CSTINC.tbs_console = this.tbs_console; 
             CSTINC.cod_console = this.cod_console;

            bool retorno = CSTINC.gravarINC();
            if (retorno)
            {
                MessageBox.Show("Gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao gravar!");
            }
            limpaCampos();

        }

        private void limpaCampos()
        {
            rctCMD.Clear();
            rctDefeito.Clear();
            rctSolucao.Clear();
            txbCategoria.Clear();
            txbCodErro.Clear();
            txbRsmProblema.Clear();
            chbGenCMD.Checked = false;
            chbSoluPerm.Checked = false;
        }

        private void atribuiCampos()
        {
            if (verfCampos(txbRsmProblema.Text)) { rsm_problema = txbRsmProblema.Text; }
            if (verfCampos(rctDefeito.Text)) { problema = rctDefeito.Text; }
            if (verfCampos(txbCategoria.Text)) { cat_problema = txbCategoria.Text; }
            if (verfCampos(txbCodErro.Text)) { cod_erro = txbCodErro.Text; }
            if (verfCampos(rctSolucao.Text)) { troubleshoot = rctSolucao.Text; }
            if (chbSoluPerm.Checked) { tbs_definitiva = 1; }
            if (chbGenCMD.Checked) { tbs_console = 1; }
            cod_console = rctCMD.Text;
            
        }

        private bool verfCampos(string campo)
        {
            campo = campo.Trim();
            if (campo.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmCadTroubles_Load(object sender, EventArgs e)
        {            
        }

        private void rctCMD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCMDSalvar_Click(sender, e);
            }
        }

        private void btnAddCMD_MouseHover(object sender, EventArgs e)
        {
            ToolTip ttp = new();
            ttp.SetToolTip(btnAddCMD, "Registrar comandos DOS");
        }

        private void btnSalvar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ttp = new();
            ttp.SetToolTip(btnSalvar, "Registrar incidente");
        }
    }
}

using System;
using System.Threading;
using System.Windows.Forms;
using Troubleshooter.Model;

namespace Troubleshooter
{
    public partial class frmAuth : Form
    {
        Thread frm1;
        public frmAuth()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acesso(txbUsuario.Text, txbSenha.Text);

            if (controle.tm)
            {
                this.Close();                
                frm1 = new Thread(Controle.abreConsulta);
                
                frm1.SetApartmentState(ApartmentState.STA);
                frm1.Start();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto! Verifique os dados e tente novamente.");
                txbUsuario.Text = "";
                txbSenha.Text = "";
                txbUsuario.Select();
            }

        }
        private void txbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (e.KeyChar == 13)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void btnEntrar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ttp = new();
            ttp.SetToolTip(btnEntrar, "Acessar");
        }
    }
}

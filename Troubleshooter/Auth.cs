using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Troubleshooter.CLS;
using Troubleshooter.Model;

namespace Troubleshooter
{
    public partial class frmAuth : Form
    {
        public bool admUser = false;

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
                frm1 = new Thread(abreConsulta);

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

        private void abreConsulta(object obj)
        {
            Application.Run(new frmConsulta());
        }

        private void txbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (e.KeyChar == 13)
            {
                btnEntrar_Click(sender, e);
            }            
        }
    }
}

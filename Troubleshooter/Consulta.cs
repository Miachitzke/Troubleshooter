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

namespace Troubleshooter
{
    public partial class frmConsulta : Form
    {

        Thread frm1;
        Login login = new Login();        
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            
            if (login.vld)
            {
                this.Close();
                frm1 = new Thread(abreTBS);

                frm1.SetApartmentState(ApartmentState.STA);
                frm1.Start();
            }
        }

        private void abreTBS(object obj)
        {
            Application.Run(new frmCadastro());
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            if (login.vld) { btnAddUser.Enabled = true; }
        }
    }

}

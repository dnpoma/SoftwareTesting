using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Domain;

namespace Presentation
{
    public partial class FormRecoverPassword : Form
    {
        public FormRecoverPassword()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.recoverPassword(txtUserRequest.Text);
            lblResult.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var recoverPassword = new frmRecuperarContra();
            recoverPassword.ShowDialog();
            this.Close();
            this.Opacity = 0.0;
        }

        private void FormRecoverPassword_Load(object sender, EventArgs e)
        {

        }
    }
}

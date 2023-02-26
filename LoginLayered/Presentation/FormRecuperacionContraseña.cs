using Common.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmRecuperarContra : Form
    {
        public frmRecuperarContra()
        {
            InitializeComponent();
        }
        int val = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            val += 1;
            if (val == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value==100)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void frmRecuperarContra_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            UserLoginCache.RecPassword = "ASz";
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtPassOld.Text == UserLoginCache.RecPassword)
            {
                this.Opacity = 0.0;
                this.Close();
                var recoverPassword = new FormNuevaContraseña();
                recoverPassword.ShowDialog();
            }
            else
            {
                MessageBox.Show("La contraseña temporal no coincide con la enviada");
            }
        }
    }
}





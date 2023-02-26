using Common.Cache;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormNuevaContraseña : Form
    {
        public FormNuevaContraseña()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar la aplicación?" +
                "\nSe perderán los datos almacenados", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void txtPassOld_Enter(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(txtNewPassword.Text!="" && txtConfirmNewP.Text != "")
            {
                if (txtNewPassword.Text == txtConfirmNewP.Text)
                {
                    string pass = txtNewPassword.Text;
                    UserModel us = new UserModel();
                    var result = us.saveNewPassword(UserLoginCache.IdUser, pass, UserLoginCache.Email);
                    MessageBox.Show(result);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Campos vacíos");
            }
        }

        private void txtConfirmNewP_Enter(object sender, EventArgs e)
        {
            txtConfirmNewP.UseSystemPasswordChar = true;
        }
    }
}

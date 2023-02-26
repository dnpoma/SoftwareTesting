using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
using Common.Cache;

namespace Presentation
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if(txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if(txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtuser.Text != "USUARIO")
            {
                if(txtpass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                            this.Hide();
                            FormWelcome welcome = new FormWelcome();
                            welcome.ShowDialog();
                            FormPrincipal mainMenu = new FormPrincipal();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                    }
                    else
                    {
                        msgError("Nombre de usuario o contraseña incorrectos. \n       Intenta de nuevo");
                        txtpass.UseSystemPasswordChar = false;
                        txtpass.Text = "CONTRASEÑA";
                        txtuser.Focus();
                    }
                }
                else
                {
                    msgError("Por favor, ingrese su contraseña");
                }
            }
            else
            {
                msgError("Por favor, ingrese su nombre de usuario.");
            }
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = "       " + msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.UseSystemPasswordChar = false;
            txtpass.Text = "CONTRASEÑA";
            txtuser.Text = "USUARIO";
            lblErrorMessage.Visible = false;
            this.Show();
            //txtuser.Focus();
        }

        private void lnkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new FormRecoverPassword();
            recoverPassword.ShowDialog();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
           // FormRegistrar formRegistrar = new FormRegistrar();
           // formRegistrar.Show();
            FormRegistrarDos formRegistrarDos = new FormRegistrarDos();
            formRegistrarDos.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shapeContainer1_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

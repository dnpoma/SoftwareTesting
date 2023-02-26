using Common.Cache;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Security.Cryptography;

namespace Presentation
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar la aplicación?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserLoginCache.Captcha = false;
            var captcha = new FormCaptcha();
            captcha.ShowDialog();
            if (UserLoginCache.Captcha == true)
            {
                UserModel user = new UserModel();
                string lastUserId = user.obtainLastId();
                int lastUserIdInt = int.Parse(lastUserId);
                lastUserIdInt = lastUserIdInt + 1;

                int val = 0;
                string valStr = "";
                if (rdbSi.Checked)
                {
                    val = 1;
                    valStr = val.ToString();
                }
                else if (rdbNo.Checked)
                {
                    val = 0;
                    valStr = val.ToString();
                }

                if (lastUserIdInt < 10)
                {
                    lastUserId = "00000" + lastUserIdInt.ToString();
                }
                else
                {
                    lastUserId = "0000" + lastUserIdInt.ToString();
                }

                var userModel = new UserModel(
                                idUser: lastUserId,
                                name: txtNombre.Text,
                                lastName: txtApellido.Text,
                                address: txtDirección.Text,
                                phone: txtTelefono.Text,
                                email: txtMail.Text,
                                dni: txtCedula.Text,
                                dateBirth: dateTimePicker1.Value,
                                dateAdmission: dateTimePicker1.Value,
                                dateDeparture: dateTimePicker1.Value,
                                photo: lblPhoto.Text,
                                carFarm: 100,
                                passport: txtPassport.Text,
                                discapacity: valStr,
                                password: "");
                var result = userModel.saveUser();
                MessageBox.Show(result);
                
                var recoverPassword = new frmRecuperarContra();
                recoverPassword.ShowDialog();

                FormLogin frmLogin = new FormLogin();

                this.Close();
                frmLogin.Show();
            }
            else
            {
                MessageBox.Show("Error en autenticación Captcha");
            }
            //panel1.Visible = false;
        }
        private void btnUploadPhoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\Users\\kenne";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                ptrBPhotoEdit.ImageLocation = getImage.FileName;
                string name = Path.GetFileNameWithoutExtension(getImage.FileName) + "_" +
                    DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss") +
                    Path.GetExtension(getImage.FileName);
                lblPhoto.Text = name;
                string directory = Path.Combine(Application.StartupPath, "Imgs");
                File.Copy(getImage.FileName, Path.Combine(directory, name));
            }
            else
            {
                MessageBox.Show("No se selecciono imagen", "sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtPassOld_Enter(object sender, EventArgs e)
        {
        }
    }
}

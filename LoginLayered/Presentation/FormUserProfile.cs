using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentation
{
    public partial class FormUserProfile : Form
    {
        public FormUserProfile()
        {
            InitializeComponent();
        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {
            loadUserData();
            initializePassEditControls();
        }
        private void loadUserData()
        {
            string directory = Path.Combine(Application.StartupPath, "Imgs");
            //View
            lblDni.Text = UserLoginCache.Dni;
            lblName.Text = UserLoginCache.Name;
            lblMail.Text = UserLoginCache.Email;
           // lblPosition.Text = UserLoginCache.Position;
            ptrBPhoto.ImageLocation = Path.Combine(directory, UserLoginCache.Photo);
            lblPhone.Text = UserLoginCache.Phone;

            //Edit Panel
            txtName.Text = UserLoginCache.Name;
            txtMail.Text = UserLoginCache.Email;
            lblPhoto.Text = UserLoginCache.Photo;
            ptrBPhotoEdit.ImageLocation = Path.Combine(directory, UserLoginCache.Photo);
            txtPhone.Text = UserLoginCache.Phone;
            txtPass.Text = UserLoginCache.Password;
            txtPassRw.Text = UserLoginCache.Password;
            txtPassOld.Text = "";
        }
        private void initializePassEditControls()
        {
            lnklblEditPass.Text = "Editar";
            txtPass.Enabled = false;
            txtPass.UseSystemPasswordChar = true;
            txtPassRw.Enabled = false;
            txtPassRw.UseSystemPasswordChar = true;
            txtPassOld.UseSystemPasswordChar = true;
        }
        private void reset()
        {
            loadUserData();
            initializePassEditControls();
        }

        private void lnklblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            loadUserData();
        }

        private void lnklblEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lnklblEditPass.Text == "Editar")
            {
                lnklblEditPass.Text = "Cancelar";
                txtPass.Enabled = true;
                txtPass.Text = "";
                txtPassRw.Enabled = true;
                txtPassRw.Text = "";
            }
            else if(lnklblEditPass.Text == "Cancelar")
            {
                initializePassEditControls();
                txtPass.Text = UserLoginCache.Password;
                txtPassRw.Text = UserLoginCache.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPass.Text.Length >= 1)
            {
                if (txtPass.Text == txtPassRw.Text)
                {
                    if (txtPassOld.Text == UserLoginCache.Password)
                    {
                        var userModel = new UserModel(
                            idUser: UserLoginCache.IdUser,
                            name: txtName.Text,
                            password: txtPass.Text,
                            photo: lblPhoto.Text,
                            //  position: UserLoginCache.Position,
                            // department: UserLoginCache.Department,
                            email: txtMail.Text,
                            dni: UserLoginCache.Dni,
                            phone: txtPhone.Text);
                        var result = userModel.editUserProfile();
                        MessageBox.Show(result);
                        reset();
                        panel1.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña actual incorrecta, intenta nuevamente");
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden, intenta nuevamente");
                }
            }
            else
                MessageBox.Show("La contraseña debe ser de al menos 1 caracter");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            reset();
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
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

        private void txtPassOld_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}

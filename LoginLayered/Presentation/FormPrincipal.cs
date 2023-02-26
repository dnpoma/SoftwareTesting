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
using Common.Cache;
using System.IO;

namespace Presentation
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro de cerrar la aplicación?","Warning",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormualrio<FormBienes>();
            btnBienes.BackColor = Color.FromArgb(12, 61, 92);
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        #endregion
        //Metodos para abrir formularios dentro del panel
        private void AbrirFormualrio<miForm>()where miForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<miForm>().FirstOrDefault();//Busca en la coleccion el formulario
            //si el formualario instancia no existe
            if (formulario == null)
            {
                formulario = new miForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            ManagePermissions();
        }
        private void ManagePermissions()
        {
            //Manage Permissions
           /* if (UserLoginCache.Department == Departments.Compras)
            {
                btnAlmacen.Enabled = false;
            }
            if (UserLoginCache.Department == Departments.Almacen)
            {
                btnCompras.Enabled = false;
            }
            if (UserLoginCache.Department == Departments.RRHH)
            {
                btnCompras.Enabled = false;
                btnAlmacen.Enabled = false;
            }*/
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormualrio<FormCompras>();
            btnCompras.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            AbrirFormualrio<FormAlmacen>();
            btnAlmacen.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void lnklblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormualrio<FormUserProfile>();
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
                btnBienes.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void LoadUserData()
        {
            string directory = Path.Combine(Application.StartupPath, "Imgs");
            lblName.Text = UserLoginCache.Name;
            //lblPosition.Text = UserLoginCache.Position;
            lblEmail.Text = UserLoginCache.Email;
            ptrBMiniPhoto.ImageLocation = Path.Combine(directory, UserLoginCache.Photo);
        }

    }
}

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
    public partial class FormCaptcha : Form
    {
        public FormCaptcha()
        {
            InitializeComponent();
            LoadCaptchaImage();
        }
        int number = 0;

        private void FormCaptcha_Load(object sender, EventArgs e)
        {

        }

        private void LoadCaptchaImage()
        {
            Random random = new Random();
            number = random.Next(100,10000);
            var image = new Bitmap(this.pcbxNumber.Width, this.pcbxNumber.Height);
            var font = new Font("TimesNewRoman",25,FontStyle.Bold,GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(number.ToString(), font, Brushes.Blue, new Point(0,0));
            pcbxNumber.Image = image;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadCaptchaImage();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerific_Click(object sender, EventArgs e)
        {
            if(txtValueVerific.Text == number.ToString())
            {
                UserLoginCache.Captcha = true;
            }
            else
            {
                UserLoginCache.Captcha = false;
            }
            this.Close();
        }
    }
}

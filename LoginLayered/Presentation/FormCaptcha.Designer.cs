namespace Presentation
{
    partial class FormCaptcha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbxNumber = new System.Windows.Forms.PictureBox();
            this.btnVerific = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtValueVerific = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 46);
            this.panel1.TabIndex = 0;
            // 
            // pcbxNumber
            // 
            this.pcbxNumber.Location = new System.Drawing.Point(29, 73);
            this.pcbxNumber.Name = "pcbxNumber";
            this.pcbxNumber.Size = new System.Drawing.Size(261, 53);
            this.pcbxNumber.TabIndex = 1;
            this.pcbxNumber.TabStop = false;
            // 
            // btnVerific
            // 
            this.btnVerific.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVerific.FlatAppearance.BorderSize = 0;
            this.btnVerific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerific.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerific.ForeColor = System.Drawing.Color.White;
            this.btnVerific.Location = new System.Drawing.Point(29, 225);
            this.btnVerific.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerific.Name = "btnVerific";
            this.btnVerific.Size = new System.Drawing.Size(426, 28);
            this.btnVerific.TabIndex = 24;
            this.btnVerific.Text = "Verificar";
            this.btnVerific.UseVisualStyleBackColor = false;
            this.btnVerific.Click += new System.EventHandler(this.btnVerific_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(339, 87);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(116, 39);
            this.btnReload.TabIndex = 25;
            this.btnReload.Text = "Reiniciar";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(339, 153);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 36);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtValueVerific
            // 
            this.txtValueVerific.Location = new System.Drawing.Point(29, 167);
            this.txtValueVerific.Margin = new System.Windows.Forms.Padding(4);
            this.txtValueVerific.Name = "txtValueVerific";
            this.txtValueVerific.Size = new System.Drawing.Size(261, 22);
            this.txtValueVerific.TabIndex = 52;
            // 
            // FormCaptcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(468, 276);
            this.Controls.Add(this.txtValueVerific);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnVerific);
            this.Controls.Add(this.pcbxNumber);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaptcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCaptcha";
            this.Load += new System.EventHandler(this.FormCaptcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbxNumber;
        private System.Windows.Forms.Button btnVerific;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtValueVerific;
    }
}
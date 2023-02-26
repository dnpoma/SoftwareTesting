namespace Presentation
{
    partial class FormRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.ptrBPhotoEdit = new System.Windows.Forms.PictureBox();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.lblPassport = new System.Windows.Forms.Label();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.lblDiscapacity = new System.Windows.Forms.Label();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBPhotoEdit)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.lblPhoto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnUploadPhoto);
            this.panel1.Controls.Add(this.ptrBPhotoEdit);
            this.panel1.Controls.Add(this.txtPassport);
            this.panel1.Controls.Add(this.lblPassport);
            this.panel1.Controls.Add(this.rdbNo);
            this.panel1.Controls.Add(this.rdbSi);
            this.panel1.Controls.Add(this.lblDiscapacity);
            this.panel1.Controls.Add(this.lblDateBirth);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.txtDirección);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblRegister);
            this.panel1.Location = new System.Drawing.Point(-11, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 893);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.ForeColor = System.Drawing.Color.White;
            this.lblPhoto.Location = new System.Drawing.Point(33, 393);
            this.lblPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(0, 20);
            this.lblPhoto.TabIndex = 62;
            this.lblPhoto.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 373);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Foto:";
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPhoto.Location = new System.Drawing.Point(39, 417);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(110, 40);
            this.btnUploadPhoto.TabIndex = 60;
            this.btnUploadPhoto.Text = "Examinar";
            this.btnUploadPhoto.UseVisualStyleBackColor = false;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click_1);
            // 
            // ptrBPhotoEdit
            // 
            this.ptrBPhotoEdit.Location = new System.Drawing.Point(196, 373);
            this.ptrBPhotoEdit.Name = "ptrBPhotoEdit";
            this.ptrBPhotoEdit.Size = new System.Drawing.Size(178, 117);
            this.ptrBPhotoEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrBPhotoEdit.TabIndex = 59;
            this.ptrBPhotoEdit.TabStop = false;
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(264, 653);
            this.txtPassport.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(173, 22);
            this.txtPassport.TabIndex = 58;
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassport.ForeColor = System.Drawing.Color.White;
            this.lblPassport.Location = new System.Drawing.Point(280, 615);
            this.lblPassport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(90, 20);
            this.lblPassport.TabIndex = 57;
            this.lblPassport.Text = "Pasaporte:";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.ForeColor = System.Drawing.Color.FloralWhite;
            this.rdbNo.Location = new System.Drawing.Point(158, 655);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(46, 20);
            this.rdbNo.TabIndex = 56;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.ForeColor = System.Drawing.Color.FloralWhite;
            this.rdbSi.Location = new System.Drawing.Point(49, 654);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(40, 20);
            this.rdbSi.TabIndex = 55;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // lblDiscapacity
            // 
            this.lblDiscapacity.AutoSize = true;
            this.lblDiscapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscapacity.ForeColor = System.Drawing.Color.White;
            this.lblDiscapacity.Location = new System.Drawing.Point(33, 615);
            this.lblDiscapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscapacity.Name = "lblDiscapacity";
            this.lblDiscapacity.Size = new System.Drawing.Size(116, 20);
            this.lblDiscapacity.TabIndex = 54;
            this.lblDiscapacity.Text = "Discapacidad:";
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateBirth.Location = new System.Drawing.Point(33, 516);
            this.lblDateBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(149, 20);
            this.lblDateBirth.TabIndex = 53;
            this.lblDateBirth.Text = "Fecha Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 555);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 22);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(268, 314);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(169, 22);
            this.txtCedula.TabIndex = 51;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(264, 290);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(66, 20);
            this.lblDni.TabIndex = 50;
            this.lblDni.Text = "Cédula:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(37, 314);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(171, 22);
            this.txtTelefono.TabIndex = 49;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(37, 290);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 20);
            this.lblPhone.TabIndex = 48;
            this.lblPhone.Text = "Teléfono:";
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(37, 174);
            this.txtDirección.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(400, 22);
            this.txtDirección.TabIndex = 47;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(37, 150);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(86, 20);
            this.lblDireccion.TabIndex = 46;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(268, 108);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 22);
            this.txtApellido.TabIndex = 45;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(264, 83);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 20);
            this.lblLastName.TabIndex = 44;
            this.lblLastName.Text = "Apellido:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(264, 703);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 49);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(37, 703);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 49);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(37, 240);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(400, 22);
            this.txtMail.TabIndex = 34;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(37, 216);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(41, 108);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 22);
            this.txtNombre.TabIndex = 32;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(37, 83);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 20);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Nombre:";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(120, 23);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(249, 36);
            this.lblRegister.TabIndex = 13;
            this.lblRegister.Text = "Registro de datos";
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(461, 39);
            this.panelBarraTitulo.TabIndex = 1;
            this.panelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraTitulo_Paint);
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(410, 12);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(433, 12);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 882);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBPhotoEdit)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.Label lblDiscapacity;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.PictureBox ptrBPhotoEdit;
    }
}
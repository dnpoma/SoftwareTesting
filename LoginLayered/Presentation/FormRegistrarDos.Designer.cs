namespace Presentation
{
    partial class FormRegistrarDos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarDos));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.lblPassport = new System.Windows.Forms.Label();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.lblDiscapacity = new System.Windows.Forms.Label();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.ptrBPhotoEdit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBPhotoEdit)).BeginInit();
            this.SuspendLayout();
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
            this.panelBarraTitulo.Size = new System.Drawing.Size(552, 39);
            this.panelBarraTitulo.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(501, 12);
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
            this.btnCerrar.Location = new System.Drawing.Point(524, 12);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(40, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 474);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.tabPage1.Controls.Add(this.txtPassport);
            this.tabPage1.Controls.Add(this.lblPassport);
            this.tabPage1.Controls.Add(this.rdbNo);
            this.tabPage1.Controls.Add(this.rdbSi);
            this.tabPage1.Controls.Add(this.lblDiscapacity);
            this.tabPage1.Controls.Add(this.lblDateBirth);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.txtCedula);
            this.tabPage1.Controls.Add(this.lblDni);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.lblLastName);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.lblRegister);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(456, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Información Personal";
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(259, 377);
            this.txtPassport.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(173, 22);
            this.txtPassport.TabIndex = 65;
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassport.ForeColor = System.Drawing.Color.White;
            this.lblPassport.Location = new System.Drawing.Point(275, 339);
            this.lblPassport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(90, 20);
            this.lblPassport.TabIndex = 64;
            this.lblPassport.Text = "Pasaporte:";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.ForeColor = System.Drawing.Color.FloralWhite;
            this.rdbNo.Location = new System.Drawing.Point(153, 379);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(46, 20);
            this.rdbNo.TabIndex = 63;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.ForeColor = System.Drawing.Color.FloralWhite;
            this.rdbSi.Location = new System.Drawing.Point(44, 378);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(40, 20);
            this.rdbSi.TabIndex = 62;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // lblDiscapacity
            // 
            this.lblDiscapacity.AutoSize = true;
            this.lblDiscapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscapacity.ForeColor = System.Drawing.Color.White;
            this.lblDiscapacity.Location = new System.Drawing.Point(28, 339);
            this.lblDiscapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscapacity.Name = "lblDiscapacity";
            this.lblDiscapacity.Size = new System.Drawing.Size(116, 20);
            this.lblDiscapacity.TabIndex = 61;
            this.lblDiscapacity.Text = "Discapacidad:";
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateBirth.Location = new System.Drawing.Point(28, 240);
            this.lblDateBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(149, 20);
            this.lblDateBirth.TabIndex = 60;
            this.lblDateBirth.Text = "Fecha Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 279);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 22);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(32, 193);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(169, 22);
            this.txtCedula.TabIndex = 53;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(28, 169);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(66, 20);
            this.lblDni.TabIndex = 52;
            this.lblDni.Text = "Cédula:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(259, 119);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 22);
            this.txtApellido.TabIndex = 49;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(255, 94);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 20);
            this.lblLastName.TabIndex = 48;
            this.lblLastName.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 119);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 22);
            this.txtNombre.TabIndex = 47;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(28, 94);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 20);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "Nombre:";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(80, 23);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(294, 36);
            this.lblRegister.TabIndex = 14;
            this.lblRegister.Text = "Registro de Personal";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtTelefono);
            this.tabPage2.Controls.Add(this.lblPhone);
            this.tabPage2.Controls.Add(this.txtDirección);
            this.tabPage2.Controls.Add(this.lblDireccion);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(456, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contacto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 36);
            this.label1.TabIndex = 54;
            this.label1.Text = "Registro de Contacto";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(36, 278);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(358, 22);
            this.txtTelefono.TabIndex = 53;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(36, 254);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 20);
            this.lblPhone.TabIndex = 52;
            this.lblPhone.Text = "Teléfono:";
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(36, 138);
            this.txtDirección.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(358, 22);
            this.txtDirección.TabIndex = 51;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(36, 114);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(86, 20);
            this.lblDireccion.TabIndex = 50;
            this.lblDireccion.Text = "Dirección:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.tabPage3.Controls.Add(this.lblPhoto);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnUploadPhoto);
            this.tabPage3.Controls.Add(this.ptrBPhotoEdit);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtMail);
            this.tabPage3.Controls.Add(this.lblEmail);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(456, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Datos del Usuario";
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.ForeColor = System.Drawing.Color.White;
            this.lblPhoto.Location = new System.Drawing.Point(30, 230);
            this.lblPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(0, 20);
            this.lblPhoto.TabIndex = 71;
            this.lblPhoto.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Foto:";
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPhoto.Location = new System.Drawing.Point(36, 254);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(110, 40);
            this.btnUploadPhoto.TabIndex = 69;
            this.btnUploadPhoto.Text = "Examinar";
            this.btnUploadPhoto.UseVisualStyleBackColor = false;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // ptrBPhotoEdit
            // 
            this.ptrBPhotoEdit.Location = new System.Drawing.Point(193, 210);
            this.ptrBPhotoEdit.Name = "ptrBPhotoEdit";
            this.ptrBPhotoEdit.Size = new System.Drawing.Size(178, 117);
            this.ptrBPhotoEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrBPhotoEdit.TabIndex = 68;
            this.ptrBPhotoEdit.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 36);
            this.label2.TabIndex = 67;
            this.label2.Text = "Registro de Usuario";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(26, 147);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(400, 22);
            this.txtMail.TabIndex = 66;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(26, 123);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 65;
            this.lblEmail.Text = "Email:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(312, 579);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 49);
            this.btnSave.TabIndex = 45;
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
            this.btnCancel.Location = new System.Drawing.Point(40, 579);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 49);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormRegistrarDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(552, 673);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarDos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistrarDos";
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBPhotoEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.Label lblDiscapacity;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.PictureBox ptrBPhotoEdit;
    }
}
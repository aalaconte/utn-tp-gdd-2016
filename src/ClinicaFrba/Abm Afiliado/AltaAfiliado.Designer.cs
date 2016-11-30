namespace ClinicaFrba.Abm_Afiliado
{
    partial class AltaAfiliado
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chbGrupoFamiliar = new System.Windows.Forms.CheckBox();
            this.gbGrupoFamiliar = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDocAfiTitular = new System.Windows.Forms.TextBox();
            this.nudFamACargo = new System.Windows.Forms.NumericUpDown();
            this.cbFamACargo = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lbl_warn_usuario = new System.Windows.Forms.Label();
            this.lbl_warn_pass = new System.Windows.Forms.Label();
            this.lbl_warn_fecha = new System.Windows.Forms.Label();
            this.lbl_warn_nom = new System.Windows.Forms.Label();
            this.lbl_warn_ape = new System.Windows.Forms.Label();
            this.lbl_warn_dir = new System.Windows.Forms.Label();
            this.lbl_warn_sexo = new System.Windows.Forms.Label();
            this.lbl_warn_tel = new System.Windows.Forms.Label();
            this.lbl_warn_mail = new System.Windows.Forms.Label();
            this.lbl_warn_ec = new System.Windows.Forms.Label();
            this.lbl_warn_plan = new System.Windows.Forms.Label();
            this.lbl_warn_doc = new System.Windows.Forms.Label();
            this.lbl_warn_tdoc = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.gbGrupoFamiliar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFamACargo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(105, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(107, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(292, 15);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(118, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(292, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(118, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(483, 54);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(292, 103);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(118, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(483, 104);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(121, 20);
            this.txtMail.TabIndex = 6;
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Location = new System.Drawing.Point(105, 147);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(114, 21);
            this.cbEstadoCivil.TabIndex = 7;
            // 
            // cbPlan
            // 
            this.cbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(292, 150);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(118, 21);
            this.cbPlan.TabIndex = 8;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(105, 104);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(114, 21);
            this.cbSexo.TabIndex = 9;
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(625, 318);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 10;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Estado Civil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sexo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Plan";
            // 
            // chbGrupoFamiliar
            // 
            this.chbGrupoFamiliar.AutoSize = true;
            this.chbGrupoFamiliar.Location = new System.Drawing.Point(47, 244);
            this.chbGrupoFamiliar.Name = "chbGrupoFamiliar";
            this.chbGrupoFamiliar.Size = new System.Drawing.Size(149, 17);
            this.chbGrupoFamiliar.TabIndex = 21;
            this.chbGrupoFamiliar.Text = "Adherirse a Grupo Familiar";
            this.chbGrupoFamiliar.UseVisualStyleBackColor = true;
            this.chbGrupoFamiliar.CheckedChanged += new System.EventHandler(this.chbGrupoFamiliar_CheckedChanged);
            // 
            // gbGrupoFamiliar
            // 
            this.gbGrupoFamiliar.Controls.Add(this.btn_buscar);
            this.gbGrupoFamiliar.Controls.Add(this.label15);
            this.gbGrupoFamiliar.Controls.Add(this.txtDocAfiTitular);
            this.gbGrupoFamiliar.Location = new System.Drawing.Point(47, 267);
            this.gbGrupoFamiliar.Name = "gbGrupoFamiliar";
            this.gbGrupoFamiliar.Size = new System.Drawing.Size(520, 74);
            this.gbGrupoFamiliar.TabIndex = 22;
            this.gbGrupoFamiliar.TabStop = false;
            this.gbGrupoFamiliar.Text = "Datos Grupo Familiar";
            this.gbGrupoFamiliar.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Documento Afiliado Titular";
            // 
            // txtDocAfiTitular
            // 
            this.txtDocAfiTitular.Location = new System.Drawing.Point(161, 19);
            this.txtDocAfiTitular.Name = "txtDocAfiTitular";
            this.txtDocAfiTitular.Size = new System.Drawing.Size(113, 20);
            this.txtDocAfiTitular.TabIndex = 33;
            // 
            // nudFamACargo
            // 
            this.nudFamACargo.Location = new System.Drawing.Point(540, 215);
            this.nudFamACargo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFamACargo.Name = "nudFamACargo";
            this.nudFamACargo.Size = new System.Drawing.Size(81, 20);
            this.nudFamACargo.TabIndex = 23;
            this.nudFamACargo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFamACargo.Visible = false;
            // 
            // cbFamACargo
            // 
            this.cbFamACargo.AutoSize = true;
            this.cbFamACargo.Location = new System.Drawing.Point(483, 192);
            this.cbFamACargo.Name = "cbFamACargo";
            this.cbFamACargo.Size = new System.Drawing.Size(153, 17);
            this.cbFamACargo.TabIndex = 24;
            this.cbFamACargo.Text = "Agregar Familiares A Cargo";
            this.cbFamACargo.UseVisualStyleBackColor = true;
            this.cbFamACargo.CheckedChanged += new System.EventHandler(this.cbFamACargo_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(485, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cantidad";
            this.label11.Visible = false;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(535, 12);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaNac.TabIndex = 26;
            this.dtpFechaNac.Value = new System.DateTime(2016, 11, 8, 16, 27, 59, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Fecha Nacimiento";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(625, 289);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 28;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(295, 192);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(121, 20);
            this.txtDocumento.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Tipo Documento";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Location = new System.Drawing.Point(105, 193);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(114, 21);
            this.cbTipoDoc.TabIndex = 31;
            // 
            // lbl_warn_usuario
            // 
            this.lbl_warn_usuario.AutoSize = true;
            this.lbl_warn_usuario.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_usuario.Location = new System.Drawing.Point(102, 38);
            this.lbl_warn_usuario.Name = "lbl_warn_usuario";
            this.lbl_warn_usuario.Size = new System.Drawing.Size(125, 13);
            this.lbl_warn_usuario.TabIndex = 33;
            this.lbl_warn_usuario.Text = "Ingrese el campo usuario";
            this.lbl_warn_usuario.Visible = false;
            // 
            // lbl_warn_pass
            // 
            this.lbl_warn_pass.AutoSize = true;
            this.lbl_warn_pass.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_pass.Location = new System.Drawing.Point(289, 38);
            this.lbl_warn_pass.Name = "lbl_warn_pass";
            this.lbl_warn_pass.Size = new System.Drawing.Size(136, 13);
            this.lbl_warn_pass.TabIndex = 34;
            this.lbl_warn_pass.Text = "Ingrese el campo password";
            this.lbl_warn_pass.Visible = false;
            // 
            // lbl_warn_fecha
            // 
            this.lbl_warn_fecha.AutoSize = true;
            this.lbl_warn_fecha.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_fecha.Location = new System.Drawing.Point(532, 35);
            this.lbl_warn_fecha.Name = "lbl_warn_fecha";
            this.lbl_warn_fecha.Size = new System.Drawing.Size(157, 13);
            this.lbl_warn_fecha.TabIndex = 35;
            this.lbl_warn_fecha.Text = "Una fecha de nacimiento valida";
            this.lbl_warn_fecha.Visible = false;
            // 
            // lbl_warn_nom
            // 
            this.lbl_warn_nom.AutoSize = true;
            this.lbl_warn_nom.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_nom.Location = new System.Drawing.Point(102, 77);
            this.lbl_warn_nom.Name = "lbl_warn_nom";
            this.lbl_warn_nom.Size = new System.Drawing.Size(126, 13);
            this.lbl_warn_nom.TabIndex = 36;
            this.lbl_warn_nom.Text = "Ingrese el campo nombre";
            this.lbl_warn_nom.Visible = false;
            // 
            // lbl_warn_ape
            // 
            this.lbl_warn_ape.AutoSize = true;
            this.lbl_warn_ape.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_ape.Location = new System.Drawing.Point(289, 77);
            this.lbl_warn_ape.Name = "lbl_warn_ape";
            this.lbl_warn_ape.Size = new System.Drawing.Size(127, 13);
            this.lbl_warn_ape.TabIndex = 37;
            this.lbl_warn_ape.Text = "Ingrese el campo apellido";
            this.lbl_warn_ape.Visible = false;
            // 
            // lbl_warn_dir
            // 
            this.lbl_warn_dir.AutoSize = true;
            this.lbl_warn_dir.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_dir.Location = new System.Drawing.Point(480, 77);
            this.lbl_warn_dir.Name = "lbl_warn_dir";
            this.lbl_warn_dir.Size = new System.Drawing.Size(134, 13);
            this.lbl_warn_dir.TabIndex = 38;
            this.lbl_warn_dir.Text = "Ingrese el campo direccion";
            this.lbl_warn_dir.Visible = false;
            // 
            // lbl_warn_sexo
            // 
            this.lbl_warn_sexo.AutoSize = true;
            this.lbl_warn_sexo.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_sexo.Location = new System.Drawing.Point(102, 128);
            this.lbl_warn_sexo.Name = "lbl_warn_sexo";
            this.lbl_warn_sexo.Size = new System.Drawing.Size(113, 13);
            this.lbl_warn_sexo.TabIndex = 39;
            this.lbl_warn_sexo.Text = "Ingrese un sexo valido";
            this.lbl_warn_sexo.Visible = false;
            // 
            // lbl_warn_tel
            // 
            this.lbl_warn_tel.AutoSize = true;
            this.lbl_warn_tel.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_tel.Location = new System.Drawing.Point(289, 126);
            this.lbl_warn_tel.Name = "lbl_warn_tel";
            this.lbl_warn_tel.Size = new System.Drawing.Size(129, 13);
            this.lbl_warn_tel.TabIndex = 40;
            this.lbl_warn_tel.Text = "Ingrese un telefono válido";
            this.lbl_warn_tel.Visible = false;
            // 
            // lbl_warn_mail
            // 
            this.lbl_warn_mail.AutoSize = true;
            this.lbl_warn_mail.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_mail.Location = new System.Drawing.Point(480, 128);
            this.lbl_warn_mail.Name = "lbl_warn_mail";
            this.lbl_warn_mail.Size = new System.Drawing.Size(78, 13);
            this.lbl_warn_mail.TabIndex = 41;
            this.lbl_warn_mail.Text = "Ingrese un mail";
            this.lbl_warn_mail.Visible = false;
            // 
            // lbl_warn_ec
            // 
            this.lbl_warn_ec.AutoSize = true;
            this.lbl_warn_ec.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_ec.Location = new System.Drawing.Point(102, 171);
            this.lbl_warn_ec.Name = "lbl_warn_ec";
            this.lbl_warn_ec.Size = new System.Drawing.Size(115, 13);
            this.lbl_warn_ec.TabIndex = 42;
            this.lbl_warn_ec.Text = "Ingrese un Estado Civil";
            this.lbl_warn_ec.Visible = false;
            // 
            // lbl_warn_plan
            // 
            this.lbl_warn_plan.AutoSize = true;
            this.lbl_warn_plan.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_plan.Location = new System.Drawing.Point(289, 171);
            this.lbl_warn_plan.Name = "lbl_warn_plan";
            this.lbl_warn_plan.Size = new System.Drawing.Size(81, 13);
            this.lbl_warn_plan.TabIndex = 43;
            this.lbl_warn_plan.Text = "Ingrese un Plan";
            this.lbl_warn_plan.Visible = false;
            // 
            // lbl_warn_doc
            // 
            this.lbl_warn_doc.AutoSize = true;
            this.lbl_warn_doc.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_doc.Location = new System.Drawing.Point(289, 216);
            this.lbl_warn_doc.Name = "lbl_warn_doc";
            this.lbl_warn_doc.Size = new System.Drawing.Size(144, 13);
            this.lbl_warn_doc.TabIndex = 44;
            this.lbl_warn_doc.Text = "Ingrese un documento válido";
            this.lbl_warn_doc.Visible = false;
            // 
            // lbl_warn_tdoc
            // 
            this.lbl_warn_tdoc.AutoSize = true;
            this.lbl_warn_tdoc.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_tdoc.Location = new System.Drawing.Point(102, 216);
            this.lbl_warn_tdoc.Name = "lbl_warn_tdoc";
            this.lbl_warn_tdoc.Size = new System.Drawing.Size(148, 13);
            this.lbl_warn_tdoc.TabIndex = 45;
            this.lbl_warn_tdoc.Text = "Ingrese un tipo de documento";
            this.lbl_warn_tdoc.Visible = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(280, 19);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 20);
            this.btn_buscar.TabIndex = 46;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // AltaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 365);
            this.Controls.Add(this.lbl_warn_tdoc);
            this.Controls.Add(this.lbl_warn_doc);
            this.Controls.Add(this.lbl_warn_plan);
            this.Controls.Add(this.lbl_warn_ec);
            this.Controls.Add(this.lbl_warn_mail);
            this.Controls.Add(this.lbl_warn_tel);
            this.Controls.Add(this.lbl_warn_sexo);
            this.Controls.Add(this.lbl_warn_dir);
            this.Controls.Add(this.lbl_warn_ape);
            this.Controls.Add(this.lbl_warn_nom);
            this.Controls.Add(this.lbl_warn_fecha);
            this.Controls.Add(this.lbl_warn_pass);
            this.Controls.Add(this.lbl_warn_usuario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbTipoDoc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbFamACargo);
            this.Controls.Add(this.nudFamACargo);
            this.Controls.Add(this.gbGrupoFamiliar);
            this.Controls.Add(this.chbGrupoFamiliar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.cbPlan);
            this.Controls.Add(this.cbEstadoCivil);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "AltaAfiliado";
            this.Text = "AltaAfiliado";
            this.Load += new System.EventHandler(this.AltaAfiliado_Load);
            this.gbGrupoFamiliar.ResumeLayout(false);
            this.gbGrupoFamiliar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFamACargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chbGrupoFamiliar;
        private System.Windows.Forms.GroupBox gbGrupoFamiliar;
        private System.Windows.Forms.NumericUpDown nudFamACargo;
        private System.Windows.Forms.CheckBox cbFamACargo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDocAfiTitular;
        private System.Windows.Forms.Label lbl_warn_usuario;
        private System.Windows.Forms.Label lbl_warn_pass;
        private System.Windows.Forms.Label lbl_warn_fecha;
        private System.Windows.Forms.Label lbl_warn_nom;
        private System.Windows.Forms.Label lbl_warn_ape;
        private System.Windows.Forms.Label lbl_warn_dir;
        private System.Windows.Forms.Label lbl_warn_sexo;
        private System.Windows.Forms.Label lbl_warn_tel;
        private System.Windows.Forms.Label lbl_warn_mail;
        private System.Windows.Forms.Label lbl_warn_ec;
        private System.Windows.Forms.Label lbl_warn_plan;
        private System.Windows.Forms.Label lbl_warn_doc;
        private System.Windows.Forms.Label lbl_warn_tdoc;
        private System.Windows.Forms.Button btn_buscar;
    }
}
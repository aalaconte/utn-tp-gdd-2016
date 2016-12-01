namespace ClinicaFrba.Registro_Resultado
{
    partial class RegistrarResultado
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.dgv_ConsultasProfesional = new System.Windows.Forms.DataGridView();
            this.lblCantConsultas = new System.Windows.Forms.Label();
            this.lbl_nro_pagina = new System.Windows.Forms.Label();
            this.lbl_nroConsulta = new System.Windows.Forms.Label();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_ultima = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_primera = new System.Windows.Forms.Button();
            this.lbl_profesionales = new System.Windows.Forms.Label();
            this.lbl_DocProfesional = new System.Windows.Forms.Label();
            this.btn_ver = new System.Windows.Forms.Button();
            this.pan_regRes = new System.Windows.Forms.Panel();
            this.btn_buscar_profesional = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultasProfesional)).BeginInit();
            this.pan_regRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Fecha Actual:";
            // 
            // dtp_fechaConsulta
            // 
            this.dtp_fechaConsulta.CustomFormat = "d-M-yyyy HH:mm:ss";
            this.dtp_fechaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaConsulta.Location = new System.Drawing.Point(472, 20);
            this.dtp_fechaConsulta.Name = "dtp_fechaConsulta";
            this.dtp_fechaConsulta.Size = new System.Drawing.Size(118, 20);
            this.dtp_fechaConsulta.TabIndex = 58;
            // 
            // dgv_ConsultasProfesional
            // 
            this.dgv_ConsultasProfesional.AllowUserToAddRows = false;
            this.dgv_ConsultasProfesional.AllowUserToDeleteRows = false;
            this.dgv_ConsultasProfesional.AllowUserToResizeColumns = false;
            this.dgv_ConsultasProfesional.AllowUserToResizeRows = false;
            this.dgv_ConsultasProfesional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ConsultasProfesional.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_ConsultasProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ConsultasProfesional.Location = new System.Drawing.Point(18, 56);
            this.dgv_ConsultasProfesional.MultiSelect = false;
            this.dgv_ConsultasProfesional.Name = "dgv_ConsultasProfesional";
            this.dgv_ConsultasProfesional.ReadOnly = true;
            this.dgv_ConsultasProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ConsultasProfesional.Size = new System.Drawing.Size(682, 170);
            this.dgv_ConsultasProfesional.TabIndex = 69;
            // 
            // lblCantConsultas
            // 
            this.lblCantConsultas.AutoSize = true;
            this.lblCantConsultas.Location = new System.Drawing.Point(568, 229);
            this.lblCantConsultas.Name = "lblCantConsultas";
            this.lblCantConsultas.Size = new System.Drawing.Size(0, 13);
            this.lblCantConsultas.TabIndex = 68;
            // 
            // lbl_nro_pagina
            // 
            this.lbl_nro_pagina.AutoSize = true;
            this.lbl_nro_pagina.Location = new System.Drawing.Point(2, 227);
            this.lbl_nro_pagina.Name = "lbl_nro_pagina";
            this.lbl_nro_pagina.Size = new System.Drawing.Size(0, 13);
            this.lbl_nro_pagina.TabIndex = 67;
            // 
            // lbl_nroConsulta
            // 
            this.lbl_nroConsulta.AutoSize = true;
            this.lbl_nroConsulta.Location = new System.Drawing.Point(700, 229);
            this.lbl_nroConsulta.Name = "lbl_nroConsulta";
            this.lbl_nroConsulta.Size = new System.Drawing.Size(0, 13);
            this.lbl_nroConsulta.TabIndex = 66;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(666, 334);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 65;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Visible = false;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(571, 259);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguiente.TabIndex = 64;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_ultima
            // 
            this.btn_ultima.Location = new System.Drawing.Point(653, 259);
            this.btn_ultima.Name = "btn_ultima";
            this.btn_ultima.Size = new System.Drawing.Size(75, 23);
            this.btn_ultima.TabIndex = 63;
            this.btn_ultima.Text = "Última";
            this.btn_ultima.UseVisualStyleBackColor = true;
            this.btn_ultima.Click += new System.EventHandler(this.btn_ultima_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(83, 259);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_anterior.TabIndex = 62;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(14, 334);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 61;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_primera
            // 
            this.btn_primera.Location = new System.Drawing.Point(2, 259);
            this.btn_primera.Name = "btn_primera";
            this.btn_primera.Size = new System.Drawing.Size(75, 23);
            this.btn_primera.TabIndex = 60;
            this.btn_primera.Text = "Primera";
            this.btn_primera.UseVisualStyleBackColor = true;
            this.btn_primera.Click += new System.EventHandler(this.btn_primera_Click);
            // 
            // lbl_profesionales
            // 
            this.lbl_profesionales.AutoSize = true;
            this.lbl_profesionales.Location = new System.Drawing.Point(21, 9);
            this.lbl_profesionales.Name = "lbl_profesionales";
            this.lbl_profesionales.Size = new System.Drawing.Size(62, 13);
            this.lbl_profesionales.TabIndex = 70;
            this.lbl_profesionales.Text = "Profesional:";
            // 
            // lbl_DocProfesional
            // 
            this.lbl_DocProfesional.AutoSize = true;
            this.lbl_DocProfesional.Location = new System.Drawing.Point(89, 9);
            this.lbl_DocProfesional.Name = "lbl_DocProfesional";
            this.lbl_DocProfesional.Size = new System.Drawing.Size(70, 13);
            this.lbl_DocProfesional.TabIndex = 71;
            this.lbl_DocProfesional.Text = "IDProfesional";
            // 
            // btn_ver
            // 
            this.btn_ver.Location = new System.Drawing.Point(625, 17);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(75, 23);
            this.btn_ver.TabIndex = 72;
            this.btn_ver.Text = "Ver";
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // pan_regRes
            // 
            this.pan_regRes.Controls.Add(this.btn_ver);
            this.pan_regRes.Controls.Add(this.dgv_ConsultasProfesional);
            this.pan_regRes.Controls.Add(this.lblCantConsultas);
            this.pan_regRes.Controls.Add(this.lbl_nro_pagina);
            this.pan_regRes.Controls.Add(this.lbl_nroConsulta);
            this.pan_regRes.Controls.Add(this.btn_siguiente);
            this.pan_regRes.Controls.Add(this.btn_ultima);
            this.pan_regRes.Controls.Add(this.btn_anterior);
            this.pan_regRes.Controls.Add(this.btn_primera);
            this.pan_regRes.Controls.Add(this.label1);
            this.pan_regRes.Controls.Add(this.dtp_fechaConsulta);
            this.pan_regRes.Location = new System.Drawing.Point(12, 40);
            this.pan_regRes.Name = "pan_regRes";
            this.pan_regRes.Size = new System.Drawing.Size(740, 288);
            this.pan_regRes.TabIndex = 73;
            this.pan_regRes.Visible = false;
            // 
            // btn_buscar_profesional
            // 
            this.btn_buscar_profesional.Location = new System.Drawing.Point(176, 4);
            this.btn_buscar_profesional.Name = "btn_buscar_profesional";
            this.btn_buscar_profesional.Size = new System.Drawing.Size(75, 22);
            this.btn_buscar_profesional.TabIndex = 74;
            this.btn_buscar_profesional.Text = "Buscar";
            this.btn_buscar_profesional.UseVisualStyleBackColor = true;
            this.btn_buscar_profesional.Click += new System.EventHandler(this.btn_buscar_profesional_Click);
            // 
            // RegistrarResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 372);
            this.Controls.Add(this.pan_regRes);
            this.Controls.Add(this.btn_buscar_profesional);
            this.Controls.Add(this.lbl_DocProfesional);
            this.Controls.Add(this.lbl_profesionales);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_seleccionar);
            this.Name = "RegistrarResultado";
            this.Text = "RegistrarResultado";
            this.Load += new System.EventHandler(this.RegistrarResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultasProfesional)).EndInit();
            this.pan_regRes.ResumeLayout(false);
            this.pan_regRes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fechaConsulta;
        private System.Windows.Forms.DataGridView dgv_ConsultasProfesional;
        private System.Windows.Forms.Label lblCantConsultas;
        private System.Windows.Forms.Label lbl_nro_pagina;
        private System.Windows.Forms.Label lbl_nroConsulta;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_ultima;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_primera;
        private System.Windows.Forms.Label lbl_profesionales;
        private System.Windows.Forms.Label lbl_DocProfesional;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.Panel pan_regRes;
        private System.Windows.Forms.Button btn_buscar_profesional;
    }
}
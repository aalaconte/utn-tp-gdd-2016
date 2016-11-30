namespace ClinicaFrba.Registro_Llegada
{
    partial class RegistroLlegada
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
            this.btn_buscar_profesional = new System.Windows.Forms.Button();
            this.txt_profesional = new System.Windows.Forms.TextBox();
            this.lbl_profesionales = new System.Windows.Forms.Label();
            this.dtp_fechaTurno = new System.Windows.Forms.DateTimePicker();
            this.btn_buscarTurnos = new System.Windows.Forms.Button();
            this.lblCantTurnos = new System.Windows.Forms.Label();
            this.lbl_nro_pagina = new System.Windows.Forms.Label();
            this.lbl_nroTurno = new System.Windows.Forms.Label();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_ultima = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_primera = new System.Windows.Forms.Button();
            this.dgv_turnosProfesional = new System.Windows.Forms.DataGridView();
            this.lbl_afiliados = new System.Windows.Forms.Label();
            this.btn_buscarAfiliado = new System.Windows.Forms.Button();
            this.lbl_warn_afiliado = new System.Windows.Forms.Label();
            this.txt_idAfiliado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnosProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar_profesional
            // 
            this.btn_buscar_profesional.Location = new System.Drawing.Point(233, 21);
            this.btn_buscar_profesional.Name = "btn_buscar_profesional";
            this.btn_buscar_profesional.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_profesional.TabIndex = 37;
            this.btn_buscar_profesional.Text = "Seleccionar";
            this.btn_buscar_profesional.UseVisualStyleBackColor = true;
            this.btn_buscar_profesional.Click += new System.EventHandler(this.btn_buscar_profesional_Click);
            // 
            // txt_profesional
            // 
            this.txt_profesional.Enabled = false;
            this.txt_profesional.Location = new System.Drawing.Point(93, 23);
            this.txt_profesional.Name = "txt_profesional";
            this.txt_profesional.ReadOnly = true;
            this.txt_profesional.Size = new System.Drawing.Size(131, 20);
            this.txt_profesional.TabIndex = 36;
            // 
            // lbl_profesionales
            // 
            this.lbl_profesionales.AutoSize = true;
            this.lbl_profesionales.Location = new System.Drawing.Point(25, 26);
            this.lbl_profesionales.Name = "lbl_profesionales";
            this.lbl_profesionales.Size = new System.Drawing.Size(62, 13);
            this.lbl_profesionales.TabIndex = 35;
            this.lbl_profesionales.Text = "Profesional:";
            // 
            // dtp_fechaTurno
            // 
            this.dtp_fechaTurno.CustomFormat = "d-M-yyyy HH:mm:ss";
            this.dtp_fechaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaTurno.Location = new System.Drawing.Point(488, 45);
            this.dtp_fechaTurno.Name = "dtp_fechaTurno";
            this.dtp_fechaTurno.Size = new System.Drawing.Size(118, 20);
            this.dtp_fechaTurno.TabIndex = 39;
            // 
            // btn_buscarTurnos
            // 
            this.btn_buscarTurnos.Location = new System.Drawing.Point(635, 64);
            this.btn_buscarTurnos.Name = "btn_buscarTurnos";
            this.btn_buscarTurnos.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarTurnos.TabIndex = 41;
            this.btn_buscarTurnos.Text = "Buscar";
            this.btn_buscarTurnos.UseVisualStyleBackColor = true;
            this.btn_buscarTurnos.Click += new System.EventHandler(this.btn_buscarTurnos_Click);
            // 
            // lblCantTurnos
            // 
            this.lblCantTurnos.AutoSize = true;
            this.lblCantTurnos.Location = new System.Drawing.Point(606, 264);
            this.lblCantTurnos.Name = "lblCantTurnos";
            this.lblCantTurnos.Size = new System.Drawing.Size(0, 13);
            this.lblCantTurnos.TabIndex = 50;
            // 
            // lbl_nro_pagina
            // 
            this.lbl_nro_pagina.AutoSize = true;
            this.lbl_nro_pagina.Location = new System.Drawing.Point(12, 264);
            this.lbl_nro_pagina.Name = "lbl_nro_pagina";
            this.lbl_nro_pagina.Size = new System.Drawing.Size(0, 13);
            this.lbl_nro_pagina.TabIndex = 49;
            // 
            // lbl_nroTurno
            // 
            this.lbl_nroTurno.AutoSize = true;
            this.lbl_nroTurno.Location = new System.Drawing.Point(703, 264);
            this.lbl_nroTurno.Name = "lbl_nroTurno";
            this.lbl_nroTurno.Size = new System.Drawing.Size(0, 13);
            this.lbl_nroTurno.TabIndex = 48;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(663, 325);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 47;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(581, 296);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguiente.TabIndex = 46;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_ultima
            // 
            this.btn_ultima.Location = new System.Drawing.Point(663, 296);
            this.btn_ultima.Name = "btn_ultima";
            this.btn_ultima.Size = new System.Drawing.Size(75, 23);
            this.btn_ultima.TabIndex = 45;
            this.btn_ultima.Text = "Última";
            this.btn_ultima.UseVisualStyleBackColor = true;
            this.btn_ultima.Click += new System.EventHandler(this.btn_ultima_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(93, 296);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_anterior.TabIndex = 44;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(12, 325);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 43;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_primera
            // 
            this.btn_primera.Location = new System.Drawing.Point(12, 296);
            this.btn_primera.Name = "btn_primera";
            this.btn_primera.Size = new System.Drawing.Size(75, 23);
            this.btn_primera.TabIndex = 42;
            this.btn_primera.Text = "Primera";
            this.btn_primera.UseVisualStyleBackColor = true;
            this.btn_primera.Click += new System.EventHandler(this.btn_primera_Click);
            // 
            // dgv_turnosProfesional
            // 
            this.dgv_turnosProfesional.AllowUserToAddRows = false;
            this.dgv_turnosProfesional.AllowUserToDeleteRows = false;
            this.dgv_turnosProfesional.AllowUserToResizeColumns = false;
            this.dgv_turnosProfesional.AllowUserToResizeRows = false;
            this.dgv_turnosProfesional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_turnosProfesional.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_turnosProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turnosProfesional.Location = new System.Drawing.Point(28, 93);
            this.dgv_turnosProfesional.MultiSelect = false;
            this.dgv_turnosProfesional.Name = "dgv_turnosProfesional";
            this.dgv_turnosProfesional.ReadOnly = true;
            this.dgv_turnosProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turnosProfesional.Size = new System.Drawing.Size(682, 170);
            this.dgv_turnosProfesional.TabIndex = 51;
            // 
            // lbl_afiliados
            // 
            this.lbl_afiliados.AutoSize = true;
            this.lbl_afiliados.Location = new System.Drawing.Point(25, 52);
            this.lbl_afiliados.Name = "lbl_afiliados";
            this.lbl_afiliados.Size = new System.Drawing.Size(58, 13);
            this.lbl_afiliados.TabIndex = 52;
            this.lbl_afiliados.Text = "ID Afiliado:";
            // 
            // btn_buscarAfiliado
            // 
            this.btn_buscarAfiliado.Location = new System.Drawing.Point(233, 47);
            this.btn_buscarAfiliado.Name = "btn_buscarAfiliado";
            this.btn_buscarAfiliado.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarAfiliado.TabIndex = 54;
            this.btn_buscarAfiliado.Text = "Seleccionar";
            this.btn_buscarAfiliado.UseVisualStyleBackColor = true;
            this.btn_buscarAfiliado.Click += new System.EventHandler(this.btn_buscarAfiliado_Click);
            // 
            // lbl_warn_afiliado
            // 
            this.lbl_warn_afiliado.AutoSize = true;
            this.lbl_warn_afiliado.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_afiliado.Location = new System.Drawing.Point(90, 73);
            this.lbl_warn_afiliado.Name = "lbl_warn_afiliado";
            this.lbl_warn_afiliado.Size = new System.Drawing.Size(282, 13);
            this.lbl_warn_afiliado.TabIndex = 55;
            this.lbl_warn_afiliado.Text = "Debe seleccionar el Afiliado que desea registrar la llegada.";
            this.lbl_warn_afiliado.Visible = false;
            // 
            // txt_idAfiliado
            // 
            this.txt_idAfiliado.Enabled = false;
            this.txt_idAfiliado.Location = new System.Drawing.Point(93, 48);
            this.txt_idAfiliado.Name = "txt_idAfiliado";
            this.txt_idAfiliado.ReadOnly = true;
            this.txt_idAfiliado.Size = new System.Drawing.Size(131, 20);
            this.txt_idAfiliado.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Fecha Actual:";
            // 
            // RegistroLlegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idAfiliado);
            this.Controls.Add(this.lbl_warn_afiliado);
            this.Controls.Add(this.btn_buscarAfiliado);
            this.Controls.Add(this.lbl_afiliados);
            this.Controls.Add(this.dgv_turnosProfesional);
            this.Controls.Add(this.lblCantTurnos);
            this.Controls.Add(this.lbl_nro_pagina);
            this.Controls.Add(this.lbl_nroTurno);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_ultima);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_primera);
            this.Controls.Add(this.btn_buscarTurnos);
            this.Controls.Add(this.dtp_fechaTurno);
            this.Controls.Add(this.btn_buscar_profesional);
            this.Controls.Add(this.txt_profesional);
            this.Controls.Add(this.lbl_profesionales);
            this.Name = "RegistroLlegada";
            this.Text = "RegistroLlegada";
            this.Load += new System.EventHandler(this.RegistroLlegada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnosProfesional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar_profesional;
        private System.Windows.Forms.TextBox txt_profesional;
        private System.Windows.Forms.Label lbl_profesionales;
        private System.Windows.Forms.DateTimePicker dtp_fechaTurno;
        private System.Windows.Forms.Button btn_buscarTurnos;
        private System.Windows.Forms.Label lblCantTurnos;
        private System.Windows.Forms.Label lbl_nro_pagina;
        private System.Windows.Forms.Label lbl_nroTurno;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_ultima;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_primera;
        private System.Windows.Forms.DataGridView dgv_turnosProfesional;
        private System.Windows.Forms.Label lbl_afiliados;
        private System.Windows.Forms.Button btn_buscarAfiliado;
        private System.Windows.Forms.Label lbl_warn_afiliado;
        private System.Windows.Forms.TextBox txt_idAfiliado;
        private System.Windows.Forms.Label label1;
    }
}
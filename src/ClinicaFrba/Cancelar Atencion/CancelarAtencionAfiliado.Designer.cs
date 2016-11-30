namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarAtencionAfiliado
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
            this.gpb_filtros = new System.Windows.Forms.GroupBox();
            this.chk_buscar_fecha = new System.Windows.Forms.CheckBox();
            this.dtp_fecha_turno = new System.Windows.Forms.DateTimePicker();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_turnos = new System.Windows.Forms.DataGridView();
            this.lbl_nro_pagina = new System.Windows.Forms.Label();
            this.lbl_nro_turnos = new System.Windows.Forms.Label();
            this.lbl_cantidad_turnos = new System.Windows.Forms.Label();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_primera = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_ultima = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.lbl_error_motivo = new System.Windows.Forms.Label();
            this.pan_canAfiliado = new System.Windows.Forms.Panel();
            this.txt_idAfiliado = new System.Windows.Forms.TextBox();
            this.btn_buscarAfiliado = new System.Windows.Forms.Button();
            this.lbl_afiliados = new System.Windows.Forms.Label();
            this.btn_buscar_profesional = new System.Windows.Forms.Button();
            this.txt_profesional = new System.Windows.Forms.TextBox();
            this.lbl_profesionales = new System.Windows.Forms.Label();
            this.cmb_especialidades = new System.Windows.Forms.ComboBox();
            this.lbl_especialidades = new System.Windows.Forms.Label();
            this.lbl_error_esp = new System.Windows.Forms.Label();
            this.lbl_error_pro = new System.Windows.Forms.Label();
            this.gpb_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnos)).BeginInit();
            this.pan_canAfiliado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_filtros
            // 
            this.gpb_filtros.Controls.Add(this.lbl_error_pro);
            this.gpb_filtros.Controls.Add(this.lbl_error_esp);
            this.gpb_filtros.Controls.Add(this.cmb_especialidades);
            this.gpb_filtros.Controls.Add(this.lbl_especialidades);
            this.gpb_filtros.Controls.Add(this.btn_buscar_profesional);
            this.gpb_filtros.Controls.Add(this.txt_profesional);
            this.gpb_filtros.Controls.Add(this.chk_buscar_fecha);
            this.gpb_filtros.Controls.Add(this.lbl_profesionales);
            this.gpb_filtros.Controls.Add(this.dtp_fecha_turno);
            this.gpb_filtros.Location = new System.Drawing.Point(3, 9);
            this.gpb_filtros.Name = "gpb_filtros";
            this.gpb_filtros.Size = new System.Drawing.Size(633, 111);
            this.gpb_filtros.TabIndex = 0;
            this.gpb_filtros.TabStop = false;
            this.gpb_filtros.Text = "Filtros";
            // 
            // chk_buscar_fecha
            // 
            this.chk_buscar_fecha.AutoSize = true;
            this.chk_buscar_fecha.Location = new System.Drawing.Point(395, 20);
            this.chk_buscar_fecha.Name = "chk_buscar_fecha";
            this.chk_buscar_fecha.Size = new System.Drawing.Size(107, 17);
            this.chk_buscar_fecha.TabIndex = 6;
            this.chk_buscar_fecha.Text = "Buscar por fecha";
            this.chk_buscar_fecha.UseVisualStyleBackColor = true;
            this.chk_buscar_fecha.CheckedChanged += new System.EventHandler(this.chk_buscar_fecha_CheckedChanged);
            // 
            // dtp_fecha_turno
            // 
            this.dtp_fecha_turno.Location = new System.Drawing.Point(395, 43);
            this.dtp_fecha_turno.Name = "dtp_fecha_turno";
            this.dtp_fecha_turno.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_turno.TabIndex = 1;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(4, 127);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 1;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(559, 127);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_turnos
            // 
            this.dgv_turnos.AllowUserToAddRows = false;
            this.dgv_turnos.AllowUserToDeleteRows = false;
            this.dgv_turnos.AllowUserToResizeRows = false;
            this.dgv_turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turnos.Location = new System.Drawing.Point(4, 156);
            this.dgv_turnos.MultiSelect = false;
            this.dgv_turnos.Name = "dgv_turnos";
            this.dgv_turnos.ReadOnly = true;
            this.dgv_turnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turnos.Size = new System.Drawing.Size(630, 163);
            this.dgv_turnos.TabIndex = 3;
            // 
            // lbl_nro_pagina
            // 
            this.lbl_nro_pagina.AutoSize = true;
            this.lbl_nro_pagina.Location = new System.Drawing.Point(12, 328);
            this.lbl_nro_pagina.Name = "lbl_nro_pagina";
            this.lbl_nro_pagina.Size = new System.Drawing.Size(84, 13);
            this.lbl_nro_pagina.TabIndex = 4;
            this.lbl_nro_pagina.Text = "labelNroPaginas";
            // 
            // lbl_nro_turnos
            // 
            this.lbl_nro_turnos.AutoSize = true;
            this.lbl_nro_turnos.Location = new System.Drawing.Point(554, 328);
            this.lbl_nro_turnos.Name = "lbl_nro_turnos";
            this.lbl_nro_turnos.Size = new System.Drawing.Size(79, 13);
            this.lbl_nro_turnos.TabIndex = 5;
            this.lbl_nro_turnos.Text = "labelNroTurnos";
            // 
            // lbl_cantidad_turnos
            // 
            this.lbl_cantidad_turnos.AutoSize = true;
            this.lbl_cantidad_turnos.Location = new System.Drawing.Point(449, 328);
            this.lbl_cantidad_turnos.Name = "lbl_cantidad_turnos";
            this.lbl_cantidad_turnos.Size = new System.Drawing.Size(99, 13);
            this.lbl_cantidad_turnos.TabIndex = 6;
            this.lbl_cantidad_turnos.Text = "Cantidad de turnos:";
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(11, 483);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 7;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(569, 483);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 8;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_primera
            // 
            this.btn_primera.Location = new System.Drawing.Point(12, 354);
            this.btn_primera.Name = "btn_primera";
            this.btn_primera.Size = new System.Drawing.Size(75, 23);
            this.btn_primera.TabIndex = 9;
            this.btn_primera.Text = "Primera";
            this.btn_primera.UseVisualStyleBackColor = true;
            this.btn_primera.Click += new System.EventHandler(this.btn_primera_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(93, 354);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_anterior.TabIndex = 10;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_ultima
            // 
            this.btn_ultima.Location = new System.Drawing.Point(558, 354);
            this.btn_ultima.Name = "btn_ultima";
            this.btn_ultima.Size = new System.Drawing.Size(75, 23);
            this.btn_ultima.TabIndex = 11;
            this.btn_ultima.Text = "Última";
            this.btn_ultima.UseVisualStyleBackColor = true;
            this.btn_ultima.Click += new System.EventHandler(this.btn_ultima_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(477, 354);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguiente.TabIndex = 12;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Motivo de la cancelación:";
            // 
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(142, 396);
            this.txt_motivo.MaxLength = 255;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(330, 20);
            this.txt_motivo.TabIndex = 7;
            // 
            // lbl_error_motivo
            // 
            this.lbl_error_motivo.AutoSize = true;
            this.lbl_error_motivo.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_motivo.Location = new System.Drawing.Point(139, 419);
            this.lbl_error_motivo.Name = "lbl_error_motivo";
            this.lbl_error_motivo.Size = new System.Drawing.Size(125, 13);
            this.lbl_error_motivo.TabIndex = 14;
            this.lbl_error_motivo.Text = "Debe ingresar un motivo!";
            this.lbl_error_motivo.Visible = false;
            // 
            // pan_canAfiliado
            // 
            this.pan_canAfiliado.Controls.Add(this.lbl_error_motivo);
            this.pan_canAfiliado.Controls.Add(this.txt_motivo);
            this.pan_canAfiliado.Controls.Add(this.label2);
            this.pan_canAfiliado.Controls.Add(this.btn_siguiente);
            this.pan_canAfiliado.Controls.Add(this.btn_ultima);
            this.pan_canAfiliado.Controls.Add(this.btn_anterior);
            this.pan_canAfiliado.Controls.Add(this.btn_primera);
            this.pan_canAfiliado.Controls.Add(this.lbl_cantidad_turnos);
            this.pan_canAfiliado.Controls.Add(this.lbl_nro_turnos);
            this.pan_canAfiliado.Controls.Add(this.lbl_nro_pagina);
            this.pan_canAfiliado.Controls.Add(this.dgv_turnos);
            this.pan_canAfiliado.Controls.Add(this.btn_buscar);
            this.pan_canAfiliado.Controls.Add(this.btn_limpiar);
            this.pan_canAfiliado.Controls.Add(this.gpb_filtros);
            this.pan_canAfiliado.Location = new System.Drawing.Point(11, 37);
            this.pan_canAfiliado.Name = "pan_canAfiliado";
            this.pan_canAfiliado.Size = new System.Drawing.Size(641, 440);
            this.pan_canAfiliado.TabIndex = 15;
            // 
            // txt_idAfiliado
            // 
            this.txt_idAfiliado.Enabled = false;
            this.txt_idAfiliado.Location = new System.Drawing.Point(80, 9);
            this.txt_idAfiliado.Name = "txt_idAfiliado";
            this.txt_idAfiliado.ReadOnly = true;
            this.txt_idAfiliado.Size = new System.Drawing.Size(131, 20);
            this.txt_idAfiliado.TabIndex = 59;
            // 
            // btn_buscarAfiliado
            // 
            this.btn_buscarAfiliado.Location = new System.Drawing.Point(220, 8);
            this.btn_buscarAfiliado.Name = "btn_buscarAfiliado";
            this.btn_buscarAfiliado.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarAfiliado.TabIndex = 58;
            this.btn_buscarAfiliado.Text = "Seleccionar";
            this.btn_buscarAfiliado.UseVisualStyleBackColor = true;
            this.btn_buscarAfiliado.Click += new System.EventHandler(this.btn_buscarAfiliado_Click);
            // 
            // lbl_afiliados
            // 
            this.lbl_afiliados.AutoSize = true;
            this.lbl_afiliados.Location = new System.Drawing.Point(12, 13);
            this.lbl_afiliados.Name = "lbl_afiliados";
            this.lbl_afiliados.Size = new System.Drawing.Size(58, 13);
            this.lbl_afiliados.TabIndex = 57;
            this.lbl_afiliados.Text = "ID Afiliado:";
            // 
            // btn_buscar_profesional
            // 
            this.btn_buscar_profesional.Location = new System.Drawing.Point(222, 19);
            this.btn_buscar_profesional.Name = "btn_buscar_profesional";
            this.btn_buscar_profesional.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_profesional.TabIndex = 62;
            this.btn_buscar_profesional.Text = "Seleccionar";
            this.btn_buscar_profesional.UseVisualStyleBackColor = true;
            this.btn_buscar_profesional.Click += new System.EventHandler(this.btn_buscar_profesional_Click);
            // 
            // txt_profesional
            // 
            this.txt_profesional.Enabled = false;
            this.txt_profesional.Location = new System.Drawing.Point(82, 21);
            this.txt_profesional.Name = "txt_profesional";
            this.txt_profesional.ReadOnly = true;
            this.txt_profesional.Size = new System.Drawing.Size(131, 20);
            this.txt_profesional.TabIndex = 61;
            // 
            // lbl_profesionales
            // 
            this.lbl_profesionales.AutoSize = true;
            this.lbl_profesionales.Location = new System.Drawing.Point(14, 24);
            this.lbl_profesionales.Name = "lbl_profesionales";
            this.lbl_profesionales.Size = new System.Drawing.Size(62, 13);
            this.lbl_profesionales.TabIndex = 60;
            this.lbl_profesionales.Text = "Profesional:";
            // 
            // cmb_especialidades
            // 
            this.cmb_especialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_especialidades.FormattingEnabled = true;
            this.cmb_especialidades.Location = new System.Drawing.Point(176, 65);
            this.cmb_especialidades.Name = "cmb_especialidades";
            this.cmb_especialidades.Size = new System.Drawing.Size(121, 21);
            this.cmb_especialidades.TabIndex = 64;
            this.cmb_especialidades.Visible = false;
            // 
            // lbl_especialidades
            // 
            this.lbl_especialidades.AutoSize = true;
            this.lbl_especialidades.Location = new System.Drawing.Point(14, 68);
            this.lbl_especialidades.Name = "lbl_especialidades";
            this.lbl_especialidades.Size = new System.Drawing.Size(146, 13);
            this.lbl_especialidades.TabIndex = 63;
            this.lbl_especialidades.Text = "Seleccione una especialidad:";
            this.lbl_especialidades.Visible = false;
            // 
            // lbl_error_esp
            // 
            this.lbl_error_esp.AutoSize = true;
            this.lbl_error_esp.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_esp.Location = new System.Drawing.Point(173, 89);
            this.lbl_error_esp.Name = "lbl_error_esp";
            this.lbl_error_esp.Size = new System.Drawing.Size(173, 13);
            this.lbl_error_esp.TabIndex = 65;
            this.lbl_error_esp.Text = "Debe seleccionar una especialidad";
            this.lbl_error_esp.Visible = false;
            // 
            // lbl_error_pro
            // 
            this.lbl_error_pro.AutoSize = true;
            this.lbl_error_pro.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_pro.Location = new System.Drawing.Point(79, 43);
            this.lbl_error_pro.Name = "lbl_error_pro";
            this.lbl_error_pro.Size = new System.Drawing.Size(159, 13);
            this.lbl_error_pro.TabIndex = 66;
            this.lbl_error_pro.Text = "Debe seleccionar un profesional";
            this.lbl_error_pro.Visible = false;
            // 
            // CancelarAtencionAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 512);
            this.Controls.Add(this.txt_idAfiliado);
            this.Controls.Add(this.btn_buscarAfiliado);
            this.Controls.Add(this.lbl_afiliados);
            this.Controls.Add(this.pan_canAfiliado);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_atras);
            this.Name = "CancelarAtencionAfiliado";
            this.Text = "Cancelar Atención Médica";
            this.Load += new System.EventHandler(this.CancelarAtencionAfiliado_Load);
            this.gpb_filtros.ResumeLayout(false);
            this.gpb_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnos)).EndInit();
            this.pan_canAfiliado.ResumeLayout(false);
            this.pan_canAfiliado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_filtros;
        private System.Windows.Forms.DateTimePicker dtp_fecha_turno;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_turnos;
        private System.Windows.Forms.Label lbl_nro_pagina;
        private System.Windows.Forms.Label lbl_nro_turnos;
        private System.Windows.Forms.Label lbl_cantidad_turnos;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_primera;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_ultima;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.CheckBox chk_buscar_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Label lbl_error_motivo;
        private System.Windows.Forms.Panel pan_canAfiliado;
        private System.Windows.Forms.TextBox txt_idAfiliado;
        private System.Windows.Forms.Button btn_buscarAfiliado;
        private System.Windows.Forms.Label lbl_afiliados;
        private System.Windows.Forms.Button btn_buscar_profesional;
        private System.Windows.Forms.TextBox txt_profesional;
        private System.Windows.Forms.Label lbl_profesionales;
        private System.Windows.Forms.ComboBox cmb_especialidades;
        private System.Windows.Forms.Label lbl_especialidades;
        private System.Windows.Forms.Label lbl_error_pro;
        private System.Windows.Forms.Label lbl_error_esp;
    }
}
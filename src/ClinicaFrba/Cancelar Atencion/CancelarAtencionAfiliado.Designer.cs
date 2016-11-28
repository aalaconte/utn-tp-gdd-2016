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
            this.txt_especialidad = new System.Windows.Forms.TextBox();
            this.lbl_especialidad = new System.Windows.Forms.Label();
            this.txt_apellido_profesional = new System.Windows.Forms.TextBox();
            this.txt_nombre_profesional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_profesional_nombre = new System.Windows.Forms.Label();
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
            this.gpb_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_filtros
            // 
            this.gpb_filtros.Controls.Add(this.chk_buscar_fecha);
            this.gpb_filtros.Controls.Add(this.dtp_fecha_turno);
            this.gpb_filtros.Controls.Add(this.txt_especialidad);
            this.gpb_filtros.Controls.Add(this.lbl_especialidad);
            this.gpb_filtros.Controls.Add(this.txt_apellido_profesional);
            this.gpb_filtros.Controls.Add(this.txt_nombre_profesional);
            this.gpb_filtros.Controls.Add(this.label1);
            this.gpb_filtros.Controls.Add(this.txt_profesional_nombre);
            this.gpb_filtros.Location = new System.Drawing.Point(12, 12);
            this.gpb_filtros.Name = "gpb_filtros";
            this.gpb_filtros.Size = new System.Drawing.Size(633, 163);
            this.gpb_filtros.TabIndex = 0;
            this.gpb_filtros.TabStop = false;
            this.gpb_filtros.Text = "Filtros";
            // 
            // chk_buscar_fecha
            // 
            this.chk_buscar_fecha.AutoSize = true;
            this.chk_buscar_fecha.Location = new System.Drawing.Point(399, 48);
            this.chk_buscar_fecha.Name = "chk_buscar_fecha";
            this.chk_buscar_fecha.Size = new System.Drawing.Size(107, 17);
            this.chk_buscar_fecha.TabIndex = 6;
            this.chk_buscar_fecha.Text = "Buscar por fecha";
            this.chk_buscar_fecha.UseVisualStyleBackColor = true;
            this.chk_buscar_fecha.CheckedChanged += new System.EventHandler(this.chk_buscar_fecha_CheckedChanged);
            // 
            // dtp_fecha_turno
            // 
            this.dtp_fecha_turno.Location = new System.Drawing.Point(399, 71);
            this.dtp_fecha_turno.Name = "dtp_fecha_turno";
            this.dtp_fecha_turno.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_turno.TabIndex = 1;
            // 
            // txt_especialidad
            // 
            this.txt_especialidad.Location = new System.Drawing.Point(111, 118);
            this.txt_especialidad.Name = "txt_especialidad";
            this.txt_especialidad.Size = new System.Drawing.Size(141, 20);
            this.txt_especialidad.TabIndex = 5;
            // 
            // lbl_especialidad
            // 
            this.lbl_especialidad.AutoSize = true;
            this.lbl_especialidad.Location = new System.Drawing.Point(6, 121);
            this.lbl_especialidad.Name = "lbl_especialidad";
            this.lbl_especialidad.Size = new System.Drawing.Size(67, 13);
            this.lbl_especialidad.TabIndex = 4;
            this.lbl_especialidad.Text = "Especialidad";
            // 
            // txt_apellido_profesional
            // 
            this.txt_apellido_profesional.Location = new System.Drawing.Point(111, 71);
            this.txt_apellido_profesional.Name = "txt_apellido_profesional";
            this.txt_apellido_profesional.Size = new System.Drawing.Size(141, 20);
            this.txt_apellido_profesional.TabIndex = 3;
            // 
            // txt_nombre_profesional
            // 
            this.txt_nombre_profesional.Location = new System.Drawing.Point(111, 26);
            this.txt_nombre_profesional.Name = "txt_nombre_profesional";
            this.txt_nombre_profesional.Size = new System.Drawing.Size(141, 20);
            this.txt_nombre_profesional.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellido Profesional";
            // 
            // txt_profesional_nombre
            // 
            this.txt_profesional_nombre.AutoSize = true;
            this.txt_profesional_nombre.Location = new System.Drawing.Point(6, 29);
            this.txt_profesional_nombre.Name = "txt_profesional_nombre";
            this.txt_profesional_nombre.Size = new System.Drawing.Size(99, 13);
            this.txt_profesional_nombre.TabIndex = 0;
            this.txt_profesional_nombre.Text = "Nombre Profesional";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(12, 182);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 1;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(570, 182);
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
            this.dgv_turnos.Location = new System.Drawing.Point(12, 211);
            this.dgv_turnos.MultiSelect = false;
            this.dgv_turnos.Name = "dgv_turnos";
            this.dgv_turnos.ReadOnly = true;
            this.dgv_turnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turnos.Size = new System.Drawing.Size(633, 163);
            this.dgv_turnos.TabIndex = 3;
            // 
            // lbl_nro_pagina
            // 
            this.lbl_nro_pagina.AutoSize = true;
            this.lbl_nro_pagina.Location = new System.Drawing.Point(12, 381);
            this.lbl_nro_pagina.Name = "lbl_nro_pagina";
            this.lbl_nro_pagina.Size = new System.Drawing.Size(84, 13);
            this.lbl_nro_pagina.TabIndex = 4;
            this.lbl_nro_pagina.Text = "labelNroPaginas";
            // 
            // lbl_nro_turnos
            // 
            this.lbl_nro_turnos.AutoSize = true;
            this.lbl_nro_turnos.Location = new System.Drawing.Point(566, 381);
            this.lbl_nro_turnos.Name = "lbl_nro_turnos";
            this.lbl_nro_turnos.Size = new System.Drawing.Size(79, 13);
            this.lbl_nro_turnos.TabIndex = 5;
            this.lbl_nro_turnos.Text = "labelNroTurnos";
            // 
            // lbl_cantidad_turnos
            // 
            this.lbl_cantidad_turnos.AutoSize = true;
            this.lbl_cantidad_turnos.Location = new System.Drawing.Point(461, 381);
            this.lbl_cantidad_turnos.Name = "lbl_cantidad_turnos";
            this.lbl_cantidad_turnos.Size = new System.Drawing.Size(99, 13);
            this.lbl_cantidad_turnos.TabIndex = 6;
            this.lbl_cantidad_turnos.Text = "Cantidad de turnos:";
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(12, 496);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 7;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(570, 496);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 8;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_primera
            // 
            this.btn_primera.Location = new System.Drawing.Point(12, 407);
            this.btn_primera.Name = "btn_primera";
            this.btn_primera.Size = new System.Drawing.Size(75, 23);
            this.btn_primera.TabIndex = 9;
            this.btn_primera.Text = "Primera";
            this.btn_primera.UseVisualStyleBackColor = true;
            this.btn_primera.Click += new System.EventHandler(this.btn_primera_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(93, 407);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_anterior.TabIndex = 10;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_ultima
            // 
            this.btn_ultima.Location = new System.Drawing.Point(570, 407);
            this.btn_ultima.Name = "btn_ultima";
            this.btn_ultima.Size = new System.Drawing.Size(75, 23);
            this.btn_ultima.TabIndex = 11;
            this.btn_ultima.Text = "Última";
            this.btn_ultima.UseVisualStyleBackColor = true;
            this.btn_ultima.Click += new System.EventHandler(this.btn_ultima_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(489, 407);
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
            this.label2.Location = new System.Drawing.Point(12, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Motivo de la cancelación:";
            // 
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(147, 448);
            this.txt_motivo.MaxLength = 255;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(330, 20);
            this.txt_motivo.TabIndex = 7;
            // 
            // lbl_error_motivo
            // 
            this.lbl_error_motivo.AutoSize = true;
            this.lbl_error_motivo.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_motivo.Location = new System.Drawing.Point(144, 471);
            this.lbl_error_motivo.Name = "lbl_error_motivo";
            this.lbl_error_motivo.Size = new System.Drawing.Size(125, 13);
            this.lbl_error_motivo.TabIndex = 14;
            this.lbl_error_motivo.Text = "Debe ingresar un motivo!";
            this.lbl_error_motivo.Visible = false;
            // 
            // CancelarAtencionAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 531);
            this.Controls.Add(this.lbl_error_motivo);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_ultima);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_primera);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.lbl_cantidad_turnos);
            this.Controls.Add(this.lbl_nro_turnos);
            this.Controls.Add(this.lbl_nro_pagina);
            this.Controls.Add(this.dgv_turnos);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.gpb_filtros);
            this.Name = "CancelarAtencionAfiliado";
            this.Text = "Cancelar Atención Médica";
            this.Load += new System.EventHandler(this.CancelarAtencionAfiliado_Load);
            this.gpb_filtros.ResumeLayout(false);
            this.gpb_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_filtros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_profesional_nombre;
        private System.Windows.Forms.Label lbl_especialidad;
        private System.Windows.Forms.TextBox txt_apellido_profesional;
        private System.Windows.Forms.TextBox txt_nombre_profesional;
        private System.Windows.Forms.TextBox txt_especialidad;
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
    }
}
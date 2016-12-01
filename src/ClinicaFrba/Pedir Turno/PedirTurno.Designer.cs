namespace ClinicaFrba.Pedir_Turno
{
    partial class PedirTurno
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
            this.lbl_profesional = new System.Windows.Forms.Label();
            this.txt_profesional = new System.Windows.Forms.TextBox();
            this.btn_buscar_profesional = new System.Windows.Forms.Button();
            this.lbl_especialidad = new System.Windows.Forms.Label();
            this.cmb_especialidad = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_error_turno = new System.Windows.Forms.Label();
            this.dgv_turnos_disponibles = new System.Windows.Forms.DataGridView();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_error_profesional = new System.Windows.Forms.Label();
            this.lbl_error_especialidad = new System.Windows.Forms.Label();
            this.lbl_error_horario = new System.Windows.Forms.Label();
            this.txtNroAfi = new System.Windows.Forms.TextBox();
            this.btnBuscarAfi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pan_pedirTurno = new System.Windows.Forms.Panel();
            this.lbl_error_afiliado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnos_disponibles)).BeginInit();
            this.pan_pedirTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_profesional
            // 
            this.lbl_profesional.AutoSize = true;
            this.lbl_profesional.Location = new System.Drawing.Point(12, 19);
            this.lbl_profesional.Name = "lbl_profesional";
            this.lbl_profesional.Size = new System.Drawing.Size(62, 13);
            this.lbl_profesional.TabIndex = 0;
            this.lbl_profesional.Text = "Profesional:";
            // 
            // txt_profesional
            // 
            this.txt_profesional.Enabled = false;
            this.txt_profesional.Location = new System.Drawing.Point(80, 16);
            this.txt_profesional.Name = "txt_profesional";
            this.txt_profesional.Size = new System.Drawing.Size(118, 20);
            this.txt_profesional.TabIndex = 1;
            // 
            // btn_buscar_profesional
            // 
            this.btn_buscar_profesional.Location = new System.Drawing.Point(204, 14);
            this.btn_buscar_profesional.Name = "btn_buscar_profesional";
            this.btn_buscar_profesional.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_profesional.TabIndex = 2;
            this.btn_buscar_profesional.Text = "Buscar";
            this.btn_buscar_profesional.UseVisualStyleBackColor = true;
            this.btn_buscar_profesional.Click += new System.EventHandler(this.btn_buscar_profesional_Click);
            // 
            // lbl_especialidad
            // 
            this.lbl_especialidad.AutoSize = true;
            this.lbl_especialidad.Location = new System.Drawing.Point(336, 3);
            this.lbl_especialidad.Name = "lbl_especialidad";
            this.lbl_especialidad.Size = new System.Drawing.Size(146, 13);
            this.lbl_especialidad.TabIndex = 3;
            this.lbl_especialidad.Text = "Seleccione una especialidad:";
            // 
            // cmb_especialidad
            // 
            this.cmb_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_especialidad.FormattingEnabled = true;
            this.cmb_especialidad.Location = new System.Drawing.Point(356, 19);
            this.cmb_especialidad.Name = "cmb_especialidad";
            this.cmb_especialidad.Size = new System.Drawing.Size(121, 21);
            this.cmb_especialidad.TabIndex = 4;
            this.cmb_especialidad.SelectedIndexChanged += new System.EventHandler(this.cmb_especialidad_SelectedIndexChanged);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(495, 324);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 8;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(414, 324);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_error_turno
            // 
            this.lbl_error_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_turno.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_turno.Location = new System.Drawing.Point(382, 236);
            this.lbl_error_turno.Name = "lbl_error_turno";
            this.lbl_error_turno.Size = new System.Drawing.Size(167, 21);
            this.lbl_error_turno.TabIndex = 13;
            this.lbl_error_turno.Text = "No hay turnos disponibles";
            this.lbl_error_turno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_error_turno.Visible = false;
            // 
            // dgv_turnos_disponibles
            // 
            this.dgv_turnos_disponibles.AllowUserToAddRows = false;
            this.dgv_turnos_disponibles.AllowUserToDeleteRows = false;
            this.dgv_turnos_disponibles.AllowUserToResizeRows = false;
            this.dgv_turnos_disponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_turnos_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turnos_disponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.fecha});
            this.dgv_turnos_disponibles.Location = new System.Drawing.Point(8, 72);
            this.dgv_turnos_disponibles.MultiSelect = false;
            this.dgv_turnos_disponibles.Name = "dgv_turnos_disponibles";
            this.dgv_turnos_disponibles.ReadOnly = true;
            this.dgv_turnos_disponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turnos_disponibles.Size = new System.Drawing.Size(541, 150);
            this.dgv_turnos_disponibles.TabIndex = 15;
            // 
            // dia
            // 
            this.dia.HeaderText = "Dia";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // lbl_error_profesional
            // 
            this.lbl_error_profesional.AutoSize = true;
            this.lbl_error_profesional.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_profesional.Location = new System.Drawing.Point(43, 45);
            this.lbl_error_profesional.Name = "lbl_error_profesional";
            this.lbl_error_profesional.Size = new System.Drawing.Size(159, 13);
            this.lbl_error_profesional.TabIndex = 16;
            this.lbl_error_profesional.Text = "Debe seleccionar un profesional";
            this.lbl_error_profesional.Visible = false;
            // 
            // lbl_error_especialidad
            // 
            this.lbl_error_especialidad.AutoSize = true;
            this.lbl_error_especialidad.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_especialidad.Location = new System.Drawing.Point(336, 45);
            this.lbl_error_especialidad.Name = "lbl_error_especialidad";
            this.lbl_error_especialidad.Size = new System.Drawing.Size(173, 13);
            this.lbl_error_especialidad.TabIndex = 17;
            this.lbl_error_especialidad.Text = "Debe seleccionar una especialidad";
            this.lbl_error_especialidad.Visible = false;
            // 
            // lbl_error_horario
            // 
            this.lbl_error_horario.AutoSize = true;
            this.lbl_error_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_error_horario.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_horario.Location = new System.Drawing.Point(5, 236);
            this.lbl_error_horario.Name = "lbl_error_horario";
            this.lbl_error_horario.Size = new System.Drawing.Size(229, 15);
            this.lbl_error_horario.TabIndex = 18;
            this.lbl_error_horario.Text = "Debe seleccionar un horario de atención";
            this.lbl_error_horario.Visible = false;
            // 
            // txtNroAfi
            // 
            this.txtNroAfi.Enabled = false;
            this.txtNroAfi.Location = new System.Drawing.Point(76, 12);
            this.txtNroAfi.Name = "txtNroAfi";
            this.txtNroAfi.ReadOnly = true;
            this.txtNroAfi.Size = new System.Drawing.Size(122, 20);
            this.txtNroAfi.TabIndex = 65;
            // 
            // btnBuscarAfi
            // 
            this.btnBuscarAfi.Location = new System.Drawing.Point(204, 12);
            this.btnBuscarAfi.Name = "btnBuscarAfi";
            this.btnBuscarAfi.Size = new System.Drawing.Size(120, 20);
            this.btnBuscarAfi.TabIndex = 64;
            this.btnBuscarAfi.Text = "Buscar";
            this.btnBuscarAfi.UseVisualStyleBackColor = true;
            this.btnBuscarAfi.Visible = false;
            this.btnBuscarAfi.Click += new System.EventHandler(this.btnBuscarAfi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Nro Afiliado";
            // 
            // pan_pedirTurno
            // 
            this.pan_pedirTurno.Controls.Add(this.lbl_error_horario);
            this.pan_pedirTurno.Controls.Add(this.lbl_error_especialidad);
            this.pan_pedirTurno.Controls.Add(this.lbl_error_profesional);
            this.pan_pedirTurno.Controls.Add(this.dgv_turnos_disponibles);
            this.pan_pedirTurno.Controls.Add(this.lbl_error_turno);
            this.pan_pedirTurno.Controls.Add(this.cmb_especialidad);
            this.pan_pedirTurno.Controls.Add(this.lbl_especialidad);
            this.pan_pedirTurno.Controls.Add(this.btn_buscar_profesional);
            this.pan_pedirTurno.Controls.Add(this.txt_profesional);
            this.pan_pedirTurno.Controls.Add(this.lbl_profesional);
            this.pan_pedirTurno.Location = new System.Drawing.Point(12, 51);
            this.pan_pedirTurno.Name = "pan_pedirTurno";
            this.pan_pedirTurno.Size = new System.Drawing.Size(558, 267);
            this.pan_pedirTurno.TabIndex = 66;
            this.pan_pedirTurno.Visible = false;
            // 
            // lbl_error_afiliado
            // 
            this.lbl_error_afiliado.AutoSize = true;
            this.lbl_error_afiliado.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_afiliado.Location = new System.Drawing.Point(73, 35);
            this.lbl_error_afiliado.Name = "lbl_error_afiliado";
            this.lbl_error_afiliado.Size = new System.Drawing.Size(141, 13);
            this.lbl_error_afiliado.TabIndex = 19;
            this.lbl_error_afiliado.Text = "Debe seleccionar un afiliado";
            this.lbl_error_afiliado.Visible = false;
            // 
            // PedirTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 353);
            this.Controls.Add(this.lbl_error_afiliado);
            this.Controls.Add(this.pan_pedirTurno);
            this.Controls.Add(this.txtNroAfi);
            this.Controls.Add(this.btnBuscarAfi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Name = "PedirTurno";
            this.Text = "Pedir Turno";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnos_disponibles)).EndInit();
            this.pan_pedirTurno.ResumeLayout(false);
            this.pan_pedirTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_profesional;
        private System.Windows.Forms.TextBox txt_profesional;
        private System.Windows.Forms.Button btn_buscar_profesional;
        private System.Windows.Forms.Label lbl_especialidad;
        private System.Windows.Forms.ComboBox cmb_especialidad;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_error_turno;
        private System.Windows.Forms.DataGridView dgv_turnos_disponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Label lbl_error_profesional;
        private System.Windows.Forms.Label lbl_error_especialidad;
        private System.Windows.Forms.Label lbl_error_horario;
        private System.Windows.Forms.TextBox txtNroAfi;
        private System.Windows.Forms.Button btnBuscarAfi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pan_pedirTurno;
        private System.Windows.Forms.Label lbl_error_afiliado;
    }
}
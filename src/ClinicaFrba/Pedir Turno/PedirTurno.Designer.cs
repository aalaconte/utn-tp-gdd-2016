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
            this.lbl_fecha_turno = new System.Windows.Forms.Label();
            this.dtp_fecha_turno = new System.Windows.Forms.DateTimePicker();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_error_sin_agenda = new System.Windows.Forms.Label();
            this.cmb_hora_turno = new System.Windows.Forms.ComboBox();
            this.lbl_hora_turno = new System.Windows.Forms.Label();
            this.lbl_error_turno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_profesional
            // 
            this.lbl_profesional.AutoSize = true;
            this.lbl_profesional.Location = new System.Drawing.Point(12, 35);
            this.lbl_profesional.Name = "lbl_profesional";
            this.lbl_profesional.Size = new System.Drawing.Size(62, 13);
            this.lbl_profesional.TabIndex = 0;
            this.lbl_profesional.Text = "Profesional:";
            // 
            // txt_profesional
            // 
            this.txt_profesional.Enabled = false;
            this.txt_profesional.Location = new System.Drawing.Point(80, 32);
            this.txt_profesional.Name = "txt_profesional";
            this.txt_profesional.Size = new System.Drawing.Size(118, 20);
            this.txt_profesional.TabIndex = 1;
            // 
            // btn_buscar_profesional
            // 
            this.btn_buscar_profesional.Location = new System.Drawing.Point(123, 58);
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
            this.lbl_especialidad.Location = new System.Drawing.Point(339, 35);
            this.lbl_especialidad.Name = "lbl_especialidad";
            this.lbl_especialidad.Size = new System.Drawing.Size(146, 13);
            this.lbl_especialidad.TabIndex = 3;
            this.lbl_especialidad.Text = "Seleccione una especialidad:";
            // 
            // cmb_especialidad
            // 
            this.cmb_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_especialidad.FormattingEnabled = true;
            this.cmb_especialidad.Location = new System.Drawing.Point(353, 58);
            this.cmb_especialidad.Name = "cmb_especialidad";
            this.cmb_especialidad.Size = new System.Drawing.Size(121, 21);
            this.cmb_especialidad.TabIndex = 4;
            this.cmb_especialidad.SelectedIndexChanged += new System.EventHandler(this.cmb_especialidad_SelectedIndexChanged);
            // 
            // lbl_fecha_turno
            // 
            this.lbl_fecha_turno.AutoSize = true;
            this.lbl_fecha_turno.Location = new System.Drawing.Point(12, 120);
            this.lbl_fecha_turno.Name = "lbl_fecha_turno";
            this.lbl_fecha_turno.Size = new System.Drawing.Size(114, 13);
            this.lbl_fecha_turno.TabIndex = 6;
            this.lbl_fecha_turno.Text = "Seleccione una fecha:";
            // 
            // dtp_fecha_turno
            // 
            this.dtp_fecha_turno.Enabled = false;
            this.dtp_fecha_turno.Location = new System.Drawing.Point(24, 145);
            this.dtp_fecha_turno.Name = "dtp_fecha_turno";
            this.dtp_fecha_turno.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_turno.TabIndex = 7;
            this.dtp_fecha_turno.ValueChanged += new System.EventHandler(this.dtp_fecha_turno_ValueChanged);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(495, 315);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 8;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(414, 315);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_error_sin_agenda
            // 
            this.lbl_error_sin_agenda.AutoSize = true;
            this.lbl_error_sin_agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_sin_agenda.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_sin_agenda.Location = new System.Drawing.Point(23, 168);
            this.lbl_error_sin_agenda.Name = "lbl_error_sin_agenda";
            this.lbl_error_sin_agenda.Size = new System.Drawing.Size(253, 15);
            this.lbl_error_sin_agenda.TabIndex = 10;
            this.lbl_error_sin_agenda.Text = "El profesional no posee agendas disponibles";
            this.lbl_error_sin_agenda.Visible = false;
            // 
            // cmb_hora_turno
            // 
            this.cmb_hora_turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_turno.Enabled = false;
            this.cmb_hora_turno.FormattingEnabled = true;
            this.cmb_hora_turno.Location = new System.Drawing.Point(353, 144);
            this.cmb_hora_turno.Name = "cmb_hora_turno";
            this.cmb_hora_turno.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_turno.TabIndex = 11;
            // 
            // lbl_hora_turno
            // 
            this.lbl_hora_turno.AutoSize = true;
            this.lbl_hora_turno.Location = new System.Drawing.Point(339, 120);
            this.lbl_hora_turno.Name = "lbl_hora_turno";
            this.lbl_hora_turno.Size = new System.Drawing.Size(113, 13);
            this.lbl_hora_turno.TabIndex = 12;
            this.lbl_hora_turno.Text = "Seleccione un horario:";
            // 
            // lbl_error_turno
            // 
            this.lbl_error_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_turno.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_turno.Location = new System.Drawing.Point(339, 168);
            this.lbl_error_turno.Name = "lbl_error_turno";
            this.lbl_error_turno.Size = new System.Drawing.Size(167, 37);
            this.lbl_error_turno.TabIndex = 13;
            this.lbl_error_turno.Text = "No hay turnos disponibles para la fecha seleccionada";
            this.lbl_error_turno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_error_turno.Visible = false;
            // 
            // PedirTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 350);
            this.Controls.Add(this.lbl_error_turno);
            this.Controls.Add(this.lbl_hora_turno);
            this.Controls.Add(this.cmb_hora_turno);
            this.Controls.Add(this.lbl_error_sin_agenda);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.dtp_fecha_turno);
            this.Controls.Add(this.lbl_fecha_turno);
            this.Controls.Add(this.cmb_especialidad);
            this.Controls.Add(this.lbl_especialidad);
            this.Controls.Add(this.btn_buscar_profesional);
            this.Controls.Add(this.txt_profesional);
            this.Controls.Add(this.lbl_profesional);
            this.Name = "PedirTurno";
            this.Text = "Pedir Turno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_profesional;
        private System.Windows.Forms.TextBox txt_profesional;
        private System.Windows.Forms.Button btn_buscar_profesional;
        private System.Windows.Forms.Label lbl_especialidad;
        private System.Windows.Forms.ComboBox cmb_especialidad;
        private System.Windows.Forms.Label lbl_fecha_turno;
        private System.Windows.Forms.DateTimePicker dtp_fecha_turno;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_error_sin_agenda;
        private System.Windows.Forms.ComboBox cmb_hora_turno;
        private System.Windows.Forms.Label lbl_hora_turno;
        private System.Windows.Forms.Label lbl_error_turno;
    }
}
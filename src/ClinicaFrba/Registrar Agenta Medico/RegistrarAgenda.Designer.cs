namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class RegistrarAgenda
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
            this.lbl_profesionales = new System.Windows.Forms.Label();
            this.cmb_especialidad = new System.Windows.Forms.Label();
            this.cmb_especialidades = new System.Windows.Forms.ComboBox();
            this.lbl_dia_atencion = new System.Windows.Forms.Label();
            this.cmb_dia_atencion = new System.Windows.Forms.ComboBox();
            this.lbl_hora_desde = new System.Windows.Forms.Label();
            this.lbl_hora_hasta = new System.Windows.Forms.Label();
            this.cmb_hora_desde = new System.Windows.Forms.ComboBox();
            this.cmb_hora_hasta = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_profesional = new System.Windows.Forms.TextBox();
            this.btn_buscar_profesional = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_profesionales
            // 
            this.lbl_profesionales.AutoSize = true;
            this.lbl_profesionales.Location = new System.Drawing.Point(12, 36);
            this.lbl_profesionales.Name = "lbl_profesionales";
            this.lbl_profesionales.Size = new System.Drawing.Size(62, 13);
            this.lbl_profesionales.TabIndex = 1;
            this.lbl_profesionales.Text = "Profesional:";
            // 
            // cmb_especialidad
            // 
            this.cmb_especialidad.AutoSize = true;
            this.cmb_especialidad.Location = new System.Drawing.Point(12, 68);
            this.cmb_especialidad.Name = "cmb_especialidad";
            this.cmb_especialidad.Size = new System.Drawing.Size(146, 13);
            this.cmb_especialidad.TabIndex = 2;
            this.cmb_especialidad.Text = "Seleccione una especialidad:";
            // 
            // cmb_especialidades
            // 
            this.cmb_especialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_especialidades.FormattingEnabled = true;
            this.cmb_especialidades.Location = new System.Drawing.Point(174, 65);
            this.cmb_especialidades.Name = "cmb_especialidades";
            this.cmb_especialidades.Size = new System.Drawing.Size(121, 21);
            this.cmb_especialidades.TabIndex = 3;
            // 
            // lbl_dia_atencion
            // 
            this.lbl_dia_atencion.AutoSize = true;
            this.lbl_dia_atencion.Location = new System.Drawing.Point(12, 101);
            this.lbl_dia_atencion.Name = "lbl_dia_atencion";
            this.lbl_dia_atencion.Size = new System.Drawing.Size(156, 13);
            this.lbl_dia_atencion.TabIndex = 4;
            this.lbl_dia_atencion.Text = "Seleccione un día de atención:";
            // 
            // cmb_dia_atencion
            // 
            this.cmb_dia_atencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_dia_atencion.FormattingEnabled = true;
            this.cmb_dia_atencion.Location = new System.Drawing.Point(174, 98);
            this.cmb_dia_atencion.Name = "cmb_dia_atencion";
            this.cmb_dia_atencion.Size = new System.Drawing.Size(121, 21);
            this.cmb_dia_atencion.TabIndex = 5;
            // 
            // lbl_hora_desde
            // 
            this.lbl_hora_desde.AutoSize = true;
            this.lbl_hora_desde.Location = new System.Drawing.Point(12, 142);
            this.lbl_hora_desde.Name = "lbl_hora_desde";
            this.lbl_hora_desde.Size = new System.Drawing.Size(65, 13);
            this.lbl_hora_desde.TabIndex = 6;
            this.lbl_hora_desde.Text = "Hora desde:";
            // 
            // lbl_hora_hasta
            // 
            this.lbl_hora_hasta.AutoSize = true;
            this.lbl_hora_hasta.Location = new System.Drawing.Point(189, 142);
            this.lbl_hora_hasta.Name = "lbl_hora_hasta";
            this.lbl_hora_hasta.Size = new System.Drawing.Size(62, 13);
            this.lbl_hora_hasta.TabIndex = 7;
            this.lbl_hora_hasta.Text = "Hora hasta:";
            // 
            // cmb_hora_desde
            // 
            this.cmb_hora_desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_desde.FormattingEnabled = true;
            this.cmb_hora_desde.Location = new System.Drawing.Point(15, 158);
            this.cmb_hora_desde.Name = "cmb_hora_desde";
            this.cmb_hora_desde.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_desde.TabIndex = 8;
            // 
            // cmb_hora_hasta
            // 
            this.cmb_hora_hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_hasta.FormattingEnabled = true;
            this.cmb_hora_hasta.Location = new System.Drawing.Point(192, 158);
            this.cmb_hora_hasta.Name = "cmb_hora_hasta";
            this.cmb_hora_hasta.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_hasta.TabIndex = 9;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(267, 241);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 10;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(186, 241);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_profesional
            // 
            this.txt_profesional.Enabled = false;
            this.txt_profesional.Location = new System.Drawing.Point(80, 33);
            this.txt_profesional.Name = "txt_profesional";
            this.txt_profesional.Size = new System.Drawing.Size(131, 20);
            this.txt_profesional.TabIndex = 12;
            // 
            // btn_buscar_profesional
            // 
            this.btn_buscar_profesional.Location = new System.Drawing.Point(220, 31);
            this.btn_buscar_profesional.Name = "btn_buscar_profesional";
            this.btn_buscar_profesional.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_profesional.TabIndex = 13;
            this.btn_buscar_profesional.Text = "Buscar";
            this.btn_buscar_profesional.UseVisualStyleBackColor = true;
            this.btn_buscar_profesional.Click += new System.EventHandler(this.btn_buscar_profesional_Click);
            // 
            // RegistrarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 276);
            this.Controls.Add(this.btn_buscar_profesional);
            this.Controls.Add(this.txt_profesional);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cmb_hora_hasta);
            this.Controls.Add(this.cmb_hora_desde);
            this.Controls.Add(this.lbl_hora_hasta);
            this.Controls.Add(this.lbl_hora_desde);
            this.Controls.Add(this.cmb_dia_atencion);
            this.Controls.Add(this.lbl_dia_atencion);
            this.Controls.Add(this.cmb_especialidades);
            this.Controls.Add(this.cmb_especialidad);
            this.Controls.Add(this.lbl_profesionales);
            this.Name = "RegistrarAgenda";
            this.Text = "Registrar Agenda de Médico";
            this.Load += new System.EventHandler(this.RegistrarAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_profesionales;
        private System.Windows.Forms.Label cmb_especialidad;
        private System.Windows.Forms.ComboBox cmb_especialidades;
        private System.Windows.Forms.Label lbl_dia_atencion;
        private System.Windows.Forms.ComboBox cmb_dia_atencion;
        private System.Windows.Forms.Label lbl_hora_desde;
        private System.Windows.Forms.Label lbl_hora_hasta;
        private System.Windows.Forms.ComboBox cmb_hora_desde;
        private System.Windows.Forms.ComboBox cmb_hora_hasta;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_profesional;
        private System.Windows.Forms.Button btn_buscar_profesional;
    }
}
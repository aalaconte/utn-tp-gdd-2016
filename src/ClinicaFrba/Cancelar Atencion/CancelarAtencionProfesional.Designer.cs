namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarAtencionProfesional
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
            this.dtp_fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.chk_rango_fechas = new System.Windows.Forms.CheckBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_motivo_cancelacion = new System.Windows.Forms.TextBox();
            this.lbl_motivo_cancelacion = new System.Windows.Forms.Label();
            this.lbl_error_motivo = new System.Windows.Forms.Label();
            this.pan_CancelarPro = new System.Windows.Forms.Panel();
            this.btn_buscar_profesional = new System.Windows.Forms.Button();
            this.txt_profesional = new System.Windows.Forms.TextBox();
            this.lbl_profesionales = new System.Windows.Forms.Label();
            this.pan_CancelarPro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.Location = new System.Drawing.Point(11, 18);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_desde.TabIndex = 0;
            this.dtp_fecha_desde.ValueChanged += new System.EventHandler(this.dtp_fecha_desde_ValueChanged);
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.Enabled = false;
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(233, 18);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_hasta.TabIndex = 2;
            // 
            // chk_rango_fechas
            // 
            this.chk_rango_fechas.AutoSize = true;
            this.chk_rango_fechas.Location = new System.Drawing.Point(233, 53);
            this.chk_rango_fechas.Name = "chk_rango_fechas";
            this.chk_rango_fechas.Size = new System.Drawing.Size(158, 17);
            this.chk_rango_fechas.TabIndex = 3;
            this.chk_rango_fechas.Text = "¿Desea cancelar un rango?";
            this.chk_rango_fechas.UseVisualStyleBackColor = true;
            this.chk_rango_fechas.CheckedChanged += new System.EventHandler(this.chk_rango_fechas_CheckedChanged);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(368, 114);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(287, 114);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_motivo_cancelacion
            // 
            this.txt_motivo_cancelacion.Location = new System.Drawing.Point(11, 92);
            this.txt_motivo_cancelacion.MaxLength = 255;
            this.txt_motivo_cancelacion.Name = "txt_motivo_cancelacion";
            this.txt_motivo_cancelacion.Size = new System.Drawing.Size(200, 20);
            this.txt_motivo_cancelacion.TabIndex = 6;
            // 
            // lbl_motivo_cancelacion
            // 
            this.lbl_motivo_cancelacion.AutoSize = true;
            this.lbl_motivo_cancelacion.Location = new System.Drawing.Point(10, 76);
            this.lbl_motivo_cancelacion.Name = "lbl_motivo_cancelacion";
            this.lbl_motivo_cancelacion.Size = new System.Drawing.Size(126, 13);
            this.lbl_motivo_cancelacion.TabIndex = 7;
            this.lbl_motivo_cancelacion.Text = "Motivo de la cancelación";
            // 
            // lbl_error_motivo
            // 
            this.lbl_error_motivo.AutoSize = true;
            this.lbl_error_motivo.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_motivo.Location = new System.Drawing.Point(13, 123);
            this.lbl_error_motivo.Name = "lbl_error_motivo";
            this.lbl_error_motivo.Size = new System.Drawing.Size(125, 13);
            this.lbl_error_motivo.TabIndex = 8;
            this.lbl_error_motivo.Text = "Debe ingresar un motivo!";
            this.lbl_error_motivo.Visible = false;
            // 
            // pan_CancelarPro
            // 
            this.pan_CancelarPro.Controls.Add(this.lbl_error_motivo);
            this.pan_CancelarPro.Controls.Add(this.lbl_motivo_cancelacion);
            this.pan_CancelarPro.Controls.Add(this.txt_motivo_cancelacion);
            this.pan_CancelarPro.Controls.Add(this.btn_cancelar);
            this.pan_CancelarPro.Controls.Add(this.btn_aceptar);
            this.pan_CancelarPro.Controls.Add(this.chk_rango_fechas);
            this.pan_CancelarPro.Controls.Add(this.dtp_fecha_hasta);
            this.pan_CancelarPro.Controls.Add(this.dtp_fecha_desde);
            this.pan_CancelarPro.Location = new System.Drawing.Point(9, 38);
            this.pan_CancelarPro.Name = "pan_CancelarPro";
            this.pan_CancelarPro.Size = new System.Drawing.Size(474, 148);
            this.pan_CancelarPro.TabIndex = 9;
            this.pan_CancelarPro.Visible = false;
            // 
            // btn_buscar_profesional
            // 
            this.btn_buscar_profesional.Location = new System.Drawing.Point(216, 12);
            this.btn_buscar_profesional.Name = "btn_buscar_profesional";
            this.btn_buscar_profesional.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_profesional.TabIndex = 40;
            this.btn_buscar_profesional.Text = "Seleccionar";
            this.btn_buscar_profesional.UseVisualStyleBackColor = true;
            this.btn_buscar_profesional.Click += new System.EventHandler(this.btn_buscar_profesional_Click);
            // 
            // txt_profesional
            // 
            this.txt_profesional.Enabled = false;
            this.txt_profesional.Location = new System.Drawing.Point(76, 14);
            this.txt_profesional.Name = "txt_profesional";
            this.txt_profesional.ReadOnly = true;
            this.txt_profesional.Size = new System.Drawing.Size(131, 20);
            this.txt_profesional.TabIndex = 39;
            // 
            // lbl_profesionales
            // 
            this.lbl_profesionales.AutoSize = true;
            this.lbl_profesionales.Location = new System.Drawing.Point(8, 17);
            this.lbl_profesionales.Name = "lbl_profesionales";
            this.lbl_profesionales.Size = new System.Drawing.Size(62, 13);
            this.lbl_profesionales.TabIndex = 38;
            this.lbl_profesionales.Text = "Profesional:";
            // 
            // CancelarAtencionProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 198);
            this.Controls.Add(this.btn_buscar_profesional);
            this.Controls.Add(this.txt_profesional);
            this.Controls.Add(this.lbl_profesionales);
            this.Controls.Add(this.pan_CancelarPro);
            this.Name = "CancelarAtencionProfesional";
            this.Text = "Cancelar Atencion Médica";
            this.Load += new System.EventHandler(this.CancelarAtencionProfesional_Load);
            this.pan_CancelarPro.ResumeLayout(false);
            this.pan_CancelarPro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_fecha_desde;
        private System.Windows.Forms.DateTimePicker dtp_fecha_hasta;
        private System.Windows.Forms.CheckBox chk_rango_fechas;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_motivo_cancelacion;
        private System.Windows.Forms.Label lbl_motivo_cancelacion;
        private System.Windows.Forms.Label lbl_error_motivo;
        private System.Windows.Forms.Panel pan_CancelarPro;
        private System.Windows.Forms.Button btn_buscar_profesional;
        private System.Windows.Forms.TextBox txt_profesional;
        private System.Windows.Forms.Label lbl_profesionales;
    }
}
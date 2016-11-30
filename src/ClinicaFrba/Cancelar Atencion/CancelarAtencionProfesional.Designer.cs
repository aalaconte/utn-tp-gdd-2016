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
            this.SuspendLayout();
            // 
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.Location = new System.Drawing.Point(13, 23);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_desde.TabIndex = 0;
            this.dtp_fecha_desde.ValueChanged += new System.EventHandler(this.dtp_fecha_desde_ValueChanged);
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.Enabled = false;
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(235, 23);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_hasta.TabIndex = 2;
            // 
            // chk_rango_fechas
            // 
            this.chk_rango_fechas.AutoSize = true;
            this.chk_rango_fechas.Location = new System.Drawing.Point(235, 58);
            this.chk_rango_fechas.Name = "chk_rango_fechas";
            this.chk_rango_fechas.Size = new System.Drawing.Size(158, 17);
            this.chk_rango_fechas.TabIndex = 3;
            this.chk_rango_fechas.Text = "¿Desea cancelar un rango?";
            this.chk_rango_fechas.UseVisualStyleBackColor = true;
            this.chk_rango_fechas.CheckedChanged += new System.EventHandler(this.chk_rango_fechas_CheckedChanged);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(370, 119);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(289, 119);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_motivo_cancelacion
            // 
            this.txt_motivo_cancelacion.Location = new System.Drawing.Point(13, 97);
            this.txt_motivo_cancelacion.MaxLength = 255;
            this.txt_motivo_cancelacion.Name = "txt_motivo_cancelacion";
            this.txt_motivo_cancelacion.Size = new System.Drawing.Size(200, 20);
            this.txt_motivo_cancelacion.TabIndex = 6;
            // 
            // lbl_motivo_cancelacion
            // 
            this.lbl_motivo_cancelacion.AutoSize = true;
            this.lbl_motivo_cancelacion.Location = new System.Drawing.Point(12, 81);
            this.lbl_motivo_cancelacion.Name = "lbl_motivo_cancelacion";
            this.lbl_motivo_cancelacion.Size = new System.Drawing.Size(126, 13);
            this.lbl_motivo_cancelacion.TabIndex = 7;
            this.lbl_motivo_cancelacion.Text = "Motivo de la cancelación";
            // 
            // lbl_error_motivo
            // 
            this.lbl_error_motivo.AutoSize = true;
            this.lbl_error_motivo.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_motivo.Location = new System.Drawing.Point(15, 128);
            this.lbl_error_motivo.Name = "lbl_error_motivo";
            this.lbl_error_motivo.Size = new System.Drawing.Size(125, 13);
            this.lbl_error_motivo.TabIndex = 8;
            this.lbl_error_motivo.Text = "Debe ingresar un motivo!";
            this.lbl_error_motivo.Visible = false;
            // 
            // CancelarAtencionProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 154);
            this.Controls.Add(this.lbl_error_motivo);
            this.Controls.Add(this.lbl_motivo_cancelacion);
            this.Controls.Add(this.txt_motivo_cancelacion);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.chk_rango_fechas);
            this.Controls.Add(this.dtp_fecha_hasta);
            this.Controls.Add(this.dtp_fecha_desde);
            this.Name = "CancelarAtencionProfesional";
            this.Text = "Cancelar Atencion Médica";
            this.Load += new System.EventHandler(this.CancelarAtencionProfesional_Load);
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
    }
}
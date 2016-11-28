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
            this.rbt_rango_fechas = new System.Windows.Forms.RadioButton();
            this.dtp_fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.rbt_fecha_particular = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.Location = new System.Drawing.Point(189, 27);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_desde.TabIndex = 0;
            // 
            // rbt_rango_fechas
            // 
            this.rbt_rango_fechas.AutoSize = true;
            this.rbt_rango_fechas.Location = new System.Drawing.Point(12, 30);
            this.rbt_rango_fechas.Name = "rbt_rango_fechas";
            this.rbt_rango_fechas.Size = new System.Drawing.Size(147, 17);
            this.rbt_rango_fechas.TabIndex = 1;
            this.rbt_rango_fechas.TabStop = true;
            this.rbt_rango_fechas.Text = "Cancelar rango de fechas";
            this.rbt_rango_fechas.UseVisualStyleBackColor = true;
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(411, 27);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_hasta.TabIndex = 2;
            // 
            // rbt_fecha_particular
            // 
            this.rbt_fecha_particular.AutoSize = true;
            this.rbt_fecha_particular.Location = new System.Drawing.Point(12, 67);
            this.rbt_fecha_particular.Name = "rbt_fecha_particular";
            this.rbt_fecha_particular.Size = new System.Drawing.Size(164, 17);
            this.rbt_fecha_particular.TabIndex = 3;
            this.rbt_fecha_particular.TabStop = true;
            this.rbt_fecha_particular.Text = "Cancelar una fecha particular";
            this.rbt_fecha_particular.UseVisualStyleBackColor = true;
            // 
            // CancelarAtencionProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 396);
            this.Controls.Add(this.rbt_fecha_particular);
            this.Controls.Add(this.dtp_fecha_hasta);
            this.Controls.Add(this.rbt_rango_fechas);
            this.Controls.Add(this.dtp_fecha_desde);
            this.Name = "CancelarAtencionProfesional";
            this.Text = "Cancelar Atencion Médica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_fecha_desde;
        private System.Windows.Forms.RadioButton rbt_rango_fechas;
        private System.Windows.Forms.DateTimePicker dtp_fecha_hasta;
        private System.Windows.Forms.RadioButton rbt_fecha_particular;
    }
}
namespace ClinicaFrba.Registro_Llegada
{
    partial class HoraLlegada
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
            this.dtp_HoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_horaLlegada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_HoraLlegada
            // 
            this.dtp_HoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_HoraLlegada.Location = new System.Drawing.Point(111, 52);
            this.dtp_HoraLlegada.Name = "dtp_HoraLlegada";
            this.dtp_HoraLlegada.ShowUpDown = true;
            this.dtp_HoraLlegada.Size = new System.Drawing.Size(113, 20);
            this.dtp_HoraLlegada.TabIndex = 0;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(49, 87);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(90, 25);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(180, 87);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 24);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_horaLlegada
            // 
            this.lbl_horaLlegada.AutoSize = true;
            this.lbl_horaLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horaLlegada.Location = new System.Drawing.Point(12, 19);
            this.lbl_horaLlegada.Name = "lbl_horaLlegada";
            this.lbl_horaLlegada.Size = new System.Drawing.Size(332, 20);
            this.lbl_horaLlegada.TabIndex = 3;
            this.lbl_horaLlegada.Text = "Ingrese el horario de llegada del Afiliado";
            // 
            // HoraLlegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 125);
            this.Controls.Add(this.lbl_horaLlegada);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.dtp_HoraLlegada);
            this.Name = "HoraLlegada";
            this.Text = "HoraLlegada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_horaLlegada;
        private System.Windows.Forms.DateTimePicker dtp_HoraLlegada;
    }
}
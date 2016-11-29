namespace ClinicaFrba.Registro_Resultado
{
    partial class HoraResultado
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
            this.lbl_horaResultado = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.dtp_HoraResultado = new System.Windows.Forms.DateTimePicker();
            this.chb_ocurrioAtencion = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_horaResultado
            // 
            this.lbl_horaResultado.AutoSize = true;
            this.lbl_horaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horaResultado.Location = new System.Drawing.Point(12, 54);
            this.lbl_horaResultado.Name = "lbl_horaResultado";
            this.lbl_horaResultado.Size = new System.Drawing.Size(298, 16);
            this.lbl_horaResultado.TabIndex = 7;
            this.lbl_horaResultado.Text = "Ingrese la hora en la que ocurrio la misma";
            this.lbl_horaResultado.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(220, 88);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 24);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(102, 88);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(90, 25);
            this.btn_Aceptar.TabIndex = 5;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // dtp_HoraResultado
            // 
            this.dtp_HoraResultado.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_HoraResultado.Location = new System.Drawing.Point(324, 54);
            this.dtp_HoraResultado.Name = "dtp_HoraResultado";
            this.dtp_HoraResultado.ShowUpDown = true;
            this.dtp_HoraResultado.Size = new System.Drawing.Size(113, 20);
            this.dtp_HoraResultado.TabIndex = 4;
            this.dtp_HoraResultado.Visible = false;
            // 
            // chb_ocurrioAtencion
            // 
            this.chb_ocurrioAtencion.AutoSize = true;
            this.chb_ocurrioAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_ocurrioAtencion.Location = new System.Drawing.Point(28, 21);
            this.chb_ocurrioAtencion.Name = "chb_ocurrioAtencion";
            this.chb_ocurrioAtencion.Size = new System.Drawing.Size(282, 20);
            this.chb_ocurrioAtencion.TabIndex = 8;
            this.chb_ocurrioAtencion.Text = "Se realizó la consulta seleccionada?";
            this.chb_ocurrioAtencion.UseVisualStyleBackColor = true;
            this.chb_ocurrioAtencion.CheckedChanged += new System.EventHandler(this.chb_ocurrioAtencion_CheckedChanged);
            // 
            // HoraResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 124);
            this.Controls.Add(this.chb_ocurrioAtencion);
            this.Controls.Add(this.lbl_horaResultado);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.dtp_HoraResultado);
            this.Name = "HoraResultado";
            this.Text = "HoraResultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_horaResultado;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DateTimePicker dtp_HoraResultado;
        private System.Windows.Forms.CheckBox chb_ocurrioAtencion;
    }
}
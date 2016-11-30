namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarAdmin
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
            this.cb_TipoCan = new System.Windows.Forms.ComboBox();
            this.lbl_tcan = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_TipoCan
            // 
            this.cb_TipoCan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoCan.FormattingEnabled = true;
            this.cb_TipoCan.Location = new System.Drawing.Point(57, 25);
            this.cb_TipoCan.Name = "cb_TipoCan";
            this.cb_TipoCan.Size = new System.Drawing.Size(179, 21);
            this.cb_TipoCan.TabIndex = 0;
            // 
            // lbl_tcan
            // 
            this.lbl_tcan.AutoSize = true;
            this.lbl_tcan.Location = new System.Drawing.Point(25, 9);
            this.lbl_tcan.Name = "lbl_tcan";
            this.lbl_tcan.Size = new System.Drawing.Size(257, 13);
            this.lbl_tcan.TabIndex = 1;
            this.lbl_tcan.Text = "Seleccione el tipo de Cancelacion que desea realizar";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(28, 52);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(99, 23);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(183, 52);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // CancelarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 81);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_tcan);
            this.Controls.Add(this.cb_TipoCan);
            this.Name = "CancelarAdmin";
            this.Text = "Seleccionar Tipo Cancelacion";
            this.Load += new System.EventHandler(this.CancelarAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_TipoCan;
        private System.Windows.Forms.Label lbl_tcan;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}
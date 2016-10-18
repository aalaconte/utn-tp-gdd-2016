namespace ClinicaFrba.AbmRol
{
    partial class ModificarRol
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
            this.lbl_rol = new System.Windows.Forms.Label();
            this.lbl_nuevo_nombre = new System.Windows.Forms.Label();
            this.lbl_habilitado = new System.Windows.Forms.Label();
            this.txt_nuevo_nombre = new System.Windows.Forms.TextBox();
            this.cmb_habilitado = new System.Windows.Forms.ComboBox();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Location = new System.Drawing.Point(12, 26);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(23, 13);
            this.lbl_rol.TabIndex = 0;
            this.lbl_rol.Text = "Rol";
            // 
            // lbl_nuevo_nombre
            // 
            this.lbl_nuevo_nombre.AutoSize = true;
            this.lbl_nuevo_nombre.Location = new System.Drawing.Point(12, 70);
            this.lbl_nuevo_nombre.Name = "lbl_nuevo_nombre";
            this.lbl_nuevo_nombre.Size = new System.Drawing.Size(108, 13);
            this.lbl_nuevo_nombre.TabIndex = 1;
            this.lbl_nuevo_nombre.Text = "Nuevo nombre del rol";
            // 
            // lbl_habilitado
            // 
            this.lbl_habilitado.AutoSize = true;
            this.lbl_habilitado.Location = new System.Drawing.Point(12, 108);
            this.lbl_habilitado.Name = "lbl_habilitado";
            this.lbl_habilitado.Size = new System.Drawing.Size(60, 13);
            this.lbl_habilitado.TabIndex = 2;
            this.lbl_habilitado.Text = "Habilitado?";
            // 
            // txt_nuevo_nombre
            // 
            this.txt_nuevo_nombre.Location = new System.Drawing.Point(157, 67);
            this.txt_nuevo_nombre.Name = "txt_nuevo_nombre";
            this.txt_nuevo_nombre.Size = new System.Drawing.Size(151, 20);
            this.txt_nuevo_nombre.TabIndex = 3;
            // 
            // cmb_habilitado
            // 
            this.cmb_habilitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_habilitado.FormattingEnabled = true;
            this.cmb_habilitado.Location = new System.Drawing.Point(157, 105);
            this.cmb_habilitado.Name = "cmb_habilitado";
            this.cmb_habilitado.Size = new System.Drawing.Size(151, 21);
            this.cmb_habilitado.TabIndex = 4;
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(45, 157);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 5;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(196, 157);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguiente.TabIndex = 6;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 211);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.cmb_habilitado);
            this.Controls.Add(this.txt_nuevo_nombre);
            this.Controls.Add(this.lbl_habilitado);
            this.Controls.Add(this.lbl_nuevo_nombre);
            this.Controls.Add(this.lbl_rol);
            this.Name = "ModificarRol";
            this.Text = "Modificar Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.Label lbl_nuevo_nombre;
        private System.Windows.Forms.Label lbl_habilitado;
        private System.Windows.Forms.TextBox txt_nuevo_nombre;
        private System.Windows.Forms.ComboBox cmb_habilitado;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_siguiente;
    }
}
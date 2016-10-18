namespace ClinicaFrba.Main
{
    partial class MainPage
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
            this.btn_abm_rol = new ClinicaFrba.Main.BotonFuncionalidad();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_abm_rol
            // 
            this.btn_abm_rol.Funcionalidad = null;
            this.btn_abm_rol.Location = new System.Drawing.Point(246, 64);
            this.btn_abm_rol.Name = "btn_abm_rol";
            this.btn_abm_rol.Size = new System.Drawing.Size(195, 39);
            this.btn_abm_rol.TabIndex = 0;
            this.btn_abm_rol.Text = "ABM Rol";
            this.btn_abm_rol.UseVisualStyleBackColor = true;
            this.btn_abm_rol.Click += new System.EventHandler(this.btn_abm_rol_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(12, 9);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(135, 4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 315);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_abm_rol);
            this.Name = "MainPage";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BotonFuncionalidad btn_abm_rol;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_logout;
    }
}
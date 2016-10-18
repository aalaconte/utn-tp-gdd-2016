namespace ClinicaFrba.Login
{
    partial class Login
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_bienvenido = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lnk_recuperar_contrasenia = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(12, 43);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(43, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Usuario";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(12, 79);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(61, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(99, 40);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(148, 20);
            this.txt_usuario.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(99, 76);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(148, 20);
            this.txt_password.TabIndex = 3;
            // 
            // lbl_bienvenido
            // 
            this.lbl_bienvenido.AutoSize = true;
            this.lbl_bienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienvenido.Location = new System.Drawing.Point(12, 9);
            this.lbl_bienvenido.Name = "lbl_bienvenido";
            this.lbl_bienvenido.Size = new System.Drawing.Size(246, 15);
            this.lbl_bienvenido.TabIndex = 4;
            this.lbl_bienvenido.Text = "Inicie sesión para comenzar a operar";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(172, 132);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Aceptar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lnk_recuperar_contrasenia
            // 
            this.lnk_recuperar_contrasenia.AutoSize = true;
            this.lnk_recuperar_contrasenia.Location = new System.Drawing.Point(18, 137);
            this.lnk_recuperar_contrasenia.Name = "lnk_recuperar_contrasenia";
            this.lnk_recuperar_contrasenia.Size = new System.Drawing.Size(113, 13);
            this.lnk_recuperar_contrasenia.TabIndex = 6;
            this.lnk_recuperar_contrasenia.TabStop = true;
            this.lnk_recuperar_contrasenia.Text = "Recuperar contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 167);
            this.Controls.Add(this.lnk_recuperar_contrasenia);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_bienvenido);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_bienvenido;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel lnk_recuperar_contrasenia;
    }
}
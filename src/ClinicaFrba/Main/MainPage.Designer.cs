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
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_CancelarAtencion = new ClinicaFrba.Main.BotonFuncionalidad();
            this.btn_ListadoEstadistico = new ClinicaFrba.Main.BotonFuncionalidad();
            this.btn_RegistroLlegadaAtMedica = new ClinicaFrba.Main.BotonFuncionalidad();
            this.btn_RegistroResultadoAtMedica = new ClinicaFrba.Main.BotonFuncionalidad();
            this.btn_ComprarBonos = new ClinicaFrba.Main.BotonFuncionalidad();
            this.btn_PedidoTurno = new ClinicaFrba.Main.BotonFuncionalidad();
            this.btn_ABMProfesional = new ClinicaFrba.Main.BotonFuncionalidad();
            this.btn_ABMEspecialidadesMedicas = new ClinicaFrba.Main.BotonFuncionalidad();
            this.btn_RegistroUsuario = new ClinicaFrba.Main.BotonFuncionalidad();
            this.btn_ABMAfiliado = new ClinicaFrba.Main.BotonFuncionalidad();
            this.btn_LoginSeguridad = new ClinicaFrba.Main.BotonFuncionalidad();
            this.btn_abm_rol = new ClinicaFrba.Main.BotonFuncionalidad();
            this.SuspendLayout();
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
            // btn_CancelarAtencion
            // 
            this.btn_CancelarAtencion.Funcionalidad = null;
            this.btn_CancelarAtencion.Location = new System.Drawing.Point(34, 264);
            this.btn_CancelarAtencion.Name = "btn_CancelarAtencion";
            this.btn_CancelarAtencion.Size = new System.Drawing.Size(195, 39);
            this.btn_CancelarAtencion.TabIndex = 13;
            this.btn_CancelarAtencion.Text = "Cancelar Atencion";
            this.btn_CancelarAtencion.UseVisualStyleBackColor = true;
            this.btn_CancelarAtencion.Visible = false;
            // 
            // btn_ListadoEstadistico
            // 
            this.btn_ListadoEstadistico.Funcionalidad = null;
            this.btn_ListadoEstadistico.Location = new System.Drawing.Point(249, 264);
            this.btn_ListadoEstadistico.Name = "btn_ListadoEstadistico";
            this.btn_ListadoEstadistico.Size = new System.Drawing.Size(195, 39);
            this.btn_ListadoEstadistico.TabIndex = 12;
            this.btn_ListadoEstadistico.Text = "Listado Estadistico";
            this.btn_ListadoEstadistico.UseVisualStyleBackColor = true;
            this.btn_ListadoEstadistico.Visible = false;
            // 
            // btn_RegistroLlegadaAtMedica
            // 
            this.btn_RegistroLlegadaAtMedica.Funcionalidad = null;
            this.btn_RegistroLlegadaAtMedica.Location = new System.Drawing.Point(34, 219);
            this.btn_RegistroLlegadaAtMedica.Name = "btn_RegistroLlegadaAtMedica";
            this.btn_RegistroLlegadaAtMedica.Size = new System.Drawing.Size(195, 39);
            this.btn_RegistroLlegadaAtMedica.TabIndex = 11;
            this.btn_RegistroLlegadaAtMedica.Text = "Regitro Llegada Atencion Medica";
            this.btn_RegistroLlegadaAtMedica.UseVisualStyleBackColor = true;
            this.btn_RegistroLlegadaAtMedica.Visible = false;
            // 
            // btn_RegistroResultadoAtMedica
            // 
            this.btn_RegistroResultadoAtMedica.Funcionalidad = null;
            this.btn_RegistroResultadoAtMedica.Location = new System.Drawing.Point(249, 219);
            this.btn_RegistroResultadoAtMedica.Name = "btn_RegistroResultadoAtMedica";
            this.btn_RegistroResultadoAtMedica.Size = new System.Drawing.Size(195, 39);
            this.btn_RegistroResultadoAtMedica.TabIndex = 10;
            this.btn_RegistroResultadoAtMedica.Text = "Registro Resultado Atencion Medica";
            this.btn_RegistroResultadoAtMedica.UseVisualStyleBackColor = true;
            this.btn_RegistroResultadoAtMedica.Visible = false;
            // 
            // btn_ComprarBonos
            // 
            this.btn_ComprarBonos.Funcionalidad = null;
            this.btn_ComprarBonos.Location = new System.Drawing.Point(34, 174);
            this.btn_ComprarBonos.Name = "btn_ComprarBonos";
            this.btn_ComprarBonos.Size = new System.Drawing.Size(195, 39);
            this.btn_ComprarBonos.TabIndex = 9;
            this.btn_ComprarBonos.Text = "Comprar Bonos";
            this.btn_ComprarBonos.UseVisualStyleBackColor = true;
            this.btn_ComprarBonos.Visible = false;
            // 
            // btn_PedidoTurno
            // 
            this.btn_PedidoTurno.Funcionalidad = null;
            this.btn_PedidoTurno.Location = new System.Drawing.Point(249, 174);
            this.btn_PedidoTurno.Name = "btn_PedidoTurno";
            this.btn_PedidoTurno.Size = new System.Drawing.Size(195, 39);
            this.btn_PedidoTurno.TabIndex = 8;
            this.btn_PedidoTurno.Text = "Pedir Turno";
            this.btn_PedidoTurno.UseVisualStyleBackColor = true;
            this.btn_PedidoTurno.Visible = false;
            // 
            // btn_ABMProfesional
            // 
            this.btn_ABMProfesional.Funcionalidad = null;
            this.btn_ABMProfesional.Location = new System.Drawing.Point(34, 129);
            this.btn_ABMProfesional.Name = "btn_ABMProfesional";
            this.btn_ABMProfesional.Size = new System.Drawing.Size(195, 39);
            this.btn_ABMProfesional.TabIndex = 7;
            this.btn_ABMProfesional.Text = "ABM Profesional";
            this.btn_ABMProfesional.UseVisualStyleBackColor = true;
            this.btn_ABMProfesional.Visible = false;
            // 
            // btn_ABMEspecialidadesMedicas
            // 
            this.btn_ABMEspecialidadesMedicas.Funcionalidad = null;
            this.btn_ABMEspecialidadesMedicas.Location = new System.Drawing.Point(249, 129);
            this.btn_ABMEspecialidadesMedicas.Name = "btn_ABMEspecialidadesMedicas";
            this.btn_ABMEspecialidadesMedicas.Size = new System.Drawing.Size(195, 39);
            this.btn_ABMEspecialidadesMedicas.TabIndex = 6;
            this.btn_ABMEspecialidadesMedicas.Text = "ABM Especialidades Medicas";
            this.btn_ABMEspecialidadesMedicas.UseVisualStyleBackColor = true;
            this.btn_ABMEspecialidadesMedicas.Visible = false;
            // 
            // btn_RegistroUsuario
            // 
            this.btn_RegistroUsuario.Funcionalidad = null;
            this.btn_RegistroUsuario.Location = new System.Drawing.Point(34, 84);
            this.btn_RegistroUsuario.Name = "btn_RegistroUsuario";
            this.btn_RegistroUsuario.Size = new System.Drawing.Size(195, 39);
            this.btn_RegistroUsuario.TabIndex = 5;
            this.btn_RegistroUsuario.Text = "Registro Usuario";
            this.btn_RegistroUsuario.UseVisualStyleBackColor = true;
            this.btn_RegistroUsuario.Visible = false;
            // 
            // btn_ABMAfiliado
            // 
            this.btn_ABMAfiliado.Funcionalidad = null;
            this.btn_ABMAfiliado.Location = new System.Drawing.Point(249, 84);
            this.btn_ABMAfiliado.Name = "btn_ABMAfiliado";
            this.btn_ABMAfiliado.Size = new System.Drawing.Size(195, 39);
            this.btn_ABMAfiliado.TabIndex = 4;
            this.btn_ABMAfiliado.Text = "ABM Afiliado";
            this.btn_ABMAfiliado.UseVisualStyleBackColor = true;
            this.btn_ABMAfiliado.Visible = false;
            // 
            // btn_LoginSeguridad
            // 
            this.btn_LoginSeguridad.Funcionalidad = null;
            this.btn_LoginSeguridad.Location = new System.Drawing.Point(249, 39);
            this.btn_LoginSeguridad.Name = "btn_LoginSeguridad";
            this.btn_LoginSeguridad.Size = new System.Drawing.Size(195, 39);
            this.btn_LoginSeguridad.TabIndex = 3;
            this.btn_LoginSeguridad.Text = "Login y Seguridad";
            this.btn_LoginSeguridad.UseVisualStyleBackColor = true;
            this.btn_LoginSeguridad.Visible = false;
            // 
            // btn_abm_rol
            // 
            this.btn_abm_rol.Funcionalidad = null;
            this.btn_abm_rol.Location = new System.Drawing.Point(34, 39);
            this.btn_abm_rol.Name = "btn_abm_rol";
            this.btn_abm_rol.Size = new System.Drawing.Size(195, 39);
            this.btn_abm_rol.TabIndex = 0;
            this.btn_abm_rol.Text = "ABM Rol";
            this.btn_abm_rol.UseVisualStyleBackColor = true;
            this.btn_abm_rol.Visible = false;
            this.btn_abm_rol.Click += new System.EventHandler(this.btn_abm_rol_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 315);
            this.Controls.Add(this.btn_CancelarAtencion);
            this.Controls.Add(this.btn_ListadoEstadistico);
            this.Controls.Add(this.btn_RegistroLlegadaAtMedica);
            this.Controls.Add(this.btn_RegistroResultadoAtMedica);
            this.Controls.Add(this.btn_ComprarBonos);
            this.Controls.Add(this.btn_PedidoTurno);
            this.Controls.Add(this.btn_ABMProfesional);
            this.Controls.Add(this.btn_ABMEspecialidadesMedicas);
            this.Controls.Add(this.btn_RegistroUsuario);
            this.Controls.Add(this.btn_ABMAfiliado);
            this.Controls.Add(this.btn_LoginSeguridad);
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
        private BotonFuncionalidad btn_LoginSeguridad;
        private BotonFuncionalidad btn_RegistroUsuario;
        private BotonFuncionalidad btn_ABMAfiliado;
        private BotonFuncionalidad btn_ABMProfesional;
        private BotonFuncionalidad btn_ABMEspecialidadesMedicas;
        private BotonFuncionalidad btn_ComprarBonos;
        private BotonFuncionalidad btn_PedidoTurno;
        private BotonFuncionalidad btn_RegistroLlegadaAtMedica;
        private BotonFuncionalidad btn_RegistroResultadoAtMedica;
        private BotonFuncionalidad btn_CancelarAtencion;
        private BotonFuncionalidad btn_ListadoEstadistico;
    }
}
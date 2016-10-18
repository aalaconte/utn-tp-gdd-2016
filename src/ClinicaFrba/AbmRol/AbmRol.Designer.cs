namespace ClinicaFrba.AbmRol
{
    partial class AbmRol
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
            this.lbl_info_funcionalidad = new System.Windows.Forms.Label();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.lbl_funcionalidad = new System.Windows.Forms.Label();
            this.txt_rol = new System.Windows.Forms.TextBox();
            this.cmb_funcionalidad = new System.Windows.Forms.ComboBox();
            this.chk_habilitado = new System.Windows.Forms.CheckBox();
            this.lbl_funcionalidades_asignadas = new System.Windows.Forms.Label();
            this.lbl_funcionalidades_a_asignar = new System.Windows.Forms.Label();
            this.lst_funcionalidades_asignadas = new System.Windows.Forms.ListBox();
            this.lst_funcionalidades_a_asignar = new System.Windows.Forms.ListBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_info_funcionalidad
            // 
            this.lbl_info_funcionalidad.AutoSize = true;
            this.lbl_info_funcionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_funcionalidad.Location = new System.Drawing.Point(54, 23);
            this.lbl_info_funcionalidad.MaximumSize = new System.Drawing.Size(320, 0);
            this.lbl_info_funcionalidad.Name = "lbl_info_funcionalidad";
            this.lbl_info_funcionalidad.Size = new System.Drawing.Size(319, 39);
            this.lbl_info_funcionalidad.TabIndex = 0;
            this.lbl_info_funcionalidad.Text = "Para agregar funcionalidades, seleccione de a una del combo desplegable. Para qui" +
    "tar una funcionalidad de la lista, simplemente haga click en ella.";
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Location = new System.Drawing.Point(24, 77);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(58, 13);
            this.lbl_rol.TabIndex = 1;
            this.lbl_rol.Text = "Nombre rol";
            // 
            // lbl_funcionalidad
            // 
            this.lbl_funcionalidad.AutoSize = true;
            this.lbl_funcionalidad.Location = new System.Drawing.Point(226, 77);
            this.lbl_funcionalidad.Name = "lbl_funcionalidad";
            this.lbl_funcionalidad.Size = new System.Drawing.Size(134, 13);
            this.lbl_funcionalidad.TabIndex = 2;
            this.lbl_funcionalidad.Text = "Funcionalidades existentes";
            // 
            // txt_rol
            // 
            this.txt_rol.Location = new System.Drawing.Point(27, 93);
            this.txt_rol.Name = "txt_rol";
            this.txt_rol.Size = new System.Drawing.Size(155, 20);
            this.txt_rol.TabIndex = 3;
            // 
            // cmb_funcionalidad
            // 
            this.cmb_funcionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_funcionalidad.FormattingEnabled = true;
            this.cmb_funcionalidad.Location = new System.Drawing.Point(229, 93);
            this.cmb_funcionalidad.Name = "cmb_funcionalidad";
            this.cmb_funcionalidad.Size = new System.Drawing.Size(155, 21);
            this.cmb_funcionalidad.TabIndex = 4;
            this.cmb_funcionalidad.SelectedIndexChanged += new System.EventHandler(this.cmb_funcionalidad_SelectedIndexChanged);
            // 
            // chk_habilitado
            // 
            this.chk_habilitado.AutoSize = true;
            this.chk_habilitado.Location = new System.Drawing.Point(27, 119);
            this.chk_habilitado.Name = "chk_habilitado";
            this.chk_habilitado.Size = new System.Drawing.Size(73, 17);
            this.chk_habilitado.TabIndex = 5;
            this.chk_habilitado.Text = "Habilitado";
            this.chk_habilitado.UseVisualStyleBackColor = true;
            // 
            // lbl_funcionalidades_asignadas
            // 
            this.lbl_funcionalidades_asignadas.AutoSize = true;
            this.lbl_funcionalidades_asignadas.Location = new System.Drawing.Point(24, 149);
            this.lbl_funcionalidades_asignadas.Name = "lbl_funcionalidades_asignadas";
            this.lbl_funcionalidades_asignadas.Size = new System.Drawing.Size(135, 13);
            this.lbl_funcionalidades_asignadas.TabIndex = 6;
            this.lbl_funcionalidades_asignadas.Text = "Funcionalidades asignadas";
            // 
            // lbl_funcionalidades_a_asignar
            // 
            this.lbl_funcionalidades_a_asignar.AutoSize = true;
            this.lbl_funcionalidades_a_asignar.Location = new System.Drawing.Point(226, 149);
            this.lbl_funcionalidades_a_asignar.Name = "lbl_funcionalidades_a_asignar";
            this.lbl_funcionalidades_a_asignar.Size = new System.Drawing.Size(130, 13);
            this.lbl_funcionalidades_a_asignar.TabIndex = 7;
            this.lbl_funcionalidades_a_asignar.Text = "Funcionalidades a asignar";
            // 
            // lst_funcionalidades_asignadas
            // 
            this.lst_funcionalidades_asignadas.FormattingEnabled = true;
            this.lst_funcionalidades_asignadas.Location = new System.Drawing.Point(27, 166);
            this.lst_funcionalidades_asignadas.Name = "lst_funcionalidades_asignadas";
            this.lst_funcionalidades_asignadas.Size = new System.Drawing.Size(155, 95);
            this.lst_funcionalidades_asignadas.TabIndex = 8;
            // 
            // lst_funcionalidades_a_asignar
            // 
            this.lst_funcionalidades_a_asignar.FormattingEnabled = true;
            this.lst_funcionalidades_a_asignar.Location = new System.Drawing.Point(229, 166);
            this.lst_funcionalidades_a_asignar.Name = "lst_funcionalidades_a_asignar";
            this.lst_funcionalidades_a_asignar.Size = new System.Drawing.Size(155, 95);
            this.lst_funcionalidades_a_asignar.TabIndex = 9;
            this.lst_funcionalidades_a_asignar.SelectedIndexChanged += new System.EventHandler(this.lst_funcionalidades_a_asignar_SelectedIndexChanged);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(27, 267);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(27, 296);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 11;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(309, 267);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 12;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(328, 267);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(32, 23);
            this.btn_guardar.TabIndex = 13;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // AbmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 329);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.lst_funcionalidades_a_asignar);
            this.Controls.Add(this.lst_funcionalidades_asignadas);
            this.Controls.Add(this.lbl_funcionalidades_a_asignar);
            this.Controls.Add(this.lbl_funcionalidades_asignadas);
            this.Controls.Add(this.chk_habilitado);
            this.Controls.Add(this.cmb_funcionalidad);
            this.Controls.Add(this.txt_rol);
            this.Controls.Add(this.lbl_funcionalidad);
            this.Controls.Add(this.lbl_rol);
            this.Controls.Add(this.lbl_info_funcionalidad);
            this.Name = "AbmRol";
            this.Text = "ABM Rol";
            this.Load += new System.EventHandler(this.AbmRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info_funcionalidad;
        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.Label lbl_funcionalidad;
        private System.Windows.Forms.TextBox txt_rol;
        private System.Windows.Forms.ComboBox cmb_funcionalidad;
        private System.Windows.Forms.CheckBox chk_habilitado;
        private System.Windows.Forms.Label lbl_funcionalidades_asignadas;
        private System.Windows.Forms.Label lbl_funcionalidades_a_asignar;
        private System.Windows.Forms.ListBox lst_funcionalidades_asignadas;
        private System.Windows.Forms.ListBox lst_funcionalidades_a_asignar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_guardar;
    }
}
namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class BuscarProfesionales
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
            this.gpb_filtros_busqueda = new System.Windows.Forms.GroupBox();
            this.txt_especialidad = new System.Windows.Forms.TextBox();
            this.lbl_especialidad = new System.Windows.Forms.Label();
            this.txt_nro_documento = new System.Windows.Forms.TextBox();
            this.lbl_nro_documento = new System.Windows.Forms.Label();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_profesionales = new System.Windows.Forms.DataGridView();
            this.btn_primera = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_ultima = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.lbl_nro_pagina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nro_profesionales = new System.Windows.Forms.Label();
            this.gpb_filtros_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_profesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_filtros_busqueda
            // 
            this.gpb_filtros_busqueda.Controls.Add(this.txt_especialidad);
            this.gpb_filtros_busqueda.Controls.Add(this.lbl_especialidad);
            this.gpb_filtros_busqueda.Controls.Add(this.txt_nro_documento);
            this.gpb_filtros_busqueda.Controls.Add(this.lbl_nro_documento);
            this.gpb_filtros_busqueda.Controls.Add(this.lbl_matricula);
            this.gpb_filtros_busqueda.Controls.Add(this.txt_matricula);
            this.gpb_filtros_busqueda.Controls.Add(this.txt_apellido);
            this.gpb_filtros_busqueda.Controls.Add(this.lbl_apellido);
            this.gpb_filtros_busqueda.Controls.Add(this.txt_nombre);
            this.gpb_filtros_busqueda.Controls.Add(this.lbl_nombre);
            this.gpb_filtros_busqueda.Location = new System.Drawing.Point(25, 12);
            this.gpb_filtros_busqueda.Name = "gpb_filtros_busqueda";
            this.gpb_filtros_busqueda.Size = new System.Drawing.Size(592, 133);
            this.gpb_filtros_busqueda.TabIndex = 0;
            this.gpb_filtros_busqueda.TabStop = false;
            this.gpb_filtros_busqueda.Text = "Filtros";
            // 
            // txt_especialidad
            // 
            this.txt_especialidad.Location = new System.Drawing.Point(403, 61);
            this.txt_especialidad.Name = "txt_especialidad";
            this.txt_especialidad.Size = new System.Drawing.Size(132, 20);
            this.txt_especialidad.TabIndex = 9;
            // 
            // lbl_especialidad
            // 
            this.lbl_especialidad.AutoSize = true;
            this.lbl_especialidad.Location = new System.Drawing.Point(330, 64);
            this.lbl_especialidad.Name = "lbl_especialidad";
            this.lbl_especialidad.Size = new System.Drawing.Size(67, 13);
            this.lbl_especialidad.TabIndex = 9;
            this.lbl_especialidad.Text = "Especialidad";
            // 
            // txt_nro_documento
            // 
            this.txt_nro_documento.Location = new System.Drawing.Point(403, 26);
            this.txt_nro_documento.Name = "txt_nro_documento";
            this.txt_nro_documento.Size = new System.Drawing.Size(132, 20);
            this.txt_nro_documento.TabIndex = 8;
            // 
            // lbl_nro_documento
            // 
            this.lbl_nro_documento.AutoSize = true;
            this.lbl_nro_documento.Location = new System.Drawing.Point(330, 29);
            this.lbl_nro_documento.Name = "lbl_nro_documento";
            this.lbl_nro_documento.Size = new System.Drawing.Size(47, 13);
            this.lbl_nro_documento.TabIndex = 7;
            this.lbl_nro_documento.Text = "Nro Doc";
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(6, 100);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(52, 13);
            this.lbl_matricula.TabIndex = 6;
            this.lbl_matricula.Text = "Matrícula";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(64, 97);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(132, 20);
            this.txt_matricula.TabIndex = 5;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(64, 61);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(132, 20);
            this.txt_apellido.TabIndex = 4;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(6, 64);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 3;
            this.lbl_apellido.Text = "Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(64, 26);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(132, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(6, 29);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(25, 151);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 1;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(542, 151);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_profesionales
            // 
            this.dgv_profesionales.AllowUserToAddRows = false;
            this.dgv_profesionales.AllowUserToDeleteRows = false;
            this.dgv_profesionales.AllowUserToResizeColumns = false;
            this.dgv_profesionales.AllowUserToResizeRows = false;
            this.dgv_profesionales.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_profesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_profesionales.Location = new System.Drawing.Point(25, 180);
            this.dgv_profesionales.MultiSelect = false;
            this.dgv_profesionales.Name = "dgv_profesionales";
            this.dgv_profesionales.ReadOnly = true;
            this.dgv_profesionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_profesionales.Size = new System.Drawing.Size(592, 170);
            this.dgv_profesionales.TabIndex = 4;
            // 
            // btn_primera
            // 
            this.btn_primera.Location = new System.Drawing.Point(25, 393);
            this.btn_primera.Name = "btn_primera";
            this.btn_primera.Size = new System.Drawing.Size(75, 23);
            this.btn_primera.TabIndex = 5;
            this.btn_primera.Text = "Primera";
            this.btn_primera.UseVisualStyleBackColor = true;
            this.btn_primera.Click += new System.EventHandler(this.btn_primera_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(106, 393);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_anterior.TabIndex = 6;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(25, 422);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 7;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_ultima
            // 
            this.btn_ultima.Location = new System.Drawing.Point(542, 393);
            this.btn_ultima.Name = "btn_ultima";
            this.btn_ultima.Size = new System.Drawing.Size(75, 23);
            this.btn_ultima.TabIndex = 8;
            this.btn_ultima.Text = "Última";
            this.btn_ultima.UseVisualStyleBackColor = true;
            this.btn_ultima.Click += new System.EventHandler(this.btn_ultima_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(461, 393);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguiente.TabIndex = 9;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(542, 422);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 10;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // lbl_nro_pagina
            // 
            this.lbl_nro_pagina.AutoSize = true;
            this.lbl_nro_pagina.Location = new System.Drawing.Point(25, 357);
            this.lbl_nro_pagina.Name = "lbl_nro_pagina";
            this.lbl_nro_pagina.Size = new System.Drawing.Size(0, 13);
            this.lbl_nro_pagina.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cantidad de profesionales";
            // 
            // lbl_nro_profesionales
            // 
            this.lbl_nro_profesionales.AutoSize = true;
            this.lbl_nro_profesionales.Location = new System.Drawing.Point(560, 357);
            this.lbl_nro_profesionales.Name = "lbl_nro_profesionales";
            this.lbl_nro_profesionales.Size = new System.Drawing.Size(0, 13);
            this.lbl_nro_profesionales.TabIndex = 13;
            // 
            // BuscarProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 457);
            this.Controls.Add(this.lbl_nro_profesionales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_nro_pagina);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_ultima);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_primera);
            this.Controls.Add(this.dgv_profesionales);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.gpb_filtros_busqueda);
            this.Name = "BuscarProfesionales";
            this.Text = "Buscar Profesionales";
            this.Load += new System.EventHandler(this.BuscarProfesionales_Load);
            this.gpb_filtros_busqueda.ResumeLayout(false);
            this.gpb_filtros_busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_profesionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_filtros_busqueda;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_nro_documento;
        private System.Windows.Forms.Label lbl_nro_documento;
        private System.Windows.Forms.TextBox txt_especialidad;
        private System.Windows.Forms.Label lbl_especialidad;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_profesionales;
        private System.Windows.Forms.Button btn_primera;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_ultima;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Label lbl_nro_pagina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nro_profesionales;
    }
}
namespace ClinicaFrba.Abm_Afiliado
{
    partial class BuscarAfiliado
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
            this.gb_Filtros = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NroAfi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dgv_Afiliados = new System.Windows.Forms.DataGridView();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_ultima = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_primera = new System.Windows.Forms.Button();
            this.lbl_nroAfi = new System.Windows.Forms.Label();
            this.lbl_nro_pagina = new System.Windows.Forms.Label();
            this.lblCantAfi = new System.Windows.Forms.Label();
            this.gb_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Afiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Filtros
            // 
            this.gb_Filtros.Controls.Add(this.btn_limpiar);
            this.gb_Filtros.Controls.Add(this.label5);
            this.gb_Filtros.Controls.Add(this.cmb_estado);
            this.gb_Filtros.Controls.Add(this.label2);
            this.gb_Filtros.Controls.Add(this.txt_NroAfi);
            this.gb_Filtros.Controls.Add(this.label4);
            this.gb_Filtros.Controls.Add(this.label3);
            this.gb_Filtros.Controls.Add(this.txtApellido);
            this.gb_Filtros.Controls.Add(this.txtNombre);
            this.gb_Filtros.Controls.Add(this.label13);
            this.gb_Filtros.Controls.Add(this.txtDocumento);
            this.gb_Filtros.Controls.Add(this.btn_Buscar);
            this.gb_Filtros.Controls.Add(this.label1);
            this.gb_Filtros.Controls.Add(this.txtUsername);
            this.gb_Filtros.Location = new System.Drawing.Point(12, 12);
            this.gb_Filtros.Name = "gb_Filtros";
            this.gb_Filtros.Size = new System.Drawing.Size(726, 99);
            this.gb_Filtros.TabIndex = 0;
            this.gb_Filtros.TabStop = false;
            this.gb_Filtros.Text = "Filtros de Busqueda";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(551, 56);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 17;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Habilitado";
            // 
            // cmb_estado
            // 
            this.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmb_estado.Location = new System.Drawing.Point(81, 74);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(114, 21);
            this.cmb_estado.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nro Afiliado";
            // 
            // txt_NroAfi
            // 
            this.txt_NroAfi.Location = new System.Drawing.Point(74, 48);
            this.txt_NroAfi.Name = "txt_NroAfi";
            this.txt_NroAfi.Size = new System.Drawing.Size(121, 20);
            this.txt_NroAfi.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(457, 22);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 36;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(270, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(270, 51);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(121, 20);
            this.txtDocumento.TabIndex = 33;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(470, 56);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(74, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 20);
            this.txtUsername.TabIndex = 31;
            // 
            // dgv_Afiliados
            // 
            this.dgv_Afiliados.AllowUserToAddRows = false;
            this.dgv_Afiliados.AllowUserToDeleteRows = false;
            this.dgv_Afiliados.AllowUserToResizeColumns = false;
            this.dgv_Afiliados.AllowUserToResizeRows = false;
            this.dgv_Afiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Afiliados.Location = new System.Drawing.Point(12, 117);
            this.dgv_Afiliados.Name = "dgv_Afiliados";
            this.dgv_Afiliados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Afiliados.Size = new System.Drawing.Size(725, 154);
            this.dgv_Afiliados.TabIndex = 1;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(663, 335);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 14;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(581, 306);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguiente.TabIndex = 13;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_ultima
            // 
            this.btn_ultima.Location = new System.Drawing.Point(663, 306);
            this.btn_ultima.Name = "btn_ultima";
            this.btn_ultima.Size = new System.Drawing.Size(75, 23);
            this.btn_ultima.TabIndex = 12;
            this.btn_ultima.Text = "Última";
            this.btn_ultima.UseVisualStyleBackColor = true;
            this.btn_ultima.Click += new System.EventHandler(this.btn_ultima_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(93, 306);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_anterior.TabIndex = 11;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(12, 335);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 10;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_primera
            // 
            this.btn_primera.Location = new System.Drawing.Point(12, 306);
            this.btn_primera.Name = "btn_primera";
            this.btn_primera.Size = new System.Drawing.Size(75, 23);
            this.btn_primera.TabIndex = 9;
            this.btn_primera.Text = "Primera";
            this.btn_primera.UseVisualStyleBackColor = true;
            this.btn_primera.Click += new System.EventHandler(this.btn_primera_Click);
            // 
            // lbl_nroAfi
            // 
            this.lbl_nroAfi.AutoSize = true;
            this.lbl_nroAfi.Location = new System.Drawing.Point(703, 274);
            this.lbl_nroAfi.Name = "lbl_nroAfi";
            this.lbl_nroAfi.Size = new System.Drawing.Size(0, 13);
            this.lbl_nroAfi.TabIndex = 15;
            // 
            // lbl_nro_pagina
            // 
            this.lbl_nro_pagina.AutoSize = true;
            this.lbl_nro_pagina.Location = new System.Drawing.Point(12, 274);
            this.lbl_nro_pagina.Name = "lbl_nro_pagina";
            this.lbl_nro_pagina.Size = new System.Drawing.Size(0, 13);
            this.lbl_nro_pagina.TabIndex = 16;
            // 
            // lblCantAfi
            // 
            this.lblCantAfi.AutoSize = true;
            this.lblCantAfi.Location = new System.Drawing.Point(606, 274);
            this.lblCantAfi.Name = "lblCantAfi";
            this.lblCantAfi.Size = new System.Drawing.Size(0, 13);
            this.lblCantAfi.TabIndex = 17;
            // 
            // BuscarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 373);
            this.Controls.Add(this.lblCantAfi);
            this.Controls.Add(this.lbl_nro_pagina);
            this.Controls.Add(this.lbl_nroAfi);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_ultima);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_primera);
            this.Controls.Add(this.dgv_Afiliados);
            this.Controls.Add(this.gb_Filtros);
            this.Name = "BuscarAfiliado";
            this.Text = "Buscar Afiliado";
            this.Load += new System.EventHandler(this.BuscarAfiliado_Load);
            this.gb_Filtros.ResumeLayout(false);
            this.gb_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Afiliados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Filtros;
        private System.Windows.Forms.DataGridView dgv_Afiliados;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_ultima;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_primera;
        private System.Windows.Forms.Label lbl_nroAfi;
        private System.Windows.Forms.Label lbl_nro_pagina;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NroAfi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lblCantAfi;
    }
}
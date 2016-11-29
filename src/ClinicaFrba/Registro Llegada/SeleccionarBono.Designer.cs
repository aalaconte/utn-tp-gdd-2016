namespace ClinicaFrba.Registro_Llegada
{
    partial class SeleccionarBono
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
            this.dgv_bonosDisponibles = new System.Windows.Forms.DataGridView();
            this.lblCantTurnos = new System.Windows.Forms.Label();
            this.lbl_nro_pagina = new System.Windows.Forms.Label();
            this.lbl_nroTurno = new System.Windows.Forms.Label();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_ultima = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_primera = new System.Windows.Forms.Button();
            this.txt_idAfiliado = new System.Windows.Forms.TextBox();
            this.lbl_afiliados = new System.Windows.Forms.Label();
            this.txt_plan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bonosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bonosDisponibles
            // 
            this.dgv_bonosDisponibles.AllowUserToAddRows = false;
            this.dgv_bonosDisponibles.AllowUserToDeleteRows = false;
            this.dgv_bonosDisponibles.AllowUserToResizeColumns = false;
            this.dgv_bonosDisponibles.AllowUserToResizeRows = false;
            this.dgv_bonosDisponibles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_bonosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bonosDisponibles.Location = new System.Drawing.Point(10, 38);
            this.dgv_bonosDisponibles.MultiSelect = false;
            this.dgv_bonosDisponibles.Name = "dgv_bonosDisponibles";
            this.dgv_bonosDisponibles.ReadOnly = true;
            this.dgv_bonosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bonosDisponibles.Size = new System.Drawing.Size(454, 184);
            this.dgv_bonosDisponibles.TabIndex = 52;
            // 
            // lblCantTurnos
            // 
            this.lblCantTurnos.AutoSize = true;
            this.lblCantTurnos.Location = new System.Drawing.Point(332, 228);
            this.lblCantTurnos.Name = "lblCantTurnos";
            this.lblCantTurnos.Size = new System.Drawing.Size(0, 13);
            this.lblCantTurnos.TabIndex = 61;
            // 
            // lbl_nro_pagina
            // 
            this.lbl_nro_pagina.AutoSize = true;
            this.lbl_nro_pagina.Location = new System.Drawing.Point(7, 228);
            this.lbl_nro_pagina.Name = "lbl_nro_pagina";
            this.lbl_nro_pagina.Size = new System.Drawing.Size(0, 13);
            this.lbl_nro_pagina.TabIndex = 60;
            // 
            // lbl_nroTurno
            // 
            this.lbl_nroTurno.AutoSize = true;
            this.lbl_nroTurno.Location = new System.Drawing.Point(429, 228);
            this.lbl_nroTurno.Name = "lbl_nroTurno";
            this.lbl_nroTurno.Size = new System.Drawing.Size(0, 13);
            this.lbl_nroTurno.TabIndex = 59;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(389, 289);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 58;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(307, 260);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguiente.TabIndex = 57;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_ultima
            // 
            this.btn_ultima.Location = new System.Drawing.Point(389, 260);
            this.btn_ultima.Name = "btn_ultima";
            this.btn_ultima.Size = new System.Drawing.Size(75, 23);
            this.btn_ultima.TabIndex = 56;
            this.btn_ultima.Text = "Última";
            this.btn_ultima.UseVisualStyleBackColor = true;
            this.btn_ultima.Click += new System.EventHandler(this.btn_ultima_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(88, 260);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_anterior.TabIndex = 55;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(7, 289);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 54;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_primera
            // 
            this.btn_primera.Location = new System.Drawing.Point(7, 260);
            this.btn_primera.Name = "btn_primera";
            this.btn_primera.Size = new System.Drawing.Size(75, 23);
            this.btn_primera.TabIndex = 53;
            this.btn_primera.Text = "Primera";
            this.btn_primera.UseVisualStyleBackColor = true;
            this.btn_primera.Click += new System.EventHandler(this.btn_primera_Click);
            // 
            // txt_idAfiliado
            // 
            this.txt_idAfiliado.Enabled = false;
            this.txt_idAfiliado.Location = new System.Drawing.Point(84, 12);
            this.txt_idAfiliado.Name = "txt_idAfiliado";
            this.txt_idAfiliado.Size = new System.Drawing.Size(131, 20);
            this.txt_idAfiliado.TabIndex = 63;
            // 
            // lbl_afiliados
            // 
            this.lbl_afiliados.AutoSize = true;
            this.lbl_afiliados.Location = new System.Drawing.Point(16, 15);
            this.lbl_afiliados.Name = "lbl_afiliados";
            this.lbl_afiliados.Size = new System.Drawing.Size(58, 13);
            this.lbl_afiliados.TabIndex = 62;
            this.lbl_afiliados.Text = "ID Afiliado:";
            // 
            // txt_plan
            // 
            this.txt_plan.Enabled = false;
            this.txt_plan.Location = new System.Drawing.Point(324, 12);
            this.txt_plan.Name = "txt_plan";
            this.txt_plan.Size = new System.Drawing.Size(131, 20);
            this.txt_plan.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Plan Actual:";
            // 
            // SeleccionarBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 323);
            this.Controls.Add(this.txt_plan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idAfiliado);
            this.Controls.Add(this.lbl_afiliados);
            this.Controls.Add(this.lblCantTurnos);
            this.Controls.Add(this.lbl_nro_pagina);
            this.Controls.Add(this.lbl_nroTurno);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_ultima);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_primera);
            this.Controls.Add(this.dgv_bonosDisponibles);
            this.Name = "SeleccionarBono";
            this.Text = "SeleccionarBono";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bonosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bonosDisponibles;
        private System.Windows.Forms.Label lblCantTurnos;
        private System.Windows.Forms.Label lbl_nro_pagina;
        private System.Windows.Forms.Label lbl_nroTurno;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_ultima;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_primera;
        private System.Windows.Forms.TextBox txt_idAfiliado;
        private System.Windows.Forms.Label lbl_afiliados;
        private System.Windows.Forms.TextBox txt_plan;
        private System.Windows.Forms.Label label1;
    }
}
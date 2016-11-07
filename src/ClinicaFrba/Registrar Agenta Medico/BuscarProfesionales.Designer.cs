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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.txt_nro_documento = new System.Windows.Forms.TextBox();
            this.lbl_nro_documento = new System.Windows.Forms.Label();
            this.gpb_filtros_busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_filtros_busqueda
            // 
            this.gpb_filtros_busqueda.Controls.Add(this.txt_nro_documento);
            this.gpb_filtros_busqueda.Controls.Add(this.lbl_nro_documento);
            this.gpb_filtros_busqueda.Controls.Add(this.lbl_matricula);
            this.gpb_filtros_busqueda.Controls.Add(this.textBox1);
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
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(6, 29);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(64, 26);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(132, 20);
            this.txt_nombre.TabIndex = 2;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 5;
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
            // txt_nro_documento
            // 
            this.txt_nro_documento.Location = new System.Drawing.Point(388, 26);
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
            // BuscarProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 406);
            this.Controls.Add(this.gpb_filtros_busqueda);
            this.Name = "BuscarProfesionales";
            this.Text = "Buscar Profesionales";
            this.gpb_filtros_busqueda.ResumeLayout(false);
            this.gpb_filtros_busqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_filtros_busqueda;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_nro_documento;
        private System.Windows.Forms.Label lbl_nro_documento;
    }
}
namespace ClinicaFrba.Registro_Resultado
{
    partial class CargarDiagnostico
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
            this.txt_sintomas = new System.Windows.Forms.RichTextBox();
            this.txt_enfermedades = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lbl_warn_sintomas = new System.Windows.Forms.Label();
            this.lbl_warn_enfermedades = new System.Windows.Forms.Label();
            this.btn_agregarSintoma = new System.Windows.Forms.Button();
            this.btn_agregarEnfermedad = new System.Windows.Forms.Button();
            this.lbl_warn_lb_sintomas = new System.Windows.Forms.Label();
            this.lbl_warn_lb_enfermedades = new System.Windows.Forms.Label();
            this.lv_sintomas = new System.Windows.Forms.ListView();
            this.lv_enfermedades = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txt_sintomas
            // 
            this.txt_sintomas.Location = new System.Drawing.Point(78, 171);
            this.txt_sintomas.MaxLength = 255;
            this.txt_sintomas.Name = "txt_sintomas";
            this.txt_sintomas.Size = new System.Drawing.Size(191, 56);
            this.txt_sintomas.TabIndex = 0;
            this.txt_sintomas.Text = "";
            // 
            // txt_enfermedades
            // 
            this.txt_enfermedades.Location = new System.Drawing.Point(362, 171);
            this.txt_enfermedades.MaxLength = 255;
            this.txt_enfermedades.Name = "txt_enfermedades";
            this.txt_enfermedades.Size = new System.Drawing.Size(191, 56);
            this.txt_enfermedades.TabIndex = 1;
            this.txt_enfermedades.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sintomas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enfermedades:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(331, 268);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 24);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(213, 268);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(90, 25);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lbl_warn_sintomas
            // 
            this.lbl_warn_sintomas.AutoSize = true;
            this.lbl_warn_sintomas.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_sintomas.Location = new System.Drawing.Point(76, 230);
            this.lbl_warn_sintomas.Name = "lbl_warn_sintomas";
            this.lbl_warn_sintomas.Size = new System.Drawing.Size(217, 13);
            this.lbl_warn_sintomas.TabIndex = 56;
            this.lbl_warn_sintomas.Text = "Debe ingresar los sintomas correspondientes";
            this.lbl_warn_sintomas.Visible = false;
            // 
            // lbl_warn_enfermedades
            // 
            this.lbl_warn_enfermedades.AutoSize = true;
            this.lbl_warn_enfermedades.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_enfermedades.Location = new System.Drawing.Point(359, 230);
            this.lbl_warn_enfermedades.Name = "lbl_warn_enfermedades";
            this.lbl_warn_enfermedades.Size = new System.Drawing.Size(225, 13);
            this.lbl_warn_enfermedades.TabIndex = 57;
            this.lbl_warn_enfermedades.Text = "Debe ingresar el diganostico correspondientes";
            this.lbl_warn_enfermedades.Visible = false;
            // 
            // btn_agregarSintoma
            // 
            this.btn_agregarSintoma.Location = new System.Drawing.Point(275, 202);
            this.btn_agregarSintoma.Name = "btn_agregarSintoma";
            this.btn_agregarSintoma.Size = new System.Drawing.Size(68, 25);
            this.btn_agregarSintoma.TabIndex = 60;
            this.btn_agregarSintoma.Text = "Agregar";
            this.btn_agregarSintoma.UseVisualStyleBackColor = true;
            this.btn_agregarSintoma.Click += new System.EventHandler(this.btn_agregarSintoma_Click);
            // 
            // btn_agregarEnfermedad
            // 
            this.btn_agregarEnfermedad.Location = new System.Drawing.Point(562, 202);
            this.btn_agregarEnfermedad.Name = "btn_agregarEnfermedad";
            this.btn_agregarEnfermedad.Size = new System.Drawing.Size(68, 25);
            this.btn_agregarEnfermedad.TabIndex = 61;
            this.btn_agregarEnfermedad.Text = "Agregar";
            this.btn_agregarEnfermedad.UseVisualStyleBackColor = true;
            this.btn_agregarEnfermedad.Click += new System.EventHandler(this.btn_agregarEnfermedad_Click);
            // 
            // lbl_warn_lb_sintomas
            // 
            this.lbl_warn_lb_sintomas.AutoSize = true;
            this.lbl_warn_lb_sintomas.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_lb_sintomas.Location = new System.Drawing.Point(79, 139);
            this.lbl_warn_lb_sintomas.Name = "lbl_warn_lb_sintomas";
            this.lbl_warn_lb_sintomas.Size = new System.Drawing.Size(168, 13);
            this.lbl_warn_lb_sintomas.TabIndex = 62;
            this.lbl_warn_lb_sintomas.Text = "Debe cargar al menos un sintoma.";
            this.lbl_warn_lb_sintomas.Visible = false;
            // 
            // lbl_warn_lb_enfermedades
            // 
            this.lbl_warn_lb_enfermedades.AutoSize = true;
            this.lbl_warn_lb_enfermedades.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_lb_enfermedades.Location = new System.Drawing.Point(359, 139);
            this.lbl_warn_lb_enfermedades.Name = "lbl_warn_lb_enfermedades";
            this.lbl_warn_lb_enfermedades.Size = new System.Drawing.Size(188, 13);
            this.lbl_warn_lb_enfermedades.TabIndex = 63;
            this.lbl_warn_lb_enfermedades.Text = "Debe cargar al menos una efermedad.";
            this.lbl_warn_lb_enfermedades.Visible = false;
            // 
            // lv_sintomas
            // 
            this.lv_sintomas.Location = new System.Drawing.Point(78, 41);
            this.lv_sintomas.Name = "lv_sintomas";
            this.lv_sintomas.Size = new System.Drawing.Size(191, 95);
            this.lv_sintomas.TabIndex = 64;
            this.lv_sintomas.UseCompatibleStateImageBehavior = false;
            this.lv_sintomas.View = System.Windows.Forms.View.List;
            // 
            // lv_enfermedades
            // 
            this.lv_enfermedades.Location = new System.Drawing.Point(362, 41);
            this.lv_enfermedades.Name = "lv_enfermedades";
            this.lv_enfermedades.Size = new System.Drawing.Size(191, 95);
            this.lv_enfermedades.TabIndex = 65;
            this.lv_enfermedades.UseCompatibleStateImageBehavior = false;
            this.lv_enfermedades.View = System.Windows.Forms.View.List;
            // 
            // CargarDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 313);
            this.Controls.Add(this.lv_enfermedades);
            this.Controls.Add(this.lv_sintomas);
            this.Controls.Add(this.lbl_warn_lb_enfermedades);
            this.Controls.Add(this.lbl_warn_lb_sintomas);
            this.Controls.Add(this.btn_agregarEnfermedad);
            this.Controls.Add(this.btn_agregarSintoma);
            this.Controls.Add(this.lbl_warn_enfermedades);
            this.Controls.Add(this.lbl_warn_sintomas);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_enfermedades);
            this.Controls.Add(this.txt_sintomas);
            this.Name = "CargarDiagnostico";
            this.Text = "CargarDiagnostico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_sintomas;
        private System.Windows.Forms.RichTextBox txt_enfermedades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label lbl_warn_sintomas;
        private System.Windows.Forms.Label lbl_warn_enfermedades;
        private System.Windows.Forms.Button btn_agregarSintoma;
        private System.Windows.Forms.Button btn_agregarEnfermedad;
        private System.Windows.Forms.Label lbl_warn_lb_sintomas;
        private System.Windows.Forms.Label lbl_warn_lb_enfermedades;
        private System.Windows.Forms.ListView lv_sintomas;
        private System.Windows.Forms.ListView lv_enfermedades;
    }
}
namespace ClinicaFrba.Compra_Bono
{
    partial class CompraBonos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroAfi = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.nudCantBonos = new System.Windows.Forms.NumericUpDown();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPA = new System.Windows.Forms.Label();
            this.lblPB = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantBonos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nro Afiliado";
            // 
            // txtNroAfi
            // 
            this.txtNroAfi.Enabled = false;
            this.txtNroAfi.Location = new System.Drawing.Point(73, 12);
            this.txtNroAfi.Name = "txtNroAfi";
            this.txtNroAfi.Size = new System.Drawing.Size(121, 20);
            this.txtNroAfi.TabIndex = 51;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(25, 101);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(49, 13);
            this.lblCant.TabIndex = 54;
            this.lblCant.Text = "Cantidad";
            this.lblCant.Visible = false;
            // 
            // nudCantBonos
            // 
            this.nudCantBonos.Location = new System.Drawing.Point(80, 97);
            this.nudCantBonos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantBonos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantBonos.Name = "nudCantBonos";
            this.nudCantBonos.Size = new System.Drawing.Size(81, 20);
            this.nudCantBonos.TabIndex = 53;
            this.nudCantBonos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantBonos.Visible = false;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(180, 89);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(98, 28);
            this.btnComprar.TabIndex = 55;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Visible = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(200, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 20);
            this.btnBuscar.TabIndex = 56;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblPA
            // 
            this.lblPA.AutoSize = true;
            this.lblPA.Location = new System.Drawing.Point(23, 46);
            this.lblPA.Name = "lblPA";
            this.lblPA.Size = new System.Drawing.Size(64, 13);
            this.lblPA.TabIndex = 57;
            this.lblPA.Text = "Plan Actual:";
            this.lblPA.Visible = false;
            // 
            // lblPB
            // 
            this.lblPB.AutoSize = true;
            this.lblPB.Location = new System.Drawing.Point(23, 69);
            this.lblPB.Name = "lblPB";
            this.lblPB.Size = new System.Drawing.Size(65, 13);
            this.lblPB.TabIndex = 58;
            this.lblPB.Text = "Precio Bono";
            this.lblPB.Visible = false;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(103, 45);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(27, 13);
            this.lblPlan.TabIndex = 59;
            this.lblPlan.Text = "xxxx";
            this.lblPlan.Visible = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(103, 69);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(27, 13);
            this.lblPrecio.TabIndex = 60;
            this.lblPrecio.Text = "xxxx";
            this.lblPrecio.Visible = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(284, 91);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(98, 28);
            this.btnAtras.TabIndex = 61;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // CompraBonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 126);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.lblPB);
            this.Controls.Add(this.lblPA);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.nudCantBonos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNroAfi);
            this.Name = "CompraBonos";
            this.Text = "Compra de Bonos";
            this.Load += new System.EventHandler(this.CompraBonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantBonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroAfi;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.NumericUpDown nudCantBonos;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPA;
        private System.Windows.Forms.Label lblPB;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAtras;
    }
}
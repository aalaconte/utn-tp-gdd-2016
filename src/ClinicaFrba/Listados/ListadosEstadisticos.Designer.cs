namespace ClinicaFrba.Listados
{
    partial class ListadosEstadisticos
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
            this.cb_listados = new System.Windows.Forms.ComboBox();
            this.cb_año = new System.Windows.Forms.ComboBox();
            this.cb_semestre = new System.Windows.Forms.ComboBox();
            this.cb_meses = new System.Windows.Forms.ComboBox();
            this.dgv_listados = new System.Windows.Forms.DataGridView();
            this.btn_ver = new System.Windows.Forms.Button();
            this.chb_semestre = new System.Windows.Forms.CheckBox();
            this.chb_meses = new System.Windows.Forms.CheckBox();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.chb_plan = new System.Windows.Forms.CheckBox();
            this.lbl_warn_año = new System.Windows.Forms.Label();
            this.chb_tcan = new System.Windows.Forms.CheckBox();
            this.cb_tcan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listados)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_listados
            // 
            this.cb_listados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_listados.Location = new System.Drawing.Point(123, 12);
            this.cb_listados.Name = "cb_listados";
            this.cb_listados.Size = new System.Drawing.Size(572, 21);
            this.cb_listados.TabIndex = 0;
            this.cb_listados.SelectedIndexChanged += new System.EventHandler(this.cb_listados_SelectedIndexChanged);
            // 
            // cb_año
            // 
            this.cb_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_año.Location = new System.Drawing.Point(12, 60);
            this.cb_año.Name = "cb_año";
            this.cb_año.Size = new System.Drawing.Size(107, 21);
            this.cb_año.TabIndex = 1;
            this.cb_año.SelectedIndexChanged += new System.EventHandler(this.cb_año_SelectedIndexChanged);
            // 
            // cb_semestre
            // 
            this.cb_semestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_semestre.Enabled = false;
            this.cb_semestre.Location = new System.Drawing.Point(258, 60);
            this.cb_semestre.Name = "cb_semestre";
            this.cb_semestre.Size = new System.Drawing.Size(107, 21);
            this.cb_semestre.TabIndex = 2;
            this.cb_semestre.Visible = false;
            this.cb_semestre.SelectedIndexChanged += new System.EventHandler(this.cb_semestre_SelectedIndexChanged);
            // 
            // cb_meses
            // 
            this.cb_meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_meses.Enabled = false;
            this.cb_meses.Location = new System.Drawing.Point(475, 60);
            this.cb_meses.Name = "cb_meses";
            this.cb_meses.Size = new System.Drawing.Size(107, 21);
            this.cb_meses.TabIndex = 3;
            this.cb_meses.Visible = false;
            // 
            // dgv_listados
            // 
            this.dgv_listados.AllowUserToAddRows = false;
            this.dgv_listados.AllowUserToDeleteRows = false;
            this.dgv_listados.AllowUserToResizeColumns = false;
            this.dgv_listados.AllowUserToResizeRows = false;
            this.dgv_listados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listados.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_listados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listados.Location = new System.Drawing.Point(12, 143);
            this.dgv_listados.MultiSelect = false;
            this.dgv_listados.Name = "dgv_listados";
            this.dgv_listados.ReadOnly = true;
            this.dgv_listados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listados.Size = new System.Drawing.Size(682, 137);
            this.dgv_listados.TabIndex = 52;
            // 
            // btn_ver
            // 
            this.btn_ver.Location = new System.Drawing.Point(583, 109);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(112, 28);
            this.btn_ver.TabIndex = 53;
            this.btn_ver.Text = "Ver";
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // chb_semestre
            // 
            this.chb_semestre.AutoSize = true;
            this.chb_semestre.Location = new System.Drawing.Point(163, 62);
            this.chb_semestre.Name = "chb_semestre";
            this.chb_semestre.Size = new System.Drawing.Size(89, 17);
            this.chb_semestre.TabIndex = 54;
            this.chb_semestre.Text = "Por Semestre";
            this.chb_semestre.UseVisualStyleBackColor = true;
            this.chb_semestre.Visible = false;
            this.chb_semestre.CheckedChanged += new System.EventHandler(this.chb_semestre_CheckedChanged);
            // 
            // chb_meses
            // 
            this.chb_meses.AutoSize = true;
            this.chb_meses.Location = new System.Drawing.Point(404, 62);
            this.chb_meses.Name = "chb_meses";
            this.chb_meses.Size = new System.Drawing.Size(65, 17);
            this.chb_meses.TabIndex = 55;
            this.chb_meses.Text = "Por Mes";
            this.chb_meses.UseVisualStyleBackColor = true;
            this.chb_meses.Visible = false;
            this.chb_meses.CheckedChanged += new System.EventHandler(this.chb_meses_CheckedChanged);
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(12, 44);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(26, 13);
            this.lbl_ano.TabIndex = 56;
            this.lbl_ano.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Seleccionar listado:";
            // 
            // cbPlan
            // 
            this.cbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlan.Enabled = false;
            this.cbPlan.Location = new System.Drawing.Point(102, 109);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(107, 21);
            this.cbPlan.TabIndex = 58;
            this.cbPlan.Visible = false;
            // 
            // chb_plan
            // 
            this.chb_plan.AutoSize = true;
            this.chb_plan.Location = new System.Drawing.Point(30, 111);
            this.chb_plan.Name = "chb_plan";
            this.chb_plan.Size = new System.Drawing.Size(66, 17);
            this.chb_plan.TabIndex = 59;
            this.chb_plan.Text = "Por Plan";
            this.chb_plan.UseVisualStyleBackColor = true;
            this.chb_plan.Visible = false;
            this.chb_plan.CheckedChanged += new System.EventHandler(this.chb_plan_CheckedChanged);
            // 
            // lbl_warn_año
            // 
            this.lbl_warn_año.AutoSize = true;
            this.lbl_warn_año.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_año.Location = new System.Drawing.Point(9, 84);
            this.lbl_warn_año.Name = "lbl_warn_año";
            this.lbl_warn_año.Size = new System.Drawing.Size(220, 13);
            this.lbl_warn_año.TabIndex = 60;
            this.lbl_warn_año.Text = "Debe seleccionar un Año para ver el informe.";
            this.lbl_warn_año.Visible = false;
            // 
            // chb_tcan
            // 
            this.chb_tcan.AutoSize = true;
            this.chb_tcan.Location = new System.Drawing.Point(268, 111);
            this.chb_tcan.Name = "chb_tcan";
            this.chb_tcan.Size = new System.Drawing.Size(128, 17);
            this.chb_tcan.TabIndex = 62;
            this.chb_tcan.Text = "Por Tipo Cancelacion";
            this.chb_tcan.UseVisualStyleBackColor = true;
            this.chb_tcan.Visible = false;
            this.chb_tcan.CheckedChanged += new System.EventHandler(this.chb_tcan_CheckedChanged);
            // 
            // cb_tcan
            // 
            this.cb_tcan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tcan.Enabled = false;
            this.cb_tcan.Location = new System.Drawing.Point(402, 109);
            this.cb_tcan.Name = "cb_tcan";
            this.cb_tcan.Size = new System.Drawing.Size(107, 21);
            this.cb_tcan.TabIndex = 61;
            this.cb_tcan.Visible = false;
            // 
            // ListadosEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 351);
            this.Controls.Add(this.chb_tcan);
            this.Controls.Add(this.cb_tcan);
            this.Controls.Add(this.lbl_warn_año);
            this.Controls.Add(this.chb_plan);
            this.Controls.Add(this.cbPlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ano);
            this.Controls.Add(this.chb_meses);
            this.Controls.Add(this.chb_semestre);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.dgv_listados);
            this.Controls.Add(this.cb_meses);
            this.Controls.Add(this.cb_semestre);
            this.Controls.Add(this.cb_año);
            this.Controls.Add(this.cb_listados);
            this.Name = "ListadosEstadisticos";
            this.Text = "ListadosEstadisticos";
            this.Load += new System.EventHandler(this.ListadosEstadisticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_listados;
        private System.Windows.Forms.ComboBox cb_año;
        private System.Windows.Forms.ComboBox cb_semestre;
        private System.Windows.Forms.ComboBox cb_meses;
        private System.Windows.Forms.DataGridView dgv_listados;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.CheckBox chb_semestre;
        private System.Windows.Forms.CheckBox chb_meses;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.CheckBox chb_plan;
        private System.Windows.Forms.Label lbl_warn_año;
        private System.Windows.Forms.CheckBox chb_tcan;
        private System.Windows.Forms.ComboBox cb_tcan;
    }
}
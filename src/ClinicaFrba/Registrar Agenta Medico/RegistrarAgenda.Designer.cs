namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class RegistrarAgenda
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
            this.lbl_profesionales = new System.Windows.Forms.Label();
            this.lbl_especialidades = new System.Windows.Forms.Label();
            this.cmb_especialidades = new System.Windows.Forms.ComboBox();
            this.cmb_hora_desde_lunes = new System.Windows.Forms.ComboBox();
            this.cmb_hora_hasta_lunes = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_profesional = new System.Windows.Forms.TextBox();
            this.btn_buscar_profesional = new System.Windows.Forms.Button();
            this.chk_sabado = new System.Windows.Forms.CheckBox();
            this.chk_viernes = new System.Windows.Forms.CheckBox();
            this.chk_jueves = new System.Windows.Forms.CheckBox();
            this.chk_martes = new System.Windows.Forms.CheckBox();
            this.chk_miercoles = new System.Windows.Forms.CheckBox();
            this.chk_lunes = new System.Windows.Forms.CheckBox();
            this.cmb_hora_hasta_martes = new System.Windows.Forms.ComboBox();
            this.cmb_hora_desde_martes = new System.Windows.Forms.ComboBox();
            this.cmb_hora_hasta_miercoles = new System.Windows.Forms.ComboBox();
            this.cmb_hora_desde_miercoles = new System.Windows.Forms.ComboBox();
            this.cmb_hora_hasta_jueves = new System.Windows.Forms.ComboBox();
            this.cmb_hora_desde_jueves = new System.Windows.Forms.ComboBox();
            this.cmb_hora_hasta_viernes = new System.Windows.Forms.ComboBox();
            this.cmb_hora_desde_viernes = new System.Windows.Forms.ComboBox();
            this.cmb_hora_hasta_sabado = new System.Windows.Forms.ComboBox();
            this.cmb_hora_desde_sabado = new System.Windows.Forms.ComboBox();
            this.lbl_warn_especialidad = new System.Windows.Forms.Label();
            this.lbl_warn_horarios = new System.Windows.Forms.Label();
            this.lbl_error_lunes = new System.Windows.Forms.Label();
            this.lbl_error_horas_profesional = new System.Windows.Forms.Label();
            this.lbl_warn_profesional = new System.Windows.Forms.Label();
            this.cmb_error_lunes = new System.Windows.Forms.ComboBox();
            this.lbl_error_jueves = new System.Windows.Forms.Label();
            this.cmb_error_jueves = new System.Windows.Forms.ComboBox();
            this.cmb_error_martes = new System.Windows.Forms.ComboBox();
            this.lbl_error_martes = new System.Windows.Forms.Label();
            this.cmb_error_viernes = new System.Windows.Forms.ComboBox();
            this.lbl_error_viernes = new System.Windows.Forms.Label();
            this.cmb_error_miercoles = new System.Windows.Forms.ComboBox();
            this.lbl_error_miercoles = new System.Windows.Forms.Label();
            this.cmb_error_sabado = new System.Windows.Forms.ComboBox();
            this.lbl_error_sabado = new System.Windows.Forms.Label();
            this.lbl_warn_dia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_profesionales
            // 
            this.lbl_profesionales.AutoSize = true;
            this.lbl_profesionales.Location = new System.Drawing.Point(12, 36);
            this.lbl_profesionales.Name = "lbl_profesionales";
            this.lbl_profesionales.Size = new System.Drawing.Size(62, 13);
            this.lbl_profesionales.TabIndex = 1;
            this.lbl_profesionales.Text = "Profesional:";
            // 
            // lbl_especialidades
            // 
            this.lbl_especialidades.AutoSize = true;
            this.lbl_especialidades.Location = new System.Drawing.Point(12, 68);
            this.lbl_especialidades.Name = "lbl_especialidades";
            this.lbl_especialidades.Size = new System.Drawing.Size(146, 13);
            this.lbl_especialidades.TabIndex = 2;
            this.lbl_especialidades.Text = "Seleccione una especialidad:";
            // 
            // cmb_especialidades
            // 
            this.cmb_especialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_especialidades.FormattingEnabled = true;
            this.cmb_especialidades.Location = new System.Drawing.Point(174, 65);
            this.cmb_especialidades.Name = "cmb_especialidades";
            this.cmb_especialidades.Size = new System.Drawing.Size(121, 21);
            this.cmb_especialidades.TabIndex = 3;
            this.cmb_especialidades.SelectedIndexChanged += new System.EventHandler(this.cmb_especialidades_SelectedIndexChanged);
            // 
            // cmb_hora_desde_lunes
            // 
            this.cmb_hora_desde_lunes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_desde_lunes.Enabled = false;
            this.cmb_hora_desde_lunes.FormattingEnabled = true;
            this.cmb_hora_desde_lunes.Location = new System.Drawing.Point(90, 113);
            this.cmb_hora_desde_lunes.Name = "cmb_hora_desde_lunes";
            this.cmb_hora_desde_lunes.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_desde_lunes.TabIndex = 8;
            this.cmb_hora_desde_lunes.SelectedIndexChanged += new System.EventHandler(this.cmb_hora_desde_lunes_SelectedIndexChanged);
            // 
            // cmb_hora_hasta_lunes
            // 
            this.cmb_hora_hasta_lunes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_hasta_lunes.Enabled = false;
            this.cmb_hora_hasta_lunes.FormattingEnabled = true;
            this.cmb_hora_hasta_lunes.Location = new System.Drawing.Point(217, 113);
            this.cmb_hora_hasta_lunes.Name = "cmb_hora_hasta_lunes";
            this.cmb_hora_hasta_lunes.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_hasta_lunes.TabIndex = 9;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(648, 306);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 10;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(567, 306);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_profesional
            // 
            this.txt_profesional.Enabled = false;
            this.txt_profesional.Location = new System.Drawing.Point(80, 33);
            this.txt_profesional.Name = "txt_profesional";
            this.txt_profesional.ReadOnly = true;
            this.txt_profesional.Size = new System.Drawing.Size(131, 20);
            this.txt_profesional.TabIndex = 12;
            this.txt_profesional.TextChanged += new System.EventHandler(this.txt_profesional_TextChanged);
            // 
            // btn_buscar_profesional
            // 
            this.btn_buscar_profesional.Location = new System.Drawing.Point(220, 31);
            this.btn_buscar_profesional.Name = "btn_buscar_profesional";
            this.btn_buscar_profesional.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_profesional.TabIndex = 13;
            this.btn_buscar_profesional.Text = "Buscar";
            this.btn_buscar_profesional.UseVisualStyleBackColor = true;
            this.btn_buscar_profesional.Click += new System.EventHandler(this.btn_buscar_profesional_Click);
            // 
            // chk_sabado
            // 
            this.chk_sabado.AutoSize = true;
            this.chk_sabado.Location = new System.Drawing.Point(357, 223);
            this.chk_sabado.Name = "chk_sabado";
            this.chk_sabado.Size = new System.Drawing.Size(63, 17);
            this.chk_sabado.TabIndex = 5;
            this.chk_sabado.Text = "Sábado";
            this.chk_sabado.UseVisualStyleBackColor = true;
            this.chk_sabado.CheckedChanged += new System.EventHandler(this.chk_sabado_CheckedChanged);
            // 
            // chk_viernes
            // 
            this.chk_viernes.AutoSize = true;
            this.chk_viernes.Location = new System.Drawing.Point(357, 169);
            this.chk_viernes.Name = "chk_viernes";
            this.chk_viernes.Size = new System.Drawing.Size(61, 17);
            this.chk_viernes.TabIndex = 4;
            this.chk_viernes.Text = "Viernes";
            this.chk_viernes.UseVisualStyleBackColor = true;
            this.chk_viernes.CheckedChanged += new System.EventHandler(this.chk_viernes_CheckedChanged_1);
            // 
            // chk_jueves
            // 
            this.chk_jueves.AutoSize = true;
            this.chk_jueves.Location = new System.Drawing.Point(357, 115);
            this.chk_jueves.Name = "chk_jueves";
            this.chk_jueves.Size = new System.Drawing.Size(60, 17);
            this.chk_jueves.TabIndex = 3;
            this.chk_jueves.Text = "Jueves";
            this.chk_jueves.UseVisualStyleBackColor = true;
            this.chk_jueves.CheckedChanged += new System.EventHandler(this.chk_jueves_CheckedChanged);
            // 
            // chk_martes
            // 
            this.chk_martes.AutoSize = true;
            this.chk_martes.Location = new System.Drawing.Point(15, 169);
            this.chk_martes.Name = "chk_martes";
            this.chk_martes.Size = new System.Drawing.Size(58, 17);
            this.chk_martes.TabIndex = 2;
            this.chk_martes.Text = "Martes";
            this.chk_martes.UseVisualStyleBackColor = true;
            this.chk_martes.CheckedChanged += new System.EventHandler(this.chk_martes_CheckedChanged);
            // 
            // chk_miercoles
            // 
            this.chk_miercoles.AutoSize = true;
            this.chk_miercoles.Location = new System.Drawing.Point(15, 223);
            this.chk_miercoles.Name = "chk_miercoles";
            this.chk_miercoles.Size = new System.Drawing.Size(71, 17);
            this.chk_miercoles.TabIndex = 1;
            this.chk_miercoles.Text = "Miércoles";
            this.chk_miercoles.UseVisualStyleBackColor = true;
            this.chk_miercoles.CheckedChanged += new System.EventHandler(this.chk_miercoles_CheckedChanged);
            // 
            // chk_lunes
            // 
            this.chk_lunes.AutoSize = true;
            this.chk_lunes.Location = new System.Drawing.Point(15, 115);
            this.chk_lunes.Name = "chk_lunes";
            this.chk_lunes.Size = new System.Drawing.Size(55, 17);
            this.chk_lunes.TabIndex = 0;
            this.chk_lunes.Text = "Lunes";
            this.chk_lunes.UseVisualStyleBackColor = true;
            this.chk_lunes.CheckedChanged += new System.EventHandler(this.chk_lunes_CheckedChanged);
            // 
            // cmb_hora_hasta_martes
            // 
            this.cmb_hora_hasta_martes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_hasta_martes.Enabled = false;
            this.cmb_hora_hasta_martes.FormattingEnabled = true;
            this.cmb_hora_hasta_martes.Location = new System.Drawing.Point(217, 167);
            this.cmb_hora_hasta_martes.Name = "cmb_hora_hasta_martes";
            this.cmb_hora_hasta_martes.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_hasta_martes.TabIndex = 16;
            // 
            // cmb_hora_desde_martes
            // 
            this.cmb_hora_desde_martes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_desde_martes.Enabled = false;
            this.cmb_hora_desde_martes.FormattingEnabled = true;
            this.cmb_hora_desde_martes.Location = new System.Drawing.Point(90, 167);
            this.cmb_hora_desde_martes.Name = "cmb_hora_desde_martes";
            this.cmb_hora_desde_martes.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_desde_martes.TabIndex = 15;
            this.cmb_hora_desde_martes.SelectedIndexChanged += new System.EventHandler(this.cmb_hora_desde_martes_SelectedIndexChanged);
            // 
            // cmb_hora_hasta_miercoles
            // 
            this.cmb_hora_hasta_miercoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_hasta_miercoles.Enabled = false;
            this.cmb_hora_hasta_miercoles.FormattingEnabled = true;
            this.cmb_hora_hasta_miercoles.Location = new System.Drawing.Point(217, 221);
            this.cmb_hora_hasta_miercoles.Name = "cmb_hora_hasta_miercoles";
            this.cmb_hora_hasta_miercoles.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_hasta_miercoles.TabIndex = 18;
            // 
            // cmb_hora_desde_miercoles
            // 
            this.cmb_hora_desde_miercoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_desde_miercoles.Enabled = false;
            this.cmb_hora_desde_miercoles.FormattingEnabled = true;
            this.cmb_hora_desde_miercoles.Location = new System.Drawing.Point(90, 221);
            this.cmb_hora_desde_miercoles.Name = "cmb_hora_desde_miercoles";
            this.cmb_hora_desde_miercoles.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_desde_miercoles.TabIndex = 17;
            this.cmb_hora_desde_miercoles.SelectedIndexChanged += new System.EventHandler(this.cmb_hora_desde_miercoles_SelectedIndexChanged);
            // 
            // cmb_hora_hasta_jueves
            // 
            this.cmb_hora_hasta_jueves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_hasta_jueves.Enabled = false;
            this.cmb_hora_hasta_jueves.FormattingEnabled = true;
            this.cmb_hora_hasta_jueves.Location = new System.Drawing.Point(559, 113);
            this.cmb_hora_hasta_jueves.Name = "cmb_hora_hasta_jueves";
            this.cmb_hora_hasta_jueves.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_hasta_jueves.TabIndex = 20;
            // 
            // cmb_hora_desde_jueves
            // 
            this.cmb_hora_desde_jueves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_desde_jueves.Enabled = false;
            this.cmb_hora_desde_jueves.FormattingEnabled = true;
            this.cmb_hora_desde_jueves.Location = new System.Drawing.Point(432, 113);
            this.cmb_hora_desde_jueves.Name = "cmb_hora_desde_jueves";
            this.cmb_hora_desde_jueves.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_desde_jueves.TabIndex = 19;
            this.cmb_hora_desde_jueves.SelectedIndexChanged += new System.EventHandler(this.cmb_hora_desde_jueves_SelectedIndexChanged);
            // 
            // cmb_hora_hasta_viernes
            // 
            this.cmb_hora_hasta_viernes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_hasta_viernes.Enabled = false;
            this.cmb_hora_hasta_viernes.FormattingEnabled = true;
            this.cmb_hora_hasta_viernes.Location = new System.Drawing.Point(559, 167);
            this.cmb_hora_hasta_viernes.Name = "cmb_hora_hasta_viernes";
            this.cmb_hora_hasta_viernes.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_hasta_viernes.TabIndex = 22;
            // 
            // cmb_hora_desde_viernes
            // 
            this.cmb_hora_desde_viernes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_desde_viernes.Enabled = false;
            this.cmb_hora_desde_viernes.FormattingEnabled = true;
            this.cmb_hora_desde_viernes.Location = new System.Drawing.Point(432, 167);
            this.cmb_hora_desde_viernes.Name = "cmb_hora_desde_viernes";
            this.cmb_hora_desde_viernes.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_desde_viernes.TabIndex = 21;
            this.cmb_hora_desde_viernes.SelectedIndexChanged += new System.EventHandler(this.cmb_hora_desde_viernes_SelectedIndexChanged);
            // 
            // cmb_hora_hasta_sabado
            // 
            this.cmb_hora_hasta_sabado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_hasta_sabado.Enabled = false;
            this.cmb_hora_hasta_sabado.FormattingEnabled = true;
            this.cmb_hora_hasta_sabado.Location = new System.Drawing.Point(559, 221);
            this.cmb_hora_hasta_sabado.Name = "cmb_hora_hasta_sabado";
            this.cmb_hora_hasta_sabado.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_hasta_sabado.TabIndex = 24;
            // 
            // cmb_hora_desde_sabado
            // 
            this.cmb_hora_desde_sabado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora_desde_sabado.Enabled = false;
            this.cmb_hora_desde_sabado.FormattingEnabled = true;
            this.cmb_hora_desde_sabado.Location = new System.Drawing.Point(432, 221);
            this.cmb_hora_desde_sabado.Name = "cmb_hora_desde_sabado";
            this.cmb_hora_desde_sabado.Size = new System.Drawing.Size(121, 21);
            this.cmb_hora_desde_sabado.TabIndex = 23;
            this.cmb_hora_desde_sabado.SelectedIndexChanged += new System.EventHandler(this.cmb_hora_desde_sabado_SelectedIndexChanged);
            // 
            // lbl_warn_especialidad
            // 
            this.lbl_warn_especialidad.AutoSize = true;
            this.lbl_warn_especialidad.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_especialidad.Location = new System.Drawing.Point(171, 89);
            this.lbl_warn_especialidad.Name = "lbl_warn_especialidad";
            this.lbl_warn_especialidad.Size = new System.Drawing.Size(176, 13);
            this.lbl_warn_especialidad.TabIndex = 25;
            this.lbl_warn_especialidad.Text = "Debe seleccionar una especialidad!";
            this.lbl_warn_especialidad.Visible = false;
            // 
            // lbl_warn_horarios
            // 
            this.lbl_warn_horarios.AutoSize = true;
            this.lbl_warn_horarios.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_horarios.Location = new System.Drawing.Point(244, 311);
            this.lbl_warn_horarios.Name = "lbl_warn_horarios";
            this.lbl_warn_horarios.Size = new System.Drawing.Size(277, 13);
            this.lbl_warn_horarios.TabIndex = 26;
            this.lbl_warn_horarios.Text = "Seleccione un horario para todos los días seleccionados!";
            this.lbl_warn_horarios.Visible = false;
            // 
            // lbl_error_lunes
            // 
            this.lbl_error_lunes.AutoSize = true;
            this.lbl_error_lunes.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_lunes.Location = new System.Drawing.Point(40, 143);
            this.lbl_error_lunes.Name = "lbl_error_lunes";
            this.lbl_error_lunes.Size = new System.Drawing.Size(171, 13);
            this.lbl_error_lunes.TabIndex = 27;
            this.lbl_error_lunes.Text = "Conflictos con agendas existentes!";
            this.lbl_error_lunes.Visible = false;
            this.lbl_error_lunes.Click += new System.EventHandler(this.lbl_error_lunes_Click);
            // 
            // lbl_error_horas_profesional
            // 
            this.lbl_error_horas_profesional.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_horas_profesional.Location = new System.Drawing.Point(432, 49);
            this.lbl_error_horas_profesional.Name = "lbl_error_horas_profesional";
            this.lbl_error_horas_profesional.Size = new System.Drawing.Size(265, 45);
            this.lbl_error_horas_profesional.TabIndex = 33;
            this.lbl_error_horas_profesional.Text = "Con las agendas generadas, el profesional acumularía {0} hs semanales. El máximo " +
    "permitido son 48 hs.";
            this.lbl_error_horas_profesional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_error_horas_profesional.Visible = false;
            // 
            // lbl_warn_profesional
            // 
            this.lbl_warn_profesional.AutoSize = true;
            this.lbl_warn_profesional.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_profesional.Location = new System.Drawing.Point(301, 36);
            this.lbl_warn_profesional.Name = "lbl_warn_profesional";
            this.lbl_warn_profesional.Size = new System.Drawing.Size(159, 13);
            this.lbl_warn_profesional.TabIndex = 34;
            this.lbl_warn_profesional.Text = "Debe seleccionar un profesional";
            this.lbl_warn_profesional.Visible = false;
            // 
            // cmb_error_lunes
            // 
            this.cmb_error_lunes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_error_lunes.FormattingEnabled = true;
            this.cmb_error_lunes.Location = new System.Drawing.Point(217, 140);
            this.cmb_error_lunes.Name = "cmb_error_lunes";
            this.cmb_error_lunes.Size = new System.Drawing.Size(121, 21);
            this.cmb_error_lunes.TabIndex = 35;
            this.cmb_error_lunes.Visible = false;
            // 
            // lbl_error_jueves
            // 
            this.lbl_error_jueves.AutoSize = true;
            this.lbl_error_jueves.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_jueves.Location = new System.Drawing.Point(382, 143);
            this.lbl_error_jueves.Name = "lbl_error_jueves";
            this.lbl_error_jueves.Size = new System.Drawing.Size(171, 13);
            this.lbl_error_jueves.TabIndex = 36;
            this.lbl_error_jueves.Text = "Conflictos con agendas existentes!";
            this.lbl_error_jueves.Visible = false;
            // 
            // cmb_error_jueves
            // 
            this.cmb_error_jueves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_error_jueves.FormattingEnabled = true;
            this.cmb_error_jueves.Location = new System.Drawing.Point(559, 140);
            this.cmb_error_jueves.Name = "cmb_error_jueves";
            this.cmb_error_jueves.Size = new System.Drawing.Size(121, 21);
            this.cmb_error_jueves.TabIndex = 37;
            this.cmb_error_jueves.Visible = false;
            // 
            // cmb_error_martes
            // 
            this.cmb_error_martes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_error_martes.FormattingEnabled = true;
            this.cmb_error_martes.Location = new System.Drawing.Point(217, 194);
            this.cmb_error_martes.Name = "cmb_error_martes";
            this.cmb_error_martes.Size = new System.Drawing.Size(121, 21);
            this.cmb_error_martes.TabIndex = 39;
            this.cmb_error_martes.Visible = false;
            // 
            // lbl_error_martes
            // 
            this.lbl_error_martes.AutoSize = true;
            this.lbl_error_martes.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_martes.Location = new System.Drawing.Point(40, 197);
            this.lbl_error_martes.Name = "lbl_error_martes";
            this.lbl_error_martes.Size = new System.Drawing.Size(171, 13);
            this.lbl_error_martes.TabIndex = 38;
            this.lbl_error_martes.Text = "Conflictos con agendas existentes!";
            this.lbl_error_martes.Visible = false;
            // 
            // cmb_error_viernes
            // 
            this.cmb_error_viernes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_error_viernes.FormattingEnabled = true;
            this.cmb_error_viernes.Location = new System.Drawing.Point(559, 194);
            this.cmb_error_viernes.Name = "cmb_error_viernes";
            this.cmb_error_viernes.Size = new System.Drawing.Size(121, 21);
            this.cmb_error_viernes.TabIndex = 41;
            this.cmb_error_viernes.Visible = false;
            // 
            // lbl_error_viernes
            // 
            this.lbl_error_viernes.AutoSize = true;
            this.lbl_error_viernes.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_viernes.Location = new System.Drawing.Point(382, 197);
            this.lbl_error_viernes.Name = "lbl_error_viernes";
            this.lbl_error_viernes.Size = new System.Drawing.Size(171, 13);
            this.lbl_error_viernes.TabIndex = 40;
            this.lbl_error_viernes.Text = "Conflictos con agendas existentes!";
            this.lbl_error_viernes.Visible = false;
            // 
            // cmb_error_miercoles
            // 
            this.cmb_error_miercoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_error_miercoles.FormattingEnabled = true;
            this.cmb_error_miercoles.Location = new System.Drawing.Point(217, 248);
            this.cmb_error_miercoles.Name = "cmb_error_miercoles";
            this.cmb_error_miercoles.Size = new System.Drawing.Size(121, 21);
            this.cmb_error_miercoles.TabIndex = 43;
            this.cmb_error_miercoles.Visible = false;
            // 
            // lbl_error_miercoles
            // 
            this.lbl_error_miercoles.AutoSize = true;
            this.lbl_error_miercoles.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_miercoles.Location = new System.Drawing.Point(40, 251);
            this.lbl_error_miercoles.Name = "lbl_error_miercoles";
            this.lbl_error_miercoles.Size = new System.Drawing.Size(171, 13);
            this.lbl_error_miercoles.TabIndex = 42;
            this.lbl_error_miercoles.Text = "Conflictos con agendas existentes!";
            this.lbl_error_miercoles.Visible = false;
            // 
            // cmb_error_sabado
            // 
            this.cmb_error_sabado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_error_sabado.FormattingEnabled = true;
            this.cmb_error_sabado.Location = new System.Drawing.Point(559, 248);
            this.cmb_error_sabado.Name = "cmb_error_sabado";
            this.cmb_error_sabado.Size = new System.Drawing.Size(121, 21);
            this.cmb_error_sabado.TabIndex = 45;
            this.cmb_error_sabado.Visible = false;
            // 
            // lbl_error_sabado
            // 
            this.lbl_error_sabado.AutoSize = true;
            this.lbl_error_sabado.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_sabado.Location = new System.Drawing.Point(382, 251);
            this.lbl_error_sabado.Name = "lbl_error_sabado";
            this.lbl_error_sabado.Size = new System.Drawing.Size(171, 13);
            this.lbl_error_sabado.TabIndex = 44;
            this.lbl_error_sabado.Text = "Conflictos con agendas existentes!";
            this.lbl_error_sabado.Visible = false;
            // 
            // lbl_warn_dia
            // 
            this.lbl_warn_dia.AutoSize = true;
            this.lbl_warn_dia.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn_dia.Location = new System.Drawing.Point(323, 298);
            this.lbl_warn_dia.Name = "lbl_warn_dia";
            this.lbl_warn_dia.Size = new System.Drawing.Size(97, 13);
            this.lbl_warn_dia.TabIndex = 46;
            this.lbl_warn_dia.Text = "Seleccione un día!";
            this.lbl_warn_dia.Visible = false;
            // 
            // RegistrarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 341);
            this.Controls.Add(this.lbl_warn_dia);
            this.Controls.Add(this.cmb_error_sabado);
            this.Controls.Add(this.lbl_error_sabado);
            this.Controls.Add(this.cmb_error_miercoles);
            this.Controls.Add(this.lbl_error_miercoles);
            this.Controls.Add(this.cmb_error_viernes);
            this.Controls.Add(this.lbl_error_viernes);
            this.Controls.Add(this.cmb_error_martes);
            this.Controls.Add(this.lbl_error_martes);
            this.Controls.Add(this.cmb_error_jueves);
            this.Controls.Add(this.lbl_error_jueves);
            this.Controls.Add(this.cmb_error_lunes);
            this.Controls.Add(this.lbl_warn_profesional);
            this.Controls.Add(this.lbl_error_horas_profesional);
            this.Controls.Add(this.lbl_error_lunes);
            this.Controls.Add(this.lbl_warn_horarios);
            this.Controls.Add(this.lbl_warn_especialidad);
            this.Controls.Add(this.cmb_hora_hasta_sabado);
            this.Controls.Add(this.cmb_hora_desde_sabado);
            this.Controls.Add(this.cmb_hora_hasta_viernes);
            this.Controls.Add(this.cmb_hora_desde_viernes);
            this.Controls.Add(this.cmb_hora_hasta_jueves);
            this.Controls.Add(this.cmb_hora_desde_jueves);
            this.Controls.Add(this.cmb_hora_hasta_miercoles);
            this.Controls.Add(this.cmb_hora_desde_miercoles);
            this.Controls.Add(this.cmb_hora_hasta_martes);
            this.Controls.Add(this.cmb_hora_desde_martes);
            this.Controls.Add(this.chk_sabado);
            this.Controls.Add(this.chk_viernes);
            this.Controls.Add(this.btn_buscar_profesional);
            this.Controls.Add(this.chk_jueves);
            this.Controls.Add(this.txt_profesional);
            this.Controls.Add(this.chk_miercoles);
            this.Controls.Add(this.chk_martes);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.chk_lunes);
            this.Controls.Add(this.cmb_hora_hasta_lunes);
            this.Controls.Add(this.cmb_hora_desde_lunes);
            this.Controls.Add(this.cmb_especialidades);
            this.Controls.Add(this.lbl_especialidades);
            this.Controls.Add(this.lbl_profesionales);
            this.Name = "RegistrarAgenda";
            this.Text = "Registrar Agenda de Médico";
            this.Load += new System.EventHandler(this.RegistrarAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_profesionales;
        private System.Windows.Forms.Label lbl_especialidades;
        private System.Windows.Forms.ComboBox cmb_especialidades;
        private System.Windows.Forms.ComboBox cmb_hora_desde_lunes;
        private System.Windows.Forms.ComboBox cmb_hora_hasta_lunes;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_profesional;
        private System.Windows.Forms.Button btn_buscar_profesional;
        private System.Windows.Forms.CheckBox chk_martes;
        private System.Windows.Forms.CheckBox chk_miercoles;
        private System.Windows.Forms.CheckBox chk_lunes;
        private System.Windows.Forms.CheckBox chk_jueves;
        private System.Windows.Forms.CheckBox chk_viernes;
        private System.Windows.Forms.CheckBox chk_sabado;
        private System.Windows.Forms.ComboBox cmb_hora_hasta_martes;
        private System.Windows.Forms.ComboBox cmb_hora_desde_martes;
        private System.Windows.Forms.ComboBox cmb_hora_hasta_miercoles;
        private System.Windows.Forms.ComboBox cmb_hora_desde_miercoles;
        private System.Windows.Forms.ComboBox cmb_hora_hasta_jueves;
        private System.Windows.Forms.ComboBox cmb_hora_desde_jueves;
        private System.Windows.Forms.ComboBox cmb_hora_hasta_viernes;
        private System.Windows.Forms.ComboBox cmb_hora_desde_viernes;
        private System.Windows.Forms.ComboBox cmb_hora_hasta_sabado;
        private System.Windows.Forms.ComboBox cmb_hora_desde_sabado;
        private System.Windows.Forms.Label lbl_warn_especialidad;
        private System.Windows.Forms.Label lbl_warn_horarios;
        private System.Windows.Forms.Label lbl_error_lunes;
        private System.Windows.Forms.Label lbl_error_horas_profesional;
        private System.Windows.Forms.Label lbl_warn_profesional;
        private System.Windows.Forms.ComboBox cmb_error_lunes;
        private System.Windows.Forms.Label lbl_error_jueves;
        private System.Windows.Forms.ComboBox cmb_error_jueves;
        private System.Windows.Forms.ComboBox cmb_error_martes;
        private System.Windows.Forms.Label lbl_error_martes;
        private System.Windows.Forms.ComboBox cmb_error_viernes;
        private System.Windows.Forms.Label lbl_error_viernes;
        private System.Windows.Forms.ComboBox cmb_error_miercoles;
        private System.Windows.Forms.Label lbl_error_miercoles;
        private System.Windows.Forms.ComboBox cmb_error_sabado;
        private System.Windows.Forms.Label lbl_error_sabado;
        private System.Windows.Forms.Label lbl_warn_dia;
    }
}
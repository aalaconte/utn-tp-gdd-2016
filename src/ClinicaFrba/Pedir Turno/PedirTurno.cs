using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Abm_Especialidades_Medicas;
using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.BaseDeDatos;
using ClinicaFrba.BaseDeDatos.Componentes;
using ClinicaFrba.Registrar_Agenta_Medico;
using ClinicaFrba.Utils;
using ClinicaFrba.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class PedirTurno : Form
    {
        private static readonly int minutosEntreTurnos = int.Parse(ConfigurationManager.AppSettings["tiempo.entre.turnos.minutos"]);
        private Afiliado afiliado;
        private Profesional profesional;
        private List<Especialidad> especialidades = new List<Especialidad>();
        private List<AgendaProfesional> agendas = new List<AgendaProfesional>();
        private List<Turno> turnosOcupados = new List<Turno>();
        private List<Turno> turnosAOfrecer = new List<Turno>();
        TimeSpan incrementoHorario = new TimeSpan(0, minutosEntreTurnos, 0);

        public PedirTurno()
        {
            InitializeComponent();
            this.afiliado = obtenerAfiliadoConUsername();
            Console.WriteLine("Afiliado: " + this.afiliado.getUsername() + " - " + this.afiliado.getApellido() + ", " + this.afiliado.getNombre());

        }

        private void btn_buscar_profesional_Click(object sender, EventArgs e)
        {
            using (BuscarProfesionales buscarProfesional = new BuscarProfesionales())
            {
                if (buscarProfesional.ShowDialog().Equals(DialogResult.OK))
                {
                    try
                    {
                        //inicializarCampos
                        this.lbl_error_profesional.Visible = false;
                        this.dgv_turnos_disponibles.Rows.Clear();
                        this.profesional = buscarProfesional.ProfesionalReturn;
                        this.txt_profesional.Text = this.profesional.Apellido + ", " + this.profesional.Nombre;
                        //Ajustamos el ancho del Text de profesional
                        int anchoTextoPx = TextRenderer.MeasureText(this.txt_profesional.Text, this.txt_profesional.Font).Width;
                        if (anchoTextoPx > this.txt_profesional.Width)
                            this.txt_profesional.Width = anchoTextoPx;
                        //Obtenemos las especialidades del profesional seleccionado para cargar el Combo correspondiente
                        StringBuilder sqlEspecialidadesProfesional = new StringBuilder(ConfigurationManager.AppSettings["query.obtener.especialidades.profesional.select"]);
                        sqlEspecialidadesProfesional.Append(" WHERE");
                        sqlEspecialidadesProfesional.Append(ConfigurationManager.AppSettings["query.obtener.profesionales.where.nro.doc"].Replace("{2}", this.profesional.NroDoc.ToString()));
                        this.cmb_especialidad.Items.Clear();
                        ManipulacionComponentes.llenarComboBox(this.cmb_especialidad, sqlEspecialidadesProfesional.ToString(), "Especialidad");
                        this.cmb_especialidad.DropDownWidth = ManipulacionComponentes.obtenerDropDownMaxWidthCombo(this.cmb_especialidad);
                        this.especialidades = obtenerEspecialidadesProfesional(this.profesional.NroDoc, sqlEspecialidadesProfesional.ToString());

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        MessageBox.Show("Se produjo un error al consultar las especialidades del profesional: " + this.txt_profesional.Text, "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private List<Especialidad> obtenerEspecialidadesProfesional(int nroDoc, String query)
        {
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(query, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    List<Especialidad> especialidadesLocal = new List<Especialidad>();

                    while (sqlReader.Read())
                    {
                        especialidadesLocal.Add(new Especialidad(int.Parse(sqlReader["ID"].ToString()), sqlReader["Especialidad"].ToString()));
                    }

                    return especialidadesLocal;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void cmb_especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbl_error_especialidad.Visible = false;
            this.dgv_turnos_disponibles.Rows.Clear();
            this.agendas = obtenerAgendasProfesionalEspecialidad();
            List<DateTime> horariosOcupados = obtenerTurnosOcupados();
            List<DateTime> horariosAOfrecer = new List<DateTime>();
            DateTime fechaMin;
            DateTime fechaActualDate = DateTime.Parse(Program.fechaActual).Date;

            //Generamos los turnos a ofrecer por cada agenda disponible para el profesional y especialidad seleccionados
            foreach (AgendaProfesional agenda in this.agendas)
            {
                //Si la fechaDesde de la agenda es menor que la actual, tengo que chequear a partir de la actual
                if (agenda.FechaDesde < fechaActualDate)
                {
                    //La fecha actual puede no ser el día de la semana que tiene la agenda
                    // The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
                    int diasHastaSiguienteOcurrencia;
                    switch (agenda.Dia.Id)
                    {
                        case 2:
                            diasHastaSiguienteOcurrencia = ((int)DayOfWeek.Monday - (int)fechaActualDate.DayOfWeek + 7) % 7;
                            break;
                        case 3:
                            diasHastaSiguienteOcurrencia = ((int)DayOfWeek.Tuesday - (int)fechaActualDate.DayOfWeek + 7) % 7;
                            break;
                        case 4:
                            diasHastaSiguienteOcurrencia = ((int)DayOfWeek.Wednesday - (int)fechaActualDate.DayOfWeek + 7) % 7;
                            break;
                        case 5:
                            diasHastaSiguienteOcurrencia = ((int)DayOfWeek.Thursday - (int)fechaActualDate.DayOfWeek + 7) % 7;
                            break;
                        case 6:
                            diasHastaSiguienteOcurrencia = ((int)DayOfWeek.Friday - (int)fechaActualDate.DayOfWeek + 7) % 7;
                            break;
                        case 7:
                            diasHastaSiguienteOcurrencia = ((int)DayOfWeek.Saturday - (int)fechaActualDate.DayOfWeek + 7) % 7;
                            break;
                        default:
                            MessageBox.Show("Error al obtener siguiente día de la semana correspondiente al de la agenda");
                            return;
                    }

                    DateTime siguienteOcurrencia = fechaActualDate.AddDays(diasHastaSiguienteOcurrencia);
                    fechaMin = siguienteOcurrencia;
                }
                else
                {
                    //La fechaDesde de la agenda seguro es el día de la semana que le corresponde, la seteo como mínima
                    fechaMin = agenda.FechaDesde;
                }

                //Generamos los posibles turnos para mostrar los horarios que están disponibles
                horariosAOfrecer.AddRange(generarPosiblesTurnosAgenda(fechaMin, agenda, horariosOcupados));

            }

            //Cada turnoAOfrecer lo agregamos a la grilla para que le usuario pueda seleccionarlo
            foreach (DateTime horario in horariosAOfrecer)
            {
                var culture = new System.Globalization.CultureInfo("es-ES");
                this.dgv_turnos_disponibles.Rows.Add(new object[] { culture.DateTimeFormat.GetDayName(horario.DayOfWeek), horario });
            }

            this.lbl_error_turno.Visible = this.dgv_turnos_disponibles.RowCount == 0;
        }

        private List<AgendaProfesional> obtenerAgendasProfesionalEspecialidad()
        {
            List<AgendaProfesional> agendasReturn = new List<AgendaProfesional>();
            using (SqlConnection cx = Connection.getConnection())
            {
                Especialidad especialidadSeleccionada = this.especialidades.Find(especialidad => especialidad.Descripcion.Equals(this.cmb_especialidad.SelectedItem.ToString()));
                StringBuilder query = new StringBuilder(ConfigurationManager.AppSettings["query.obtener.agendas.select"].ToString());
                query.Append(ConfigurationManager.AppSettings["query.obtener.agendas.group.by"].ToString());
                query.Append(" HAVING");
                query.Append(ConfigurationManager.AppSettings["query.obtener.agendas.having.profesional"].Replace("{0}", this.profesional.NroDoc.ToString()).ToString());
                query.Append(" AND");
                query.Append(ConfigurationManager.AppSettings["query.obtener.agendas.having.especialidad"].Replace("{8}", especialidadSeleccionada.Id.ToString()));
                Console.WriteLine("Query:");
                Console.WriteLine(query.ToString());
                SqlCommand sqlCmd = new SqlCommand(query.ToString(), cx);
                sqlCmd.CommandType = CommandType.Text;
                try
                {
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        AgendaProfesional agenda = new AgendaProfesional();
                        agenda.Dia = new Dia((int)sqlReader["dia_id"], sqlReader["dia"].ToString());
                        agenda.Especialidad = especialidadSeleccionada;
                        agenda.FechaDesde = DateTime.Parse(sqlReader["fechaDesde"].ToString()).Date;
                        agenda.FechaHasta = DateTime.Parse(sqlReader["fechaHasta"].ToString()).Date;
                        agenda.hhDesde = TimeSpan.Parse(sqlReader["desde"].ToString());
                        agenda.hhHasta = TimeSpan.Parse(sqlReader["hasta"].ToString());
                        agendasReturn.Add(agenda);
                    }
                    sqlReader.Close();
                    sqlReader.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se ha producido un error al buscar las agendas para el profesional y la especialidad seleccionados");
                    Console.WriteLine(ex);
                    MessageBox.Show("Se ha producido un error al buscar las agendas para el profesional y la especialidad seleccionados", "Error al buscar especialidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return agendasReturn;
        }

        private List<DateTime> obtenerTurnosOcupados()
        {
            List<DateTime> horariosReturn = new List<DateTime>();

            //Obtenemos los turnos existentes para el profesional y especialidad seleccionados que no tienen cancelación y tienen fecha
            //mayor a la seteada como actual
            using (SqlConnection cx = Connection.getConnection())
            {

                Especialidad especialidadSeleccionada = this.especialidades.Find(especialidad => especialidad.Descripcion.Equals(this.cmb_especialidad.SelectedItem.ToString()));
                StringBuilder query = new StringBuilder(ConfigurationManager.AppSettings["query.obtener.turnos.select"].ToString());
                query.Append(" WHERE");
                query.Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.profesional"].Replace("{0}", this.profesional.NroDoc.ToString()).ToString());
                query.Append(" AND");
                query.Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.especialidad"].Replace("{2}", especialidadSeleccionada.Id.ToString()).ToString());
                query.Append(" AND");
                query.Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.not.cancelacion"].ToString());
                query.Append(" AND");
                query.Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.fecha.mayor.igual"].Replace("{3}", "'" + Program.fechaActual + "'"));
                Console.WriteLine("Query turnos profesional: ");
                Console.WriteLine(query.ToString());
                SqlCommand sqlCmd = new SqlCommand(query.ToString(), cx);
                sqlCmd.CommandType = CommandType.Text;
                try
                {
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    int i = 0;
                    while (sqlReader.Read())
                    {
                        i++;
                        horariosReturn.Add(DateTime.Parse(sqlReader["tur_fecha_hora"].ToString()));
                    }
                    Console.WriteLine("Cantidad turnos profesional: " + i);
                    sqlReader.Close();
                    sqlReader.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se ha producido un error al buscar los turnos para el profesional y la especialidad seleccionados");
                    Console.WriteLine(ex);
                    MessageBox.Show("Se ha producido un error al buscar los turnos para el profesional y la especialidad seleccionados", "Error al buscar especialidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Obtenemos los turnos existentes para el afiliado que no tienen cancelación
            using (SqlConnection cx = Connection.getConnection())
            {
                Especialidad especialidadSeleccionada = this.especialidades.Find(especialidad => especialidad.Descripcion.Equals(this.cmb_especialidad.SelectedItem.ToString()));
                StringBuilder query = new StringBuilder(ConfigurationManager.AppSettings["query.obtener.turnos.select"].ToString());
                query.Append(" WHERE");
                query.Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.afiliado"].Replace("{1}", this.afiliado.getDocumento().ToString()).ToString());
                query.Append(" AND");
                query.Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.not.cancelacion"].ToString());
                query.Append(" AND");
                query.Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.fecha.mayor.igual"].Replace("{3}", "'" + Program.fechaActual + "'"));
                Console.WriteLine("Query turnos afiliado: ");
                Console.WriteLine(query.ToString());
                SqlCommand sqlCmd = new SqlCommand(query.ToString(), cx);
                sqlCmd.CommandType = CommandType.Text;
                try
                {
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    int i = 0;
                    while (sqlReader.Read())
                    {
                        i++;
                        horariosReturn.Add(DateTime.Parse(sqlReader["tur_fecha_hora"].ToString()));
                    }
                    Console.WriteLine("Cantidad turnos afiliado: " + i);
                    sqlReader.Close();
                    sqlReader.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se ha producido un error al buscar los turnos para el afiliado y la especialidad seleccionados");
                    Console.WriteLine(ex);
                    MessageBox.Show("Se ha producido un error al buscar los turnos para el profesional y la especialidad seleccionados", "Error al buscar especialidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return horariosReturn;

        }

        private List<DateTime> generarPosiblesTurnosAgenda(DateTime fechaMin, AgendaProfesional agenda, List<DateTime> horariosOcupados)
        {
            List<Turno> turnosPosibles = new List<Turno>();
            List<DateTime> horariosPosibles = new List<DateTime>();

            //Seteo la fecha minima
            DateTime fechaActual = fechaMin;
            TimeSpan horario;

            //Mientras esté en el rango de fechas definido por la agenda
            while (fechaActual <= agenda.FechaHasta)
            {
                horario = agenda.hhDesde;
                DateTime fechaHoraTurnoPosible = fechaActual.Add(horario);

                //Mientras el horario esté dentro del rango definido por la agenda
                while (horario < agenda.hhHasta)
                {
                    //Si el horario no está tomado por alguno de los horariosOcupados, agrego a la lista de posibles turnos
                    if (horariosOcupados.Find(horarioOcupado => horarioOcupado.Equals(fechaHoraTurnoPosible)) == DateTime.MinValue)
                    {
                        horariosPosibles.Add(fechaHoraTurnoPosible);
                    }


                    //Incremento el horario
                    horario = horario.Add(this.incrementoHorario);
                    fechaHoraTurnoPosible = fechaHoraTurnoPosible.Add(this.incrementoHorario);
                }
                //Incremento la fecha
                fechaActual = fechaActual.AddDays(7);
            }

            return horariosPosibles;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private Afiliado obtenerAfiliadoConUsername()
        {
            StringBuilder query = new StringBuilder(ConfigurationManager.AppSettings["query.abm.afiliado.select"].ToString());
            query.Append(" AND usu.usu_username='" + Program.user + "'");
            Afiliado afiliado = new Afiliado();
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(query.ToString(), cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        afiliado.setApellido(sqlReader["Apellido"].ToString());
                        afiliado.setUsername(sqlReader["Usuario"].ToString());
                        afiliado.setNombre(sqlReader["Nombre"].ToString());
                        afiliado.setDocumento(sqlReader["Documento"].ToString());
                        afiliado.setNroAfiliado(sqlReader["Nro Afiliado"].ToString());
                        afiliado.setDireccion(sqlReader["Direccion"].ToString());
                        afiliado.setTelefono(sqlReader["Telefono"].ToString());
                        afiliado.setMail(sqlReader["Mail"].ToString());
                        afiliado.setFechaNac(sqlReader["Fecha de Nacimiento"].ToString());
                        afiliado.setEstadoCivil(sqlReader["Estado Civil"].ToString());
                        afiliado.setPlan(sqlReader["Plan"].ToString());
                        afiliado.setNroConsultas(sqlReader["Nro Consulta"].ToString());
                        afiliado.setHabilitado(sqlReader["Activo"].ToString().Equals("SI") ? true : false);
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }

                return afiliado;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (Mensajes.confirmaCambios())
                {

                    Especialidad especialidadSeleccionada = this.especialidades.Find(especialidad => especialidad.Descripcion.Equals(this.cmb_especialidad.SelectedItem.ToString()));
                    DateTime turnoSeleccionado = DateTime.Parse(this.dgv_turnos_disponibles.SelectedRows[0].Cells["fecha"].Value.ToString());
                    insertarTurno(int.Parse(this.afiliado.getDocumento()), this.profesional.NroDoc, especialidadSeleccionada.Id, turnoSeleccionado);
                    Mensajes.operacionExitosa();
                    this.Close();
                }

            }
        }

        private bool validar()
        {

            this.lbl_error_profesional.Visible = !ValidacionComponentes.textBoxLlenoCampo(this.txt_profesional);
            this.lbl_error_especialidad.Visible = !ValidacionComponentes.comboBoxSeleccionoOpcion(this.cmb_especialidad);
            this.lbl_error_turno.Visible = !this.lbl_error_especialidad.Visible && this.dgv_turnos_disponibles.RowCount == 0;
            this.lbl_error_horario.Visible = this.dgv_turnos_disponibles.RowCount > 0 && this.dgv_turnos_disponibles.SelectedRows.Count == 0;

            //Pasa la validación si no está visible ninguno de los labels de error
            return !(this.lbl_error_turno.Visible || this.lbl_error_profesional.Visible || this.lbl_error_horario.Visible ||
                        this.lbl_error_especialidad.Visible);
        }

        private void insertarTurno(int nroDocAfi, int nroDocProf, int espId, DateTime fechaHoraTurno)
        {
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    cx.Open();
                    SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.darTurno", cx);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add("@nroDocAfi", SqlDbType.Decimal).Value = nroDocAfi;
                    sqlCmd.Parameters.Add("@nroDocProf", SqlDbType.Decimal).Value = nroDocProf;
                    sqlCmd.Parameters.Add("@espId", SqlDbType.Int).Value = espId;
                    sqlCmd.Parameters.Add("@fechaHoraTurno", SqlDbType.DateTime).Value = fechaHoraTurno;
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR AL INSERTAR EL TURNO");
                    Console.WriteLine(ex);
                    MessageBox.Show("Se produjo un error al insertar el turno", "Error al registrar el turno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

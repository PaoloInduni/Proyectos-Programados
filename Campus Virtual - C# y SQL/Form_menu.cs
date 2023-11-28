using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace EZUni
{
    public partial class Form_menu : Form
    {

        // Inicializar variables para conexión a la BD

        private MySqlConnection conn;

        public Form_menu()
        {
            InitializeComponent();

            Logic logic = new Logic();

            // Conexión con la base de datos

            conn = logic.conectarMySQL();
        }

        // X de salida (UI)
        private void lbl_xSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Muestra ventana para calcular nota de curso
        private void btn_calcularNota_Click(object sender, EventArgs e)
        {
            Form_calcularNota calcularNota = new Form_calcularNota();
            calcularNota.Visible = true;

            actualizar();
        }

        // Abre ventana para modificar cursos de la BD en el modo de "AGREGAR"
        private void lbl_agregarCurso_Click(object sender, EventArgs e)
        {

            Form_editarCurso formCurso = new Form_editarCurso();
            formCurso.ElegirModo(1);

            formCurso.Visible = true;

            actualizar();

        }

        // Abre ventana para modificar cursos de la BD en el modo de "ELIMINAR"
        private void lbl_quitarCurso_Click(object sender, EventArgs e)
        {
            Form_editarCurso formCurso = new Form_editarCurso();
            formCurso.ElegirModo(0);

            formCurso.Visible = true;

            actualizar();
        }

        // Abre ventana para modificar evaluaciones de la BD en el modo de "AGREGAR"
        private void lbl_agregarAsignacion_Click(object sender, EventArgs e)
        {
            Form_editarEvaluacion formEvaluacion = new Form_editarEvaluacion();
            formEvaluacion.ElegirModo(1);
            formEvaluacion.cargarCursos();

            formEvaluacion.Visible = true;

            actualizar();
        }

        // Abre ventana para modificar evaluaciones de la BD en el modo de "ELIMINAR"
        private void lbl_quitarAsignacion_Click(object sender, EventArgs e)
        {
            Form_editarEvaluacion formEvaluacion = new Form_editarEvaluacion();
            formEvaluacion.ElegirModo(0);

            formEvaluacion.Visible = true;

            actualizar();
        }

        // Refresca contenido del grid box
        private void lbl_actualizarGrid_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        // Refresca contenido de la lista
        private void lbl_actualizarLista_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        // Refrescar contenido del DataGrid, ListBox y ComboBox
        public void actualizar()
        {

            // Actualiza contanido del DataGrid
            try
            {

                conn.Open();

                // Crea comando de MySQL y ejecuta la sentencia

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM cursos;", conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable daTable = new DataTable();
                adapter.Fill(daTable);
                dg_cursos.DataSource = daTable;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cursos de la BD", "Error!");
            }

            // Actualiza contanido de la Lista
            try
            {

                // Limpia el contenido de la lista

                listbox_asignaciones.Items.Clear();

                conn.Open();

                // Crea comando de MySQL y ejecuta la sentencia

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM evaluaciones", conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()){
                    listbox_asignaciones.Items.Add(dr["Nombre"]);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las evaluaciones de la BD", "Error!");
            }

            // Actualiza contanido de la ComboBox
            try
            {

                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM cursos", conn); // Crea comando de MySQL

                // Crea un adaptador de datos y llena el DataSet con esos datos

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                cmd.ExecuteNonQuery(); // Ejecuta el Query

                conn.Close();

                // Llena el combo box con los cursos de la BD

                combo_curso.DataSource = ds.Tables[0]; 
                combo_curso.DisplayMember = "Nombre";
                combo_curso.ValueMember = "Nombre";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cursos de la base de datos", "Error");
            }
        }

        // Filtra las asignaciones por curso
        private void combo_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                // Limpia el contenido de la lista

                listbox_asignaciones.Items.Clear();

                conn.Open();

                // Crea comando de MySQL y ejecuta la sentencia

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM evaluaciones WHERE Curso = '"+combo_curso.Text+"';", conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()){
                    listbox_asignaciones.Items.Add(dr["Nombre"]);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las evaluaciones de la BD", "Error!");
            }
        }
    }
}
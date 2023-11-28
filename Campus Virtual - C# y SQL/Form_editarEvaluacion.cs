using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace EZUni
{
    public partial class Form_editarEvaluacion : Form
    {

        // Inicializar variables para conexión a la BD

        private MySqlConnection conn;

        // Modo se usa para indicar la acción a efectuar en la función que edita los cursos dentro de la base de datos

        private int modo;

        public Form_editarEvaluacion()
        {
            InitializeComponent();

            Logic logic = new Logic();

            // Conexión con la base de datos

            conn = logic.conectarMySQL();

        }

        private void btn_evaluacion_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = conn.CreateCommand(); // Crea comando de MySQL

            if (modo == 0){ // Caso 0: Eliminar curso (Modifica el comando SQL a un DELETE)

                lbl_agregarEvaluacion.Text = "ELIMINAR EVALUACIÓN";

                cmd.CommandText = "DELETE FROM evaluaciones WHERE Nombre = '" + txt_nombreEvaluacion.Text + "';";

            }else{ // Caso X: Agregar curso (Modifica el comando SQL a un INSERT)

                lbl_agregarEvaluacion.Text = "AGREGAR EVALUACIÓN";

                cmd.CommandText = "INSERT INTO evaluaciones(Nombre, Curso, ValorPorcentual, Nota) VALUES('" + txt_nombreEvaluacion.Text + "','" + combo_curso.Text + "','" + float.Parse(txt_valorPorcentual.Text, CultureInfo.InvariantCulture.NumberFormat) + "',NULL);";
            }

            try{

                // Abre conexión y  ejecuta el comando creado anteriormente

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                while (reader.Read()) { }

                conn.Close();

            }catch (Exception ex){
                MessageBox.Show("Información Inválida o Evaluación repetida", "Error!");
            }

            this.Dispose();
        }

        // Selecciona el modo, 1 = Agregar Curso, 0 = Eliminar Curso
        public void ElegirModo(int num)
        {
            modo = num;

            // Caso 0: Oculta todo menos el nombre de curso para eliminarlo de la base de datos

            if (modo == 0){

                lbl_agregarEvaluacion.Text = "ELIMINAR EVALUACIÓN";

                txt_valorPorcentual.Visible = false;
                combo_curso.Visible = false;
                dateTime_fechaEntrega.Visible = false;

                lbl_curso.Visible = false;
                lbl_valorPorcentual.Visible = false;
                lbl_ejemploPorcentaje.Visible = false;
                lbl_fechaEntrega.Visible = false;

            }
        }

        // X de salida (UI)
        private void lbl_xSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // Carga los cursos en el ComboBox
        public void cargarCursos()
        {
            try {

                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM cursos", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();

                conn.Close();

                combo_curso.DataSource = ds.Tables[0];

                Console.WriteLine(ds.Tables[0]);

                combo_curso.DisplayMember = "Nombre";
                combo_curso.ValueMember = "Nombre";

            }
            catch (Exception ex){

                MessageBox.Show("Error al cargar los cursos de la base de datos");

            }
        }
    }
}
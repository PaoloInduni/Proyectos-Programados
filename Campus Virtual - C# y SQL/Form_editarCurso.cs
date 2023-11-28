using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EZUni
{
    public partial class Form_editarCurso : Form
    {

        // Inicializar variables para conexión a la BD

        private MySqlConnection conn;

        // Modo se usa para indicar la acción a efectuar en la función que edita los cursos dentro de la base de datos

        private int modo;

        public Form_editarCurso()
        {
            InitializeComponent();

            Logic logic = new Logic();

            // Conexión con la base de datos

            conn = logic.conectarMySQL();

        }

        // X de salida (UI)
        private void lbl_xSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // Modifica los cursos de la base de datos
        private void btn_curso_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = conn.CreateCommand(); // Crea comando de MySQL

            // Caso 0: Eliminar curso (Modifica el comando SQL a un DELETE)

            if (modo == 0){

                lbl_agregarCurso.Text = "ELIMINAR CURSO";

                cmd.CommandText = "DELETE FROM cursos WHERE Nombre = '" + txt_nombreCurso.Text + "';";

            }else{ // Caso X: Agregar curso (Modifica el comando SQL a un INSERT)

                lbl_agregarCurso.Text = "AGREGAR CURSO";

                cmd.CommandText = "INSERT INTO cursos(Nombre, Profesor, Carrera, Horario) VALUES('" + txt_nombreCurso.Text + "','" + txt_profesor.Text + "','" + txt_carrera.Text + "','" + combo_dia.Text + "');";
            }

            try{
                
                // Abre conexión y  ejecuta el comando creado anteriormente

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                while (reader.Read()){}

                conn.Close();

            }catch (Exception ex){
                MessageBox.Show("Información Inválida o Curso repetido", "Error!");
            }

            // Cierra la ventana al terminar de ejecutar el comando

            this.Dispose();
        }


        // Selecciona el modo, 1 = Agregar Curso, 0 = Eliminar Curso
        public void ElegirModo(int num)
        {
            modo = num;

            // Caso 0: Oculta todo menos el nombre de curso para eliminarlo de la base de datos

            if(modo == 0){

                lbl_agregarCurso.Text = "ELIMINAR CURSO";

                txt_carrera.Visible = false;
                txt_profesor.Visible = false;
                combo_dia.Visible = false;

                lbl_profesor.Visible = false;
                lbl_carrera.Visible = false;
                lbl_horario.Visible = false;

            }
        }
    }
}
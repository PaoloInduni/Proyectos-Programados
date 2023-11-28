using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EZUni
{
    public partial class EZUni_login : Form
    {

        private MySqlConnection conn;

        public EZUni_login()
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


        // Boton de login
        private void btn_login_Click(object sender, EventArgs e)
        {

            // Crea comando de MySQL

            MySqlCommand cmd = conn.CreateCommand();

            // En este caso el comando es un select a la tabla usuarios con el usuario ingresado

            cmd.CommandText = "SELECT * from usuarios WHERE username ='"+txt_username.Text+"'";

            try {

                // Abre la conexión

                conn.Open();

                // Ejecuta el comando

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                // Evalua los datos ingresados por el usuario en la base de datos

                if (txt_username.Text.Equals(reader.GetFieldValue<string>(0)) && txt_password.Text.Equals(reader.GetFieldValue<string>(2))){

                    // If true: entra al menú

                    this.Visible = false;

                    Form_menu menu = new Form_menu();
                    menu.actualizar();
                    menu.Visible = true;

                }
                else{

                    // Muestra mensaje de error por credenciales incorrectas

                    MessageBox.Show("Usuario o contraseña incorrecto(s)", "Error");
                }

                // Cierra la conexión

                conn.Close();

            }catch{

                // Muestra mensaje de error por consulta de base de datos

                MessageBox.Show("Usuario o contraseña incorrecto(s)", "Error!");

                // Cierra la conexión en caso de error

                conn.Close();
            }
        }
    }
}
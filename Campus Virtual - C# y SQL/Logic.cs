using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace EZUni
{
    internal class Logic
    {
        // Inicializar variables para conexión a la BD

        private string server;
        private string database;
        private string user;
        private string password;
        private string connectionString;

        public MySqlConnection conectarMySQL()
        {

            // Variables para conexión con la base de datos

            server = "127.0.0.1";
            database = "EZUNI";
            user = "root";
            password = "1234";
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}", server, user, password, database);

            // Conexión con la base de datos

            return new MySqlConnection(connectionString);
        }
    }
}
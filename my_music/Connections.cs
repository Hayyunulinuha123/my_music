using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace my_music
{
    class Connections
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection koneksi = null;

            try
            {
                string sConnstring = "server = localhost;database= db_music;username=root;password=;";
                koneksi = new MySqlConnection(sConnstring);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return koneksi;
        }
    }
}

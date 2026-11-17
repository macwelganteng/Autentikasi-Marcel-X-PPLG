using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


namespace ScholAPP2
{
    internal class Connection
    {
        public MySqlConnection ConnectionToSQL()
        {
            string strConenection = "Server=localhost;Database=pi_school;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConenection);
            return conn;
        }

    }
}

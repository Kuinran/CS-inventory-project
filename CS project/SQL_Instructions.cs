﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CS_project
{
    static class SQL_Instructions
    {
        public static MySql.Data.MySqlClient.MySqlConnection SQL_Connect(String serverLoc, 
            String username, String dbname, String port, String password)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = null;
            string connstr = String.Format("server={0};user={1};database={2};port={3};password={4}",
                serverLoc, username, dbname, port, password);
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(connstr);
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Debug.Write(ex);
                return null;
            }
            return conn;
        }

        public static void SQL_Disconnect(MySql.Data.MySqlClient.MySqlConnection conn)
        {
            conn.Close();
        }
    }
}

using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Fingerprint_Authentication
{
    class DB_ATM_Data_Connection
    {
        private MySqlConnection conn_data;
        public MySqlConnection Connect_Details()
        {
            conn_data = new MySqlConnection("UID=root;PASSWORD=JainamOvez1211;SERVER=localhost;DATABASE=bank_details");
            conn_data.Open();
            return conn_data;

        }
    
    }
}
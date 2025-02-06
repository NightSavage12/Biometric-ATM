using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Fingerprint_Authentication
{
    class DB_ATM_Fingerprint_Connection
    {
        private MySqlConnection conn_finger;
        public MySqlConnection Connect_Fingerprint()
        {
            conn_finger = new MySqlConnection("UID=root;PASSWORD=JainamOvez1211;SERVER=localhost;DATABASE=bank_details");
            conn_finger.Open();
            return conn_finger;

        }
    
    }
}

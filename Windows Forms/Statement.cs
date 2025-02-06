using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Fingerprint_Authentication.Windows_Forms;

namespace Fingerprint_Authentication.Windows_Forms
{
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB_ATM_Data_Connection db_data = new DB_ATM_Data_Connection();
            DB_ATM_Fingerprint_Connection db_finger = new DB_ATM_Fingerprint_Connection();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM data_conn WHERE CardNo=" + ATM_Machine.cardno;
            MySqlCommand cmd = new MySqlCommand(query, db_data.Connect_Details());
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            label1.Text = "Name :" + Convert.ToString(dt.Rows[0][4]);
            label2.Text = "Card No :" + Convert.ToString(dt.Rows[0][2]);
            label3.Text = "Balance :" + Convert.ToString(dt.Rows[0][3]);
        }
    }
}

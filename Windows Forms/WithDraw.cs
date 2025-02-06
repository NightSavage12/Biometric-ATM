using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Fingerprint_Authentication.Windows_Forms;
using System.Threading;

namespace Fingerprint_Authentication.Windows_Forms
{
    public partial class WithDraw : Form
    {
        public WithDraw()
        {
            InitializeComponent();
        }
        int flag = 1, click = 1, count = 1;
        int cardno, balance, old;
        DB_ATM_Data_Connection db_data = new DB_ATM_Data_Connection();
        DB_ATM_Fingerprint_Connection db_finger = new DB_ATM_Fingerprint_Connection();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 0;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "THANKS TO VISIT TO ATM MACHINE";
            Thread.Sleep(2000);
            this.Hide();
            ATM_Machine next = new ATM_Machine();
            next.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Correction_Click(object sender, EventArgs e)
        {
            txtb_input.Text = "";
        }

        private void Next_Click(object sender, EventArgs e)
        {
            click = 1;

            if (click == 1)
            {
                
            }
        }

        private void Enterr_Click(object sender, EventArgs e)
        {
            if (click == 1)
            {
                if (flag == 1)
                {
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    string query = "SELECT AccBalance FROM data_conn WHERE CardNo=" + ATM_Machine.cardno;
                    MySqlCommand cmd = new MySqlCommand(query, db_data.Connect_Details());
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        balance = dataReader.GetInt32(0);
                        old = balance;

                    }
                    if (Convert.ToInt32(txtb_input.Text) > old)
                    {
                        MessageBox.Show("Error Insuffcient Balance");
                        txtb_input.Text = "";
                        return;
                    }
                    

                    lbl_middle.Text = Convert.ToString(old);
                    balance -= Convert.ToInt32(txtb_input.Text);
                    lbl_middle.Text = Convert.ToString(old);
                    string query1 = "UPDATE data_conn SET AccBalance='" + balance + "' WHERE CardNo='" + ATM_Machine.cardno + "'";


                    //create mysql command
                    MySqlCommand cmd2 = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd2.CommandText = query1;
                    //Assign the connection using Connection
                    cmd2.Connection = db_data.Connect_Details();
                    //Execute query
                    cmd2.ExecuteNonQuery();

                    lbl_upper.Hide();
                    textBox1.Hide();
                    lbl_middle.Text = "Account Closing Balance :  " + balance;
                    db_data.Connect_Details().Close();

                }
            }


        }
    


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

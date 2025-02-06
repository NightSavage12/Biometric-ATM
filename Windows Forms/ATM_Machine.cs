using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Fingerprint_Authentication.Windows_Forms;

namespace Fingerprint_Authentication
{
    public partial class ATM_Machine : Form
    {
        public ATM_Machine()
        {
            InitializeComponent();
          
           
        }

        public static int cardno = 0;
        int flag = 1, click = 0, count = 1;

        DB_ATM_Data_Connection db_data = new DB_ATM_Data_Connection();
        DB_ATM_Fingerprint_Connection db_finger = new DB_ATM_Fingerprint_Connection();

        private void ATM_Machine_Load(object sender, EventArgs e)
        {
            //Hiding unnecessary fields.
            txtb_input.Visible = false;
            pic_swipe.Visible = false;

            lbl_middle.Text = "WELCOME TO ATM MACHINE";
        }

        private void btn_key_1_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 1;
        }

        private void btn_key_2_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 2;
        }

        private void btn_key_3_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 3;
        }

        private void btn_key_4_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 4;
        }

        private void btn_key_5_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 5;
        }

        private void btn_key_6_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 6;
        }

        private void btn_key_7_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 7;
        }

        private void btn_key_8_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 8;
        }

        private void btn_key_9_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 9;
        }

        private void btn_key_0_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lbl_upper.Visible = false;
            lbl_lower.Visible = false;
            txtb_input.Visible = false;
            lbl_name.Visible = false;
            lbl_acc.Visible = false;

            lbl_middle.Text = "THANKS TO VISIT TO ATM MACHINE";
        }

        private void btn_correction_Click(object sender, EventArgs e)
        {
            txtb_input.Text = "";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            click = 1;

            if (click == 1)
            {
                lbl_middle.Text = "ENTER YOUR CARD NUMBER";
                txtb_input.Visible = true;
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (click == 1)
            {
                if (flag == 1)
                {
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    string query = "SELECT * FROM data_conn WHERE CardNo='" + txtb_input.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, db_data.Connect_Details());
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dt.Load(dataReader);
                    ds.Tables.Add(dt);

                    
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lbl_middle.Text = "ENTER YOUR PIN-CODE";
                        flag = 2;
                        cardno = Convert.ToInt32(txtb_input.Text);
                        this.Hide();
                        FP_Comparision next = new FP_Comparision();
                        next.Show();
                    }

                    else
                    {
                        if (count <= 3)
                        {
                            lbl_upper.Text = "SORRY YOU HAD DONE A WRONG ATTEMPT";
                            lbl_middle.Text = "Please Re-Insert The Card";
                            txtb_input.Text = "";
                            count++;
                        }

                        else
                        {
                            flag = 4;
                        }
                    }
                }

                else if (flag == 2)
                {
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    string query1 = "SELECT * FROM data_conn WHERE Name= '" + lbl_name.Text +"'";
                    MySqlCommand cmd = new MySqlCommand(query1, db_data.Connect_Details());
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dt.Load(dataReader);
                    ds.Tables.Add(dt);
                    db_data.Connect_Details().Close();

                    count = 1;

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //lbl_upper.Text = "Congrats" + "  " + ds.Tables[0].Rows[0][1].ToString();
                        lbl_upper.Text = "FINGERPRINT SECURITY MENU";
                        lbl_middle.Text = "SWIPE YOUR FINGER";
                        pic_swipe.Visible = true;
                        txtb_input.Visible = false;
                        flag = 3;
                    }

                    else
                    {
                        if (count <= 3)
                        {
                            lbl_upper.Text = "SORRY YOU HAD DONE A WRONG ATTEMPT";
                            lbl_middle.Text = "Please Re-Insert The PIN-CODE";
                            txtb_input.Text = "";
                            count++;
                        }

                        else
                        {
                            flag = 4;
                        }
                    }
                }

                else if (flag == 3)
                {
                    pic_swipe.Visible = false;
                    lbl_lower.Visible = true;
                    lbl_upper.Text = "Thanks to visiting here";
                    lbl_middle.Text = "Now you are ready for your further \n Transaction with Details \n";
                    lbl_lower.Text = "Name:" + " " + lbl_name.Text + "\n" + "accont no:" + lbl_acc.Text;
                }

                else if (flag == 4)
                {
                    pic_swipe.Visible = false;
                    lbl_lower.Visible = true;
                    lbl_upper.Text = "You HAVE ENTERED WRONG AUTHENTICATION \nMORE THAN THRICE";
                }
            }
        }
    }
}

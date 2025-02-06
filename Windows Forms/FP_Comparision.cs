using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Fingerprint_Authentication.Windows_Forms;

namespace Fingerprint_Authentication.Windows_Forms
{
    public partial class FP_Comparision : Form
    {
        Bitmap bitmap1, bitmap2;
       
        public FP_Comparision()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openflg = new OpenFileDialog();
            if (openflg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openflg.FileName;
                bitmap1 = new Bitmap(openflg.FileName);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
           
            bool compare = ImageCompareString(bitmap1, bitmap2);
            if (compare == true)
            {
                ///MessageBox.Show("Access Granted");
                this.Hide();
                ATM_Operation next = new ATM_Operation();
                next.Show();
            }
            else
            {
                MessageBox.Show("Access Denied");

            }
        }

        private void FP_Comparision_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DB_ATM_Data_Connection db_data = new DB_ATM_Data_Connection();
            DB_ATM_Fingerprint_Connection db_finger = new DB_ATM_Fingerprint_Connection();
            string query = "SELECT * FROM fp_data WHERE CardNo=" + ATM_Machine.cardno;
            MySqlCommand cmd = new MySqlCommand(query, db_data.Connect_Details());
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            byte[] img = (byte[])dt.Rows[0][1];
            pictureBox2.Image = ByteToImage(img);
            MemoryStream mStream = new MemoryStream();
            byte[] pData = img;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            bitmap2 = new Bitmap(mStream, false);
            // byte[] byteArray = (byte[])dt.Rows[0][1];
            //Bitmap bitmap2= BitmapFactory.decodeByteArray(byteArray, 0, byteArray.length);

        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;

        }

        private bool ImageCompareString(Bitmap bitmap11, Bitmap bitmap21)

        {
            //   throw new NotImplementedException();
            MemoryStream ms = new MemoryStream();
            string firstbitmap;
            try
            {
                bitmap11.Save(ms, ImageFormat.Png);
                firstbitmap = Convert.ToBase64String(ms.ToArray());
                ms.Position = 0;
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("FingerPrint Not Found");
                return false;
            }
            bitmap21.Save(ms, ImageFormat.Png);
            string secondbitmap = Convert.ToBase64String(ms.ToArray());
            ms.Position = 0;

            if (firstbitmap.Equals(secondbitmap))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

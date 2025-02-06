using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fingerprint_Authentication.Windows_Forms
{
    public partial class ATM_Operation : Form
    {
        public ATM_Operation()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "THANKS TO VISIT TO ATM MACHINE";
            Thread.Sleep(3000);
            this.Hide();
            ATM_Machine next = new ATM_Machine();
            next.Show();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Select AnyOne Option.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithDraw next = new WithDraw();
            next.Show();
            
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit next = new Deposit();
            next.Show();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statement next = new Statement();
            next.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

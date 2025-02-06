
namespace Fingerprint_Authentication.Windows_Forms
{
    partial class ATM_Operation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM_Operation));
            this.Cancel = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.BackgroundImage = global::Fingerprint_Authentication.Properties.Resources.Cancel_Button;
            this.Cancel.Location = new System.Drawing.Point(428, 531);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 31);
            this.Cancel.TabIndex = 10;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.BackgroundImage = global::Fingerprint_Authentication.Properties.Resources._3arrow;
            this.Withdraw.Location = new System.Drawing.Point(568, 241);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(64, 32);
            this.Withdraw.TabIndex = 14;
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // Deposit
            // 
            this.Deposit.BackgroundImage = global::Fingerprint_Authentication.Properties.Resources._3arrow;
            this.Deposit.Location = new System.Drawing.Point(568, 283);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(64, 34);
            this.Deposit.TabIndex = 15;
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Check
            // 
            this.Check.BackgroundImage = global::Fingerprint_Authentication.Properties.Resources._3arrow;
            this.Check.Location = new System.Drawing.Point(568, 326);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(64, 33);
            this.Check.TabIndex = 16;
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fingerprint_Authentication.Properties.Resources._3arrow;
            this.pictureBox1.Location = new System.Drawing.Point(568, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 33);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(227, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(336, 247);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(276, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = " Select Action ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(277, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 26);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Deposit";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(277, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 24);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "WithDraw";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(277, 326);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 24);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = "Check Account Balance";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Next
            // 
            this.Next.BackgroundImage = global::Fingerprint_Authentication.Properties.Resources.Next_Button;
            this.Next.Location = new System.Drawing.Point(428, 597);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(76, 35);
            this.Next.TabIndex = 12;
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ATM_Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(754, 768);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Cancel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ATM_Operation";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Next;
    }
}
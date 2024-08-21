using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSMC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            displayUsername();
        }

        public void displayUsername()
        {
            string getUsername = Form1.username;

            greetUser.Text = getUsername.Substring(0, 1).ToUpper() + getUsername.Substring(1);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            budget_form transaction_Form = new budget_form();
            transaction_Form.Show();

            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void budget_button_Click(object sender, EventArgs e)
        {
            budget_form transaction_Form = new budget_form();
            transaction_Form.Show();

            this.Hide();
        }

        private void expense_button_Click(object sender, EventArgs e)
        {
            
        }

        private void budget_pic_Click(object sender, EventArgs e)
        {
            budget_form transaction_Form = new budget_form();
            transaction_Form.Show();

            this.Hide();
        }

        private void budget_text1_Click(object sender, EventArgs e)
        {
            budget_form transaction_Form = new budget_form();
            transaction_Form.Show();

            this.Hide();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                Form1 loginform=new Form1();
                loginform.Show();

                this.Hide();
            }
        }

        
    }
}

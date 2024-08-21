using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectSMC
{
    public partial class month1_budget : Form
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOAI NAM\Documents\expense.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOAI NAM\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
        public month1_budget()
        {
            InitializeComponent();
        }

       

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void month1_save_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string insertString = "INSERT INTO months (target)" + "VALUES(@target)";

                using(SqlCommand command = new SqlCommand(insertString, connect))
                {
                    command.Parameters.AddWithValue("@target",target_january.Text.Trim());
                    
                    MessageBox.Show("Save successfully!","Information message", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    budget_form transaction_Form = new budget_form();
                    transaction_Form.textBox1.Text = target_january.Text;
                    this.Hide();

                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

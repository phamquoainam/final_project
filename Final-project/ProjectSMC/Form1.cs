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
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectSMC
{
    public partial class Form1 : Form
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOAI NAM\Documents\expense.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOAI NAM\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 registerform = new Form2();
            registerform.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        public static string username;
        private void login_button_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using(SqlCommand command = new SqlCommand(selectData, connection))
                {
                    command.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                    command.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                    SqlDataAdapter Adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    Adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        username = login_username.Text;
                        MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainForm form = new MainForm();
                        form.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password/username", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

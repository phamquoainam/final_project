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

namespace ProjectSMC
{
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOAI NAM\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();

            this.Hide();
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void register_button_Click_1(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_cfpass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        //Check if the username is already exit
                        string selectUsername = "SELECT * FROM users WHERE username = @usern"; 

                        using(SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                //To Upcase the first letter
                                string tempUsern = register_username.Text.Substring(0,1).ToUpper() + register_username.Text.Substring(1);
                                MessageBox.Show(tempUsern + "is exiting already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid Password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text != register_cfpass.Text)
                            {
                                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, date_create) VALUES(@usern,@pass,@date)";

                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", register_password.Text.Trim());

                                    DateTime today = DateTime.Today;
                                    insertUser.Parameters.AddWithValue("@date", today);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();

                                    this.Hide();
                                }
                            }
                        }
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Failed Connection: " + ex, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }



        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showpass.Checked ? '\0' : '*';
            register_cfpass.PasswordChar = register_showpass.Checked ? '\0' : '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void Form2_Load_2(object sender, EventArgs e)
        {

        }
    }
}

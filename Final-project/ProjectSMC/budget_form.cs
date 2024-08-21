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
    public partial class budget_form : Form
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOAI NAM\Documents\expense.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOAI NAM\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
        public budget_form()
        {
            InitializeComponent();

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void month1_HoverMouse(object sender, EventArgs e)
        {
            month1_panel.BackColor = Color.DeepSkyBlue;
        }

        private void month1_LeaveMouse(object sender, EventArgs e)
        {
            month1_panel.BackColor = Color.DarkGray;
        }

        private void month2_HoverMouse(object sender, EventArgs e)
        {
            month2_panel.BackColor = Color.DeepSkyBlue;
        }

        private void month2_LeaveMouse(object sender, EventArgs e)
        {
            month2_panel.BackColor = Color.DarkGray;
        }

        private void month3_HoverMouse(object sender, EventArgs e)
        {
            month3_panel.BackColor = Color.DeepSkyBlue;
        }

        private void month3_LeaveMouse(object sender, EventArgs e)
        {
            month3_panel.BackColor = Color.DarkGray;
        }

        private void month4_HoverMouse(object sender, EventArgs e)
        {
            month4_panel.BackColor = Color.DeepSkyBlue;
        }

        private void month4_LeaveMouse(object sender, EventArgs e)
        {
            month4_panel.BackColor = Color.DarkGray;
        }

        private void month5_HoverMouse(object sender, EventArgs e)
        {
            month5_panel.BackColor = Color.DeepSkyBlue;
        }

        private void month5_LeaveMouse(object sender, EventArgs e)
        {
            month5_panel.BackColor = Color.DarkGray;
        }

        private void month6_HoverMouse(object sender, EventArgs e)
        {
            month6_panel.BackColor = Color.DeepSkyBlue;
        }

        private void month6_LeaveMouse(object sender, EventArgs e)
        {
            month6_panel.BackColor = Color.DarkGray;
        }

        private void month7_HoverMouse(object sender, EventArgs e)
        {
            month7_panel.BackColor = Color.DeepSkyBlue;
        }

        private void month7_LeaveMouse(object sender, EventArgs e)
        {
            month7_panel.BackColor = Color.DarkGray;
        }

        private void month8_HoverMouse(object sender, EventArgs e)
        {
            month8_panel.BackColor = Color.DeepSkyBlue;
        }

        private void month8_LeaveMouse(object sender, EventArgs e)
        {
            month8_panel.BackColor = Color.DarkGray;
        }

        private void month9_HoverMouse(object sender, EventArgs e)
        {
            month9_panel.BackColor = Color.DeepSkyBlue;
        }

        private void month9_LeaveMouse(object sender, EventArgs e)
        {
            month9_panel.BackColor = Color.DarkGray;
        }

        private void month10_HoverMouse(object sender, EventArgs e)
        {
            month10_panel.BackColor = Color.DeepSkyBlue;
        }

        private void month10_LeaveMouse(object sender, EventArgs e)
        {
            month10_panel.BackColor = Color.DarkGray;
        }

        private void month11_HoverMouse(object sender, EventArgs e)
        {
            month11_panel.BackColor = Color.DeepSkyBlue;
        }

        private void month11_LeaveMouse(object sender, EventArgs e)
        {
            month11_panel.BackColor = Color.DarkGray;
        }

        private void month12_HoverMouse(object sender, EventArgs e)
        {
            month12_panel.BackColor = Color.DeepSkyBlue;
        }

        private void month12_LeaveMouse(object sender, EventArgs e)
        {
            month12_panel.BackColor = Color.DarkGray;
        }

        private void month1_Click(object sender, EventArgs e)
        {
            month1_budget month1_Budget = new month1_budget();
            month1_Budget.Show();
        }

    

        private void transaction_form_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            month1_budget budget = new month1_budget();
            textBox1.Text = budget.target_january.Text;
        }
    }
}

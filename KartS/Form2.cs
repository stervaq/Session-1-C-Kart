using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartS
{
    public partial class Form2 : Form
    {

        static SqlConnection db = new SqlConnection( @"Data Source=DESKTOP-HR5RWB\VLAD;Initial Catalog=Karting;Integrated Security=True");
        DateTime DateOfStart = new DateTime(2022, 11, 24, 6, 0, 0);
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            label1.Text = $"До начала события осталось {different.Days} дней, {different.Hours} часов, {different.Minutes} минут и {different.Seconds} секунд.";

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        int k = 10;
        private void button3_Click(object sender, EventArgs e)
        {
            k += 10;
            string res = Convert.ToString(k);
            label13.Text = "$"+ res;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            k-=10;
            string res = Convert.ToString(k);
            label13.Text = "$"+ res;
            if (k <= 0)
            {

                k = 10;
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        public void comboBox1_Click(object sender, EventArgs e)
        {
            string query = "select * from Racer;";
            SqlCommand cmd = new SqlCommand(query, db);
            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Name  = reader["First_Name"].ToString();   
                string Last  = reader["Last_Name"].ToString();
                comboBox1.Items.Add(Name + " " + Last);
            }

            reader.Close();
            db.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(comboBox1.Text,label13.Text);
            frm.Show();
            this.Hide();
        }
    }
}

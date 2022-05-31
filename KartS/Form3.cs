using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace KartS
{
    public partial class Form3 : Form
    {
        DateTime DateOfStart = new DateTime(2022, 11, 24, 6, 0, 0);
        public Form3(string Name, string Dlr)
        {
            
            InitializeComponent();
            label5.Text = Name;
            label6.Text = Dlr;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            label1.Text = $"До начала события осталось {different.Days} дней, {different.Hours} часов, {different.Minutes} минут и {different.Seconds} секунд.";

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Charity charity = new Charity();
            charity.Show();
            this.Hide();
        }
    }
}

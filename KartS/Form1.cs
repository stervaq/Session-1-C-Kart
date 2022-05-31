using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartS
{
    public partial class Form1 : Form
    {
        DateTime DateOfStart = new DateTime(2022, 11, 24, 6, 0, 0);
        public Form1()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            label1.Text = $"До начала события осталось 10 лет, 3 месяца, {different.Days} дней, {different.Hours} часов, {different.Minutes} минут и {different.Seconds} секунд.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Auth = new Auth();
            Auth.Show();
            this.Hide();
        }
    }
}

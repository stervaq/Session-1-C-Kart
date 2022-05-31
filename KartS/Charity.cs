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
    public partial class Charity : Form
    {
        static SqlConnection db = new SqlConnection(@"Data Source=DESKTOP-HR5RWB\VLAD;Initial Catalog=Karting;Integrated Security=True");
        public Charity()
        {
            
            InitializeComponent();
            string query =  "select * from Charity;";
            SqlCommand cmd = new SqlCommand(query,db);
            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Name = reader["Charity_Name"].ToString();
                string Description = reader["Charity_Description"].ToString();
                string Image = reader["Charity_Logo"].ToString();
                label1.Text = Image;
                label2.Text = Name;
                label3.Text = Description;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

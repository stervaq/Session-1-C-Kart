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
    public partial class Auth : Form
    {
        static SqlConnection db = new SqlConnection(@"Data Source=DESKTOP-HR5RWB\VLAD;Initial Catalog=Karting;Integrated Security=True");
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"select * from [User] where [Email] = '{textBox1.Text}' and [Password] = '{textBox2.Text}'";
            SqlDataAdapter cmd = new SqlDataAdapter(query,db);  
            db.Open();
            DataSet data = new DataSet();
            cmd.Fill(data);
            DataTable table = data.Tables[0];
            db.Close();
            if (table.Rows.Count != 0)
            {
                if (table.Rows[0][4].ToString() == "R") 
                {
                    Form frm = new Gon();
                    frm.Show();
                    this.Hide();
                }
            }

        }
    }
}

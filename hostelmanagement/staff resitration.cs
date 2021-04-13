using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostelmanagement
{
    public partial class staff_resitration : Form
    {
        public staff_resitration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text!=""&&textBox5.Text!="")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
                con.Open();
                string QUERY = "INSERT INTO  LOGIN VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+textBox4.Text+"','"+textBox5.Text+"')";
                SqlCommand cmd = new SqlCommand(QUERY, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User has been added succesfull");
            }
            else
            {
                MessageBox.Show("please fill all the field");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void staff_resitration_Load(object sender, EventArgs e)
        {

        }
    }
}

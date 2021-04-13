using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostelmanagement
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            if (txtname.Text != "" && txtemail.Text != "" && txtphone.Text != "" && txtaddress.Text != "")
            {
                string query = "INSERT INTO UNIVERSITY( UNI_NAME, EMAIL,PHONE_NO,ADDRESS,DATE) VALUES('" + txtname.Text + "','" + txtemail.Text + "','" + txtphone.Text + "','" + txtaddress.Text + "','" + dateTimePicker1.Value + "')";
                SqlCommand runquery = new SqlCommand(query, con);
                runquery.ExecuteNonQuery();
                MessageBox.Show("University is added succesfully");
                txtname.Clear();
                txtemail.Clear();
                txtphone.Clear();
                txtaddress.Clear();
            }
            else
            {
                MessageBox.Show("one of the field is empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {


            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }  

          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

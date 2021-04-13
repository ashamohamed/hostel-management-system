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
    public partial class Form7 : Form
    {

        DataTable table = new DataTable("table");
        public Form7()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           
           SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            string query1 = "select * from  university ";
            SqlCommand a=new SqlCommand(query1,con);
            SqlDataAdapter ad  = new SqlDataAdapter(a);
            DataSet ourset = new DataSet();
            ad.Fill(ourset);
            dataGridView1.DataSource = ourset.Tables[0];

          




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch != null)
            {
               
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
                string query1 = "SELECT * FROM UNIVERSITY WHERE UNI_NAME LIKE'" + txtsearch.Text + "%'";
                SqlCommand a = new SqlCommand(query1, con);
                SqlDataAdapter ad = new SqlDataAdapter(a);
                DataSet ourset = new DataSet();
                ad.Fill(ourset);
                dataGridView1.DataSource = ourset.Tables[0];
            }
            else
            {
                // panel1.Visible = false;
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
                con.Open();
                string query1 = "select * from  university ";
                SqlCommand a = new SqlCommand(query1, con);
                SqlDataAdapter ad = new SqlDataAdapter(a);
                DataSet ourset = new DataSet();
                ad.Fill(ourset);
                dataGridView1.DataSource = ourset.Tables[0];

            }

          
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
          /*panel1.Visible = true;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            string query2 = "select * from university";
            SqlCommand a = new SqlCommand(query2, con);
            SqlDataAdapter ad = new SqlDataAdapter(a);
            DataSet ourset = new DataSet();
            ad.Fill(ourset);
         // txtuniname.Text=ourset.Tables[0].Rows[][].ToString;*/
            if (txtsearch != null)
            {
               // panel1.Visible = false;
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
                string query1 = "SELECT * FROM UNIVERSITY WHERE UNI_NAME LIKE'" + txtsearch.Text + "%'";
                SqlCommand a = new SqlCommand(query1, con);
                SqlDataAdapter ad = new SqlDataAdapter(a);
                DataSet ourset = new DataSet();
                ad.Fill(ourset);
                dataGridView1.DataSource = ourset.Tables[0];
            }
            else
            {
                // panel1.Visible = false;
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
                con.Open();
                string query1 = "select * from  university ";
                SqlCommand a = new SqlCommand(query1, con);
                SqlDataAdapter ad = new SqlDataAdapter(a);
                DataSet ourset = new DataSet();
                ad.Fill(ourset);
                dataGridView1.DataSource = ourset.Tables[0];

            }

          

         }
        String UNI_ID;
        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to  close this form";
            string title = "Close window";
            MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, button);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            UNI_ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            String query ="UPDATE UNIVERSITY SET  UNI_NAME='"+textBox1.Text+"', EMAIL='"+textBox3.Text+"',PHONE_NO='"+textBox4.Text+"',ADDRESS='"+textBox2.Text+"' where UNI_ID='"+UNI_ID+"'";
            SqlCommand runquery = new SqlCommand(query,con);
            runquery.ExecuteNonQuery();
            MessageBox.Show("successful");
            this.Close();
            var asha = new Form7();
            asha.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            String query = "DELETE FROM  UNIVERSITY   WHERE  UNIVERSITY.UNI_ID='"+UNI_ID+"'";
            SqlCommand runquery = new SqlCommand(query, con);
            runquery.ExecuteNonQuery();
            MessageBox.Show(" Deletion finished successfully");
            this.Close();
            var asha = new Form7();
            asha.Show();
        }
                
    }
}

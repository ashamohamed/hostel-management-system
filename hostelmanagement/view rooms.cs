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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            string query = "SELECT * FROM ROOM   WHERE   NOT EXISTS (SELECT * FROM stu_room where ROOM.ROOM_ID=stu_room.room_id) ";
            SqlCommand ad = new SqlCommand(query, con);
            SqlDataAdapter ade = new SqlDataAdapter(ad);
            DataSet ourset = new DataSet();
            ade.Fill(ourset);
            dataGridView2.DataSource = ourset.Tables[0];


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

             SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            string query = "delete from room  WHERE ROOM_ID='" + ROOM_ID + "'";
            SqlCommand runq1 = new SqlCommand(query, con);
            runq1.ExecuteNonQuery();

            {
                MessageBox.Show("Room deletion  done Successifully");
                this.Hide();


                Form5 ash = new Form5();
                ash.Show();
                }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        String ROOM_ID;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            ROOM_ID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = ROOM_ID;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            string query = "UPDATE  ROOM SET room_type='" + textBox1.Text + "', price='" + textBox3.Text + "' WHERE ROOM_ID='" + ROOM_ID + "'";
            SqlCommand runq1 = new SqlCommand(query, con);
            runq1.ExecuteNonQuery();

            {
                MessageBox.Show("Room UPDATION  done Successifully");
                this.Hide();


                Form5 ash = new Form5();
                ash.Show();
            }
        }
        private void button1_Click(object  sender, EventArgs e)
        {
            string message = "Are you sure you want to  close this form";
            string title = "Close window";
            MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
            DialogResult result =  MessageBox.Show(message, title, button);
            if(result==DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}

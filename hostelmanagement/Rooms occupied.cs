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
    public partial class Rooms_not_occupied : Form
    {
        public Rooms_not_occupied()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rooms_not_occupied_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            string query = "SELECT  STUDENT.STU_ID, ROOM.ROOM_ID, PRICE,ROOM_TYPE, F_NAME  AS STUDENT_NAME , UNI_NAME FROM STUDENT,ROOM,stu_room, stu_uni, UNIVERSITY  WHERE STUDENT.STU_ID=stu_uni.stu_id and STUDENT.STU_ID=stu_room.stu_id and ROOM.ROOM_ID=stu_room.room_id and UNIVERSITY.UNI_ID=stu_uni.uni_id";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ourset = new DataSet();
            ad.Fill(ourset);
            dataGridView1.DataSource = ourset.Tables[0];
        }
        string stu_room_id;
        string ROOM_ID;
        string STU_ID;

        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            string query = "UPDATE stu_room SET room_id ='" + txtroomno.Text + "',stu_id ='" + txtSTUID.Text + "' where stu_room_id = '" + stu_room_id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            string query1 = "UPDATE ROOM SET room_type = '" + TXTTYPE.Text + "',price = '" + TXTPRICE.Text + "' where ROOM_ID ='" + ROOM_ID + "'";
            SqlCommand CMD1 = new SqlCommand(query1, con);
            CMD1.ExecuteNonQuery();
            string query2 = "UPDATE STUDENT SET F_NAME = '" + TXTNAME.Text + "' WHERE STU_ID = '" + STU_ID + "'";
            SqlCommand CMD2 = new SqlCommand(query2, con);
            CMD2.ExecuteNonQuery();
            {
                MessageBox.Show("Updation done succesfully");
                this.Hide();

                Rooms_not_occupied de = new Rooms_not_occupied();
                this.Show();

             }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();

            stu_room_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtroomno.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtSTUID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            TXTTYPE.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            TXTNAME.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            TXTPRICE.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void buttonCANCEL_Click_1(object sender, EventArgs e)
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

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            string query = "delete from stu_room  WHERE stu_room.room_id='" + txtroomno.Text+ "'";
            SqlCommand runq1 = new SqlCommand(query, con);
            runq1.ExecuteNonQuery();

            {
                MessageBox.Show("deletion  done Successifully");
                this.Hide();


                Rooms_not_occupied sa = new Rooms_not_occupied();
                sa.Show();
            }
        }
    }
}
    


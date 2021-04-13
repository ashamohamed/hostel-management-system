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
    public partial class view_studentscs : Form
    {
        public view_studentscs()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

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

        private void view_studentscs_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
string query =  "SELECT  STUDENT.STU_ID, F_NAME,SECOND_NAME, L_NAME, STUDENT.ADDRESS, STUDENT.PHONE_NO, PROGRAM ,GENDER , DATE_OF_REGISTRATION ,UNI_NAME ,ROOM.ROOM_ID , PRICE FROM STUDENT,stu_room,stu_uni,UNIVERSITY,ROOM WHERE STUDENT.STU_ID=stu_uni.stu_id and UNIVERSITY.UNI_ID=stu_uni.uni_id and STUDENT.STU_ID=stu_room.stu_id and ROOM.ROOM_ID=stu_room.room_id" ;
            SqlCommand ade = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(ade);
            DataSet ourset = new DataSet();
            ad.Fill(ourset);
            dataGridView1.DataSource = ourset.Tables[0];
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
          /* if (txtsearch != null)
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
                string query1 = "SELECT   *  FROM STUDENT WHERE F_NAME  LIKE'" + txtsearch.Text + "%'";
                SqlCommand a = new SqlCommand(query1, con);
                SqlDataAdapter ad = new SqlDataAdapter(a);
                DataSet ourset = new DataSet();
                ad.Fill(ourset);
                
            }
            else
            {
                // panel1.Visible = false;
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
                con.Open();
                string query1 = "select * from  STUDENT ";
                SqlCommand a = new SqlCommand(query1, con);
                SqlDataAdapter ad = new SqlDataAdapter(a);
                DataSet ourset = new DataSet();
                ad.Fill(ourset);
                dataGridView1.DataSource = ourset.Tables[0];

            }*/
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
           /* if (txtsearch != null)
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
                string query1 = "SELECT * FROM STUDENT  WHERE F_NAME  LIKE'" + txtsearch.Text + "%'";
                SqlCommand a = new SqlCommand(query1, con);
                SqlDataAdapter ad = new SqlDataAdapter(a);
                DataSet ourset = new DataSet();
                ad.Fill(ourset);
                dataGridView1.DataSource = ourset.Tables[0];
                STU_ID = (dataGridView1.SelectedRows[0].Cells[0].Value).ToString();
                txtfname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtlname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtadd.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtphone.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtsname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtprog.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            
            }
            else
            {
                // panel1.Visible = false;
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
                con.Open();
                string query1 = "select * from  STUDENT  ";
                SqlCommand a = new SqlCommand(query1, con);
                SqlDataAdapter ad = new SqlDataAdapter(a);
                DataSet ourset = new DataSet();
                ad.Fill(ourset);
                dataGridView1.DataSource = ourset.Tables[0];

            }*/
        }
       string  STU_ID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            STU_ID=(dataGridView1.SelectedRows[0].Cells[0].Value).ToString();
            txtfname.Text=dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtlname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtadd.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtphone.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtsname.Text= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtprog.Text=dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            
            
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            string query = "UPDATE STUDENT SET F_NAME='" + txtfname.Text + "',L_NAME='" + txtlname.Text + "',ADDRESS='" + txtadd.Text + "',PHONE_NO='" + txtphone.Text + "',PROGRAM='" + txtprog.Text + "',SECOND_NAME='"+txtsname.Text+"' WHERE STU_ID ='"+STU_ID+"'";
            SqlCommand ade = new SqlCommand(query, con);
            ade.ExecuteNonQuery();
            {
                MessageBox.Show("student updation is done succesfully", "congratulation", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();

                view_studentscs stu = new view_studentscs();
                stu.Show();
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            string query = "DELETE FROM STUDENT  WHERE STUDENT.STU_ID='"+STU_ID+"'";
            SqlCommand ade = new SqlCommand(query, con);
            ade.ExecuteNonQuery();
            {
              MessageBox.Show("deletion in student has been done succesfully", "Congratulation");

              this.Hide();
              view_studentscs sa = new view_studentscs();
              sa.Show();
            }
        }
    }
}

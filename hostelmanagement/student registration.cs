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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        private void Form3_Load(object sender, EventArgs e)
        
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
                conn.Open();

                String query1 = "SELECT room_type  FROM ROOM WHERE ROOM_ID NOT IN (SELECT room_id FROM stu_room)";
                SqlCommand runq1 = new SqlCommand(query1, conn);
                SqlDataReader r = runq1.ExecuteReader();
                while(r.Read())
                {
                    comboroom.Items.Add(r[0].ToString());
                }

                r.Close();
                String query2 = "SELECT * FROM UNIVERSITY";
                SqlCommand runq2 = new SqlCommand(query2, conn);
                SqlDataReader r2 = runq2.ExecuteReader();
                while (r2.Read())
                {
                    Combouni.Items.Add(r2[1]);
                }
            }


        private void button1_Click(object sender, EventArgs e)
        {

            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            // String gender = combogender.SelectedItem.ToString();

           if (txtfname.Text != "" && txtlname.Text != "" && txtlname.Text != "" && txtphone.Text != "" && txtprog.Text != "" && txtadd.Text != "" && (string)combogender.SelectedItem!= "")
            {
               
                String query = "INSERT INTO STUDENT VALUES ('" + txtfname.Text + "','" + txtlname.Text + "','" + txtadd.Text + " ','" + txtphone.Text + "','" + txtprog.Text + "','" + txtlsecname.Text + "','" + this.dateTimePicker1.Value + "','" + combogender.SelectedItem + "')";
                String query1 = "SELECT STU_ID FROM STUDENT WHERE F_NAME='" + txtfname.Text + "' AND SECOND_NAME='" + txtlsecname.Text + "'AND L_NAME='" + txtlname.Text + "'";
                String query2 = " SELECT ROOM.ROOM_ID  FROM ROOM   WHERE   NOT EXISTS (SELECT * FROM stu_room where ROOM.ROOM_ID=stu_room.room_id)  AND room_type='" + comboroom.SelectedItem + "'";
                //String query2 = "SELECT ROOM_ID FROM ROOM WHERE ROOM.ROOM_ID='" + comboroom.SelectedItem + "'";
                String query3 = "SELECT UNI_ID FROM UNIVERSITY WHERE UNI_NAME ='"+Combouni.SelectedItem+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlCommand cmd3 = new SqlCommand(query3,con);
               
                cmd.ExecuteNonQuery();
                SqlDataAdapter ad1 = new SqlDataAdapter(cmd1);
                DataTable t1 = new DataTable();
                ad1.Fill(t1);
                DataRow r1 = t1.Rows[0];
                string STU_ID  = r1["STU_ID"].ToString();

                SqlDataAdapter ad2 = new SqlDataAdapter(cmd2);
                DataTable t2 = new DataTable();
                ad2.Fill(t2);
                DataRow r2 = t2.Rows[0];
                string ROOM_ID = r2["ROOM_ID"].ToString();
                SqlDataAdapter ad3 = new SqlDataAdapter(cmd3);
                DataTable t3 = new DataTable();
                ad3.Fill(t3);
                DataRow r3 = t3.Rows[0];
                string UNI_NAME =r3["UNI_ID"].ToString();
                string com = "INSERT INTO stu_room VALUES ('" + STU_ID+ "','" + ROOM_ID + "')";
                SqlCommand a = new SqlCommand(com, con);
                a.ExecuteNonQuery();
                string com2 = "INSERT INTO stu_uni VALUES ('" + STU_ID + "','" + UNI_NAME + "')";
                SqlCommand b = new SqlCommand(com2, con);
                b.ExecuteNonQuery();


               
                con.Close();

                MessageBox.Show("Registration has completed successful");
                txtfname.Clear();
                txtlname.Clear();
                txtphone.Clear();
                txtphone.Clear();
                txtlsecname.Clear();
                txtprog.Clear();
                txtadd.Clear();
                dateTimePicker1.ResetText();
                combogender.Text = "";
                comboroom.Text = "";
                Combouni.Text = "";
            }

            else
            {
               MessageBox.Show("You must fill the neccesary field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Combouni_Click(object sender, EventArgs e)
        {

            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mes = "Do you want to exit from this form";
            string title = "close window";
            DialogResult res = MessageBox.Show(mes, title, MessageBoxButtons.YesNoCancel);
            if(res==DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void comboroom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

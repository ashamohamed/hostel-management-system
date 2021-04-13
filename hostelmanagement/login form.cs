using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hostelmanagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 han = new Form3();
            han.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            SqlCommand cmd;
            SqlDataReader dr;
            cmd = new SqlCommand("SELECT * FROM LOGIN WHERE USERNAME ='" + textBox1.Text + "' AND PASSWORD = '" + textBox2.Text + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                if (dr["ROLE"].ToString() == "ADMIN" && dr["STATUS"].ToString() == "ACTIVE")
                {
                    MessageBox.Show("login successfull", "congratulate", MessageBoxButtons.OK, MessageBoxIcon.None);


                    MDIParent1 P = new MDIParent1();
                    P.Show();


                }
                else if (dr["ROLE"].ToString() == "STAFF" && dr["STATUS"].ToString() == "ACTIVE")
                {
                    MessageBox.Show("login successfull", "congratulate", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Form2 N = new Form2();
                    N.Show();

                }
                else
                {
                    MessageBox.Show("Please enter the correct username and password");
                }
                MessageBox.Show("Welcome to accomodation system");
            }

            else if (string.IsNullOrEmpty(textBox2.Text.Trim()))
            {

                string n = "is empty";
                string title = "error";
                MessageBoxButtons but = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(n, title, but, icon);

                // errorProvider1.SetError(textBox2, "password is empty");
            }
            else if (!Regex.IsMatch(textBox2.Text, "[A-Za-z0-9]{8,16}"))
            {
                errorProvider1.SetError(textBox2, "invalid password length");

            }
            else if (!Regex.IsMatch(textBox2.Text, "[A-Za-z0-9]"))
            {
                errorProvider1.SetError(textBox2, "invalid password");
            }
            else if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {

                string a = " one field is empty";
                string t = "error";
                MessageBoxButtons butt = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;
                MessageBox.Show(a, t, butt, ico);
            }
            else
            {

                MessageBox.Show("Please fill the  correct username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            textBox1.Clear();
            textBox2.Clear();
           
        }


        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

           /* if (string.IsNullOrEmpty(textBox2.Text.Trim()))
            {

                string n = "is empty";
                string title = "error";
                MessageBoxButtons but = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(n, title, but, icon);

                // errorProvider1.SetError(textBox2, "password is empty");
            }
            else if (!Regex.IsMatch(textBox2.Text, "[A-Za-z0-9]{8,16}"))
            {
                errorProvider1.SetError(textBox2, "invalid password length");

            }
            else if (!Regex.IsMatch(textBox2.Text, "[A-Za-z0-9]"))
            {
                errorProvider1.SetError(textBox2, "invalid password");
            }
            else
            {
                errorProvider1.SetError(textBox2, null);
            }*/
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {

                string a = "is empty";
                string t = "error";
                MessageBoxButtons butt = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;
                MessageBox.Show(a, t, butt, ico);
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string mes = "Are you sure you want to exit from this application";
            string title = "Close Window";
           DialogResult res= MessageBox.Show(mes, title, MessageBoxButtons.YesNoCancel);
            if(res==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

    }
}
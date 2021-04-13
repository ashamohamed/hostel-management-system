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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            if(txtroomtype.Text != "" && txtroomprice.Text != "")

            {
                string query = "INSERT INTO ROOM VALUES('" + txtroomtype.Text + "','" + txtroomprice.Text + "')";
                SqlCommand runq1 = new SqlCommand(query, con);
                runq1.ExecuteNonQuery();

                {
                    MessageBox.Show("Room Registration  done Successifully");
                    this.Hide();
                    this.Show();
                   
                    txtroomtype.Clear();
                    txtroomprice.Clear();
                }
            }
            else
            {
                MessageBox.Show("one of the field is empty","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            string mes = "Are you sure you want to close this form ?";
            string tit = "Close window";
            MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
            DialogResult res = MessageBox.Show(mes, tit, button);
            if(res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
          

        }

        private void txtrookmnuber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
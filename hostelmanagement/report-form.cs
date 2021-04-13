using DGVPrinterHelper;
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
    public partial class report_form : Form
    {
        public report_form()
        {
            InitializeComponent();
        }

        private void report_form_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5QHHH7M;Initial Catalog=HOSTEL;Integrated Security=True");
            con.Open();
            string query = "SELECT  STUDENT.STU_ID, CONCAT(F_NAME,SECOND_NAME, L_NAME) AS STUDENT_NAME, STUDENT.PHONE_NO,PROGRAM,STUDENT.ADDRESS,GENDER , DATE_OF_REGISTRATION ,UNI_NAME ,ROOM.ROOM_ID , PRICE FROM STUDENT,stu_room,stu_uni,UNIVERSITY,ROOM WHERE STUDENT.STU_ID=stu_uni.stu_id and UNIVERSITY.UNI_ID=stu_uni.uni_id and STUDENT.STU_ID=stu_room.stu_id and ROOM.ROOM_ID=stu_room.room_id";
            SqlCommand que=new SqlCommand(query,con);
            SqlDataAdapter ade = new SqlDataAdapter(que);
            DataSet ourset = new DataSet();
            ade.Fill(ourset);
            dataGridView1.DataSource = ourset.Tables[0];

 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer  = new DGVPrinter();
            printer.Title = "ROOMS OCCUPIED BY STUDENTS";
            printer.SubTitle = string.Format("Date :(0)", DateTime.Now.Date.ToString("mon/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "ASHA && HAMISA && MABULA";
            printer.FooterSpacing = 20;
            printer.PrintDataGridView(dataGridView1);


        }
    }
}

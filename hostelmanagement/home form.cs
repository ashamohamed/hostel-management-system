using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostelmanagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 mm = new Form1();
            mm.Show();
        }

        private void rOOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 be = new Form2();
            be.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void aDDUNIVERSITYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Form6();
            a.Show();

        }

        private void vIEWUNIVERSITYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var we = new Form7();
            we.Show();
        }

        private void rEGISTRATIONFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 h = new Form3();
            h.Show();
        }

        private void sTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDROOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 asha = new Form4();
            asha.Show();
        }

        private void vIEWROOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rOOMSNOTOCCUPIEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 aa = new Form5();
            aa.Show();
        }

        private void rOOMOCCUPIEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rooms_not_occupied da = new Rooms_not_occupied();
            da.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void vIEWSTUDENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_studentscs v = new view_studentscs();
            v.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

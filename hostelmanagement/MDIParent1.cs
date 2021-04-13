using DGVPrinterHelper;
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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
           
        }

        private void OpenFile(object sender, EventArgs e)
        {
            report_form de = new report_form();
            de.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_studentscs v = new view_studentscs();
            v.Show();
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rooms_not_occupied r = new Rooms_not_occupied();
            r.Show();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomsNotOccupiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 q = new Form5();
            q.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff_resitration c = new staff_resitration();
            c.Show();
        }

        private void addRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 b = new Form4();
            b.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

   
        }
    }


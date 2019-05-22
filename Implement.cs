using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_Moving_P_If_State
{
    public partial class Implement : Form
    {
        public Implement()
        {
            InitializeComponent();
        }

        private void stationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Station_Groub.Visible = true;
        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Train_Groub.Visible = true;
        }

        private void printPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Performance_printDialog.ShowDialog();
        }

        private void stationScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StationSchedule_PrintPreviewDialog.Document = StationSchedule_PrintDocument;
            StationSchedule_PrintPreviewDialog.ShowDialog();
        }

        private void simulateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Display d = new Display();
            d.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        
    }
    

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.UI;

namespace FairManagementApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeEntryUI zoneTypeEntryUi =new ZoneTypeEntryUI();
            zoneTypeEntryUi.Show();
        }

        private void entryVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryUI visitorEntryUi =new VisitorEntryUI();

            visitorEntryUi.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zoneSpecificVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorDetailsUI visitorDetailsUi = new VisitorDetailsUI();
            visitorDetailsUi.Show();
        }

        private void zoneWiseVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorNumberUI visitorNumberUi = new VisitorNumberUI();
            visitorNumberUi.Show();

        }
    }
}

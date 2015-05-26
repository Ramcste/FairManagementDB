using FairManagementApp.BLL;
using FairManagementApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FairManagementApp.UI
{
    public partial class VisitorDetailsUI : Form
    {
        public VisitorDetailsUI()
        {
            InitializeComponent();

            LoadComboBoxInfo();
        }

        ZoneManager zoneManager = new ZoneManager();
        public void LoadComboBoxInfo()
        {

            selectZoneComboBox.DataSource = zoneManager.GetAllZones();
            selectZoneComboBox.DisplayMember ="TypeName";
            selectZoneComboBox.ValueMember = "Id";
        
        }

        private void showButton_Click(object sender, EventArgs e)
        {

        }

    }
}

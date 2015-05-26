using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.BLL;
using FairManagementApp.Model;

namespace FairManagementApp.UI
{
    public partial class ZoneTypeEntryUI : Form
    {
        public ZoneTypeEntryUI()
        {
            InitializeComponent();
        }

        ZoneManager zoneManager=new ZoneManager();
        private void saveZoneTypeButton_Click(object sender, EventArgs e)
        {

            Zone zone=new Zone();
            zone.TypeName = zoneTypeNameEntryTextBox.Text;

           MessageBox.Show(zoneManager.Save(zone));
           GetClearTextBoxes();
           GetAllZoneList();

        }

        private void GetClearTextBoxes()
        {
            zoneTypeNameEntryTextBox.Text = "";
        }

        public void GetAllZoneList()
        {
            int serial = 1;
            zoneTypeListView.Items.Clear();
            foreach (var zone in zoneManager.GetAllZones())

            {
                ListViewItem item=new ListViewItem();
                item.Tag = (Zone) zone;
                item.Text = serial.ToString(); 
                item.SubItems.Add(zone.TypeName);

                zoneTypeListView.Items.Add(item);
                serial++;
            }

        }

        private void ZoneTypeEntryUI_Load(object sender, EventArgs e)
        {
            GetAllZoneList();

        }
    }
}

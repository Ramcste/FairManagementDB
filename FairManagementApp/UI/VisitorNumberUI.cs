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

namespace FairManagementApp.UI
{
    public partial class VisitorNumberUI : Form
    {
        ZoneManager zoneManager=new ZoneManager();
        public VisitorNumberUI()
        {
            InitializeComponent();

            FillBox();
           
        }

        private void FillBox()
        {
           totalTextBox.Text = zoneManager.GetTotalNoOfVisitors().ToString();

            foreach (var zones in zoneManager.GetAllZones())
            {
                ListViewItem item=new ListViewItem();

                item.Text = zones.TypeName;

                item.SubItems.Add(zones.NoOfVisitors.ToString());

                visitorNumberListView.Items.Add(item);


            }
        }
    }
}

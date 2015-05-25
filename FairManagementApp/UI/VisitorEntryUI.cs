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
    public partial class VisitorEntryUI : Form
    {
        public VisitorEntryUI()
        {
            InitializeComponent();
        }

        VisitorManager visitorManager=new VisitorManager();

        private void Visitor_Entry_Load(object sender, EventArgs e)
        {
            
            GetZones();
        }


        public void GetZones()
        {


            int x=200, y=30;

            foreach (Zone zone in visitorManager.GetAllZones())
            {
                CheckBox checkBox =new CheckBox();
               
                checkBox.Text = zone.TypeName;
                checkBox.Name = string.Format(zone.TypeName+"CheckBox");
                checkBox.Location=new Point(x,y);
                checkBox.Width = 200;
                checkBox.Checked = true;
                showZoneGroupBox.Controls.Add(checkBox);
                y += 30;

            }

        }

        private void saveVisitorButton_Click(object sender, EventArgs e)
        {

        }

        

      
    }
}

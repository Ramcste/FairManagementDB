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

            List<Zone> zones = visitorManager.GetAllZones();
            int x=200, y=30;

            foreach (Zone zone in zones)
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


        public void GetAllCheckBoxes()
        {

            List<string> checkBoxList = new List<string>();
           
            foreach (Control c in showZoneGroupBox.Controls)
            {

                CheckBox cb = c as CheckBox;
                if (cb!=null && cb.Checked)
                {
                    checkBoxList.Add(cb.Text);
                }

            }
            visitorManager.GetCheckBox(checkBoxList);
           


           
        }

        private void saveVisitorButton_Click(object sender, EventArgs e)
        {
            GetAllCheckBoxes();
            Visitor visitor = new Visitor();

            visitor.Name = nameTextBox.Text;
            visitor.Email = emailTextBox.Text;
            visitor.ContactNo = contactNoTextBox.Text;

            MessageBox.Show(visitorManager.Save(visitor));
            GetTextBoxesClear();
         

        }

        private void GetTextBoxesClear()
        {
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            contactNoTextBox.Text = "";

        }

        

      
    }
}

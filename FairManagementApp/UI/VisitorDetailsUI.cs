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

            
        }

        ZoneManager zoneManager = new ZoneManager();

        VisitorManager visitorManager=new VisitorManager();
        public void LoadComboBoxInfo()
        {

            selectZoneComboBox.DataSource = zoneManager.GetAllZones();
            selectZoneComboBox.DisplayMember ="TypeName";
            selectZoneComboBox.ValueMember = "Id";
        
        }


        public void LoadVisitorListByZoneName()
        {

            int count = 0;
            string typeName = selectZoneComboBox.Text;
           loadVisitorListView.Items.Clear();

            foreach (var list in visitorManager.GetAllVisitorListByZoneTypeName(typeName)) 
            {
                ListViewItem item=new ListViewItem();
                item.Text = list.Name;
                item.SubItems.Add(list.Email);
                item.SubItems.Add(list.ContactNo);

                loadVisitorListView.Items.Add(item);
                count++;
            }

            totalTextBox.Text = count.ToString();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            LoadVisitorListByZoneName();
        }


        private void exportToExcelButton_Click(object sender, EventArgs e)
        {
           // StringBuilder sb = new StringBuilder();

            string zonename =selectZoneComboBox.Text;
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook wb =
                xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet) xla.ActiveSheet;

            int i = 1;

            int j = 1;
            ws.Cells[i, j+1] = "Digital Innovation Fair 2015";
            i++;
            ws.Cells[i, j+1] ="List Of People Visited "+zonename;
            i++;
            ws.Cells[i, j] = "Name";
            ws.Cells[i, j + 1] = "Email";
            ws.Cells[i, j + 2] = "Contact No.";
             
            i++;

             

            foreach (ListViewItem comp in loadVisitorListView.Items)
            {

                ws.Cells[i, j] = comp.Text.ToString();

                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                {

                    ws.Cells[i, j] = drv.Text.ToString();

                    j++;

                }

                j = 1;

                i++;
            }
        }

        private void VisitorDetailsUI_Load(object sender, EventArgs e)
        {
            LoadComboBoxInfo();
            LoadVisitorListByZoneName();
        }


       
        }

    }


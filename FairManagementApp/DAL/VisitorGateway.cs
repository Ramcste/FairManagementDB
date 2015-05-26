using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.Model;
using FairManagementApp.UI;

namespace FairManagementApp.BLL
{
    class VisitorGateway
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["FairConnectionString"].ConnectionString;

        ZoneGateway zoneGateway=new ZoneGateway();
         private  List<int> selectedZoneId = new List<int>();

        public void GetCheckBoxes(List<string> checkBoxList)
        {
            foreach (string checkboxname in checkBoxList)
            {
                selectedZoneId.Add(GetZoneId(checkboxname));
                
            } 
        }
  

        public  int Save(Visitor visitor)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            
            string query = string.Format("INSERT INTO tbl_Visitor OUTPUT INSERTED.v_Id VALUES('{0}','{1}','{2}')",visitor.Name,visitor.Email,visitor.ContactNo);

            
            
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

           // int rowsAffected = command.ExecuteNonQuery();

            int vid = (int) command.ExecuteScalar();
           
            connection.Close();
           // MessageBox.Show(vid.ToString());

            connection.Open();
            foreach (int id in selectedZoneId)
            {
               

                string query1 = string.Format("INSERT INTO tbl_Visit VALUES('{0}','{1}')", vid, id);

                SqlCommand command1 = new SqlCommand(query1, connection);
                command1.ExecuteNonQuery();

            }
            connection.Close();
            return vid;

        }

        public bool IsThisEmailExists(string email)
        {
            bool isEmailExists = false;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT v_Email FROM tbl_Visitor WHERE v_Email='"+email+"'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                isEmailExists = true;
                break;
            }

            reader.Close();
            connection.Close();
            return isEmailExists;


        
        }


        public int GetZoneId(string zoneName)
        {
            int zoneId = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT z_Id FROM tbl_Zone WHERE z_TypeName='" + zoneName + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                zoneId += int.Parse(reader["z_Id"].ToString());

            }


            reader.Close();
            connection.Close();
            return zoneId;


        }
        
    }
}

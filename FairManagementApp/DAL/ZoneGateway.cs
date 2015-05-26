using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{
    class ZoneGateway
    {
        public string connectionString =  ConfigurationManager.ConnectionStrings["FairConnectionString"].ConnectionString;

        public int Save(Zone zone)
        {
            zone.NoOfVisitors = 1;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = string.Format("INSERT INTO tbl_Zone(z_TypeName) VALUES('{0}')", zone.TypeName);

            SqlCommand command=new SqlCommand(query,connection);

            connection.Open();

            int rowsAffected=command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;


        }

        public List<Zone> GetZones()
        {
            List<Zone> ZonesList=new List<Zone>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_Zone";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
               Zone zone=new Zone();
                zone.Id = int.Parse(reader["z_Id"].ToString());
                zone.TypeName = reader["z_TypeName"].ToString();
               // zone.NoOfVisitors = int.Parse(reader["z_NoOfVisitors"].ToString());
            
                ZonesList.Add(zone);

            }
            
                
            reader.Close();
            connection.Close();
            return ZonesList;

        }


       

        //public List<Visitor>  GetVisitor(string zonename)
        //{
        //    List<Visitor> visitorList = new List<Visitor>();

        //    SqlConnection connection = new SqlConnection(connectionString);
        //    string query = "SELECT v_Name,v_Email,v_ContactNo FROM tbl_Zone WHERE ";

        //    SqlCommand command = new SqlCommand(query, connection);

        //    connection.Open();

        //    SqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        Visitor visitor = new Visitor();
        //        visitor.Name = reader["v_Name"].ToString();
        //        visitor.Email = reader["v_Email"].ToString();
        //        visitor.ContactNo = reader["v_ContactNo"].ToString();

        //        visitorList.Add(visitor);

        //    }


        //    reader.Close();
        //    connection.Close();
        //    return visitorList;


        //}


    

    }
}

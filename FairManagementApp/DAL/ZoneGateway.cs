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
                zone.NoOfVisitors = int.Parse(reader["z_NoOfVisitors"].ToString());
               
                ZonesList.Add(zone);
               
            }
            
                
            reader.Close();
            connection.Close();
            return ZonesList;

        }

        public int GetTotalVisitors()
        {
            int totalvisitors = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT SUM(z_NoOfVisitors) FROM tbl_Zone";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
              
                totalvisitors = int.Parse(reader[0].ToString());

            }


            reader.Close();
            connection.Close();
            return totalvisitors;


        }


        public int GetCountZoneType()
        {
            int type = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT Count(z_Id) FROM tbl_Zone";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                type += int.Parse(reader[0].ToString());

            }


            reader.Close();
            connection.Close();
            return type;


        }


        public bool IsThisZoneExists(string name)
        {
            bool isZoneExists = false;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT z_TypeName FROM tbl_Zone WHERE z_TypeName='" + name + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                isZoneExists = true;
                break;
            }

            reader.Close();
            connection.Close();
            return isZoneExists;



        }

    }
}

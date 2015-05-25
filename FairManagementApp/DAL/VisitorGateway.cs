using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{
    class VisitorGateway
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["FairConnectionString"].ConnectionString;

        private int Save(Visitor visitor)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            
            string query = string.Format("INSERT INTO tbl_Visitor VALUES('{0}','{1}','{2}')",visitor.Name,visitor.Email,visitor.ContactNo);

            string query1 = "UPDATE SET";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;

            


        }
    }
}

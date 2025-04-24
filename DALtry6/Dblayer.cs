using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DALtry6
{
    public class DBLayer

    {
        public void AddUsername(string username)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnAir"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [User] (Username) VALUES (@username)", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetUserNames()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnAir"].ConnectionString;
            List<string> userNames = new List<string>();
            //SqlParameter param;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Username FROM [User]", conn);
                cmd.CommandType = CommandType.Text;

                //param = new SqlParameter("@year", SqlDbType.Int);
                //param.Value = year;
                //cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userNames.Add((string)reader[0]);
                }
                reader.Close();
                conn.Close();
            }
            return userNames;
        }
    }

}
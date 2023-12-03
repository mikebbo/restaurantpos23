using RestaurantPOS.Model;
using RestaurantPOS.PosRepo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS.Controller
{
    public class UserController
    {
        public bool validateUser(User user)
        {
            try
            {
                int count;
                //create connection
                var querryString = "select username,passwword where usernname = @Username AND password=@Password ";
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["quickRestoPos"].ConnectionString))
                {
                    connection.Open();
                    //Create SqlCommand with the connection and query
                    var sqlCommand = new SqlCommand(querryString, connection);

                    // Add parameters
                    sqlCommand.Parameters.AddWithValue("@Username", user.Username);
                    sqlCommand.Parameters.AddWithValue("@Password", user.Username);
                    
                    count = (int)sqlCommand.ExecuteScalar();
                            
                   return count > 0;
                }

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


                return false;

            }
        }
    }
}

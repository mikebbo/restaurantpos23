using RestaurantPOS.Model;
using RestaurantPOS.PosRepo;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace RestaurantPOS.PosRepo
{
    internal class UserRepo : IUserRepo
    {


        private User user;
        public bool isValidUser(User user)
        {
            //Create a connection to the database
            using (SqlConnection connection = new SqlConnection(Properties.settings.default.connectioString))
            {
                //Define a T-SQL query string that has parameter for username and password
                const string sql = "select COUNT(*)  from User where username=@username and  password=@password";
                //Create a SqlCommand object, we can use a stored procedure
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    //Define the @username parameter and it's value
                    sqlCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.String));
                    sqlCommand.Parameters["@username"].Value = user.UserName;

                    //Define the @password parameter and it's value
                    sqlCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.String));
                    sqlCommand.Parameters["@password"].Value = user.PassWord;

                    try
                    {
                        //Open the connection
                        connection.Open();
                        //Run the command to execute the query
                        int count = (int)(sqlCommand.ExecuteScalar());


                        return count > 0;

                    }
                    catch (System.Exception ex)
                    {

                        MessageBox.Show("There was an error", ex.Message);
                    }
                    finally
                    {
                        //Close connection
                        connection.Close();
                    }




                }


            }
            return true;
        }
        public bool isValidUser(string useraname, string password)
        {
            throw new NotImplementedException();
        }
    }
    }
}

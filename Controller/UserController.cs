using RestaurantPOS.Model;
using RestaurantPOS.PosRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS.Controller
{
    internal class UserController
    {
        private string connectioString = " "Server=(localhost)\\arpin2015acer;Database=movies;Trusted_Connection=True;MultipleActiveResultSets=true",";";
        private readonly UserRepo repo;
        private readonly User user;



        public void validateUser(string username, string password)
        {
            user.UserName = username;
            user.PassWord = password;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS.Model
{
    internal class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public Role UserRole { get; set; }

    }
    public enum Role
    {
        admin,
        user,
        manager

    }
}

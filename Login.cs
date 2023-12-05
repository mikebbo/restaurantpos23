using RestaurantPOS.Controller;
using RestaurantPOS.PosUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantPOS.Model;
using RestaurantPOS.PosRepo;

namespace RestaurantPOS
{
    public partial class Login : Form
    {
        private readonly UserController _userRepo;
        //private readonly User _user;

        public Login()
        {
            InitializeComponent();
             _userRepo =  new UserController();
            
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            if (TxtUserName.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Please fill the form");
                TxtUserName.Text = "";
                TxtPassword.Text = "";

                //user.validateUser(TxtUserName.Text, TxtPassword.Text);       


            }
            username =TxtUserName.Text;
            password =TxtPassword.Text;
          //  _user.Username = username;
            //_user.Password = password;
            User user = new User
            {
                Username = username,
                Password = password
            };
            MessageBox.Show("Username is:"+user.Username+": password is:"+user.Password);
            if (_userRepo.validateUser(user))
            {
                MessageBox.Show("Login successful");
            }
            else
            {
                MessageBox.Show("There was an eror, please check your login info");
            }
        }

    

        private void BtnCancel_Click(object sender, EventArgs e)
        { 
            
            PosMain posMain = new PosMain();
            posMain.Show();
            //this.Close();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            
        }
    }
}

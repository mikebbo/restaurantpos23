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

namespace RestaurantPOS
{
    public partial class Login : Form
    {
        private readonly UserController user;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Please fill the form");
                TxtUserName.Text = "";
                TxtPassword.Text = "";
                user.validateUser(TxtUserName.Text, TxtPassword.Text);

                


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

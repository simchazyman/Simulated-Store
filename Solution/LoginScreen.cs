using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProject
{
    public partial class LoginScreen : Form
    {


        String[] displayText = {"Fill out both fields", "Username not recognized", "Wrong password"};
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            // Check if there is an empty field.
            if (UsernameTxt.Text == "" ||  PasswordTxt.Text == "")
            {
                messageLbl.Text = displayText[0];
                return;
            }
               
            // Check what was entered.
            using (var db = new DataClasses1DataContext())
            {

                var userLoginInfo = db.Users;

                var user = userLoginInfo.FirstOrDefault(un => un.Username.ToLower() == UsernameTxt.Text);

                // Check the username.
                if (user == null) {
                    messageLbl.Text = displayText[1];
                    return;
                }


                // Check the password.
                if (user.Password != PasswordTxt.Text)
                {
                    messageLbl.Text = displayText[2];
                    return;
                }


                // If this code is being run, then the user has entered the right info for one of the accounts.
                // The user info is in the var variable called user.

                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();

         

            }
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

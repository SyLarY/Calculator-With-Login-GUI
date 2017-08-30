using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculator_With_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0; //counter of times of attemption 
        bool login = false;
        string username;
        string password;

        private void getAccountInfo()
        {
            StreamReader reader = new StreamReader("info.txt"); //read from info.txt for correct answer of username and password
            username = reader.ReadLine();
            password = reader.ReadLine();
            if (textBoxUsername.Text == username &&
                textBoxPassword.Text == password)
                login = true;
            else
                login = false;
            reader.Close();      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }

        private void password_textchanged(object sender, EventArgs e)
        {
            //If password field is not empty, then login is enabled
            if (textBoxPassword.TextLength != 0)
            {
                btnLogin.Enabled = true;
            }
            else //If password field is empty, login function will be disabled
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            getAccountInfo();
            //If both username and password are correct, display check mark and success message
            if (login)
            {
                label3.ForeColor = Color.FromArgb(50, 205, 50);
                label3.Text = "Login Successful!";
                pictureBox1.Image = imageList1.Images[0];

                Calculator c = new Calculator();
                this.Hide();
                c.Show();

            }
            else //If any of the two field are not correct, display error message and wrong mark
            {
                label3.ForeColor = Color.FromArgb(220, 20, 60);
                label3.Text = string.Format("Username/Password is wrong! \nAttempt remains: {0}",
                    2 - counter);
                pictureBox1.Image = imageList1.Images[1];
                counter++;
                if (counter == 3)
                //When attemp after three times, hide both login and cancel button
                //And display lock message and wrong mark
                {
                    btnLogin.Visible = false;
                    btnCancel.Visible = false;
                    label3.ForeColor = Color.FromArgb(220, 20, 60);
                    label3.Text = "Your account is locked!";
                }
            }
        }
    }
}

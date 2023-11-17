using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace RegisterAndLogin
{
    public partial class LoginForm : Form
    {
        UserList userList;
        public LoginForm()
        {
            InitializeComponent();
            userList = new UserList();
            userList.Users = userList.LoadFromDisk();
            this.password.UseSystemPasswordChar = !this.password.UseSystemPasswordChar;
        }


       private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                
                 String.IsNullOrEmpty(username.Text) ||
                 String.IsNullOrEmpty(password.Text)
             )
            {
                MessageBox.Show("Please fill in all fields", "Error");
                return;
            }


            User user = userList.SearchByName(username.Text);
            if (user == null) 
            {
                MessageBox.Show("User don t exist");
                return;
                
            }
            if(user.Password != password.Text)
            {
                MessageBox.Show("password don t exist");
                return;
            }
            new YourAcc().Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.password.UseSystemPasswordChar = !this.password.UseSystemPasswordChar;
        }

        private void CreateNewAcc_Click(object sender, EventArgs e)
        {
            new NewAcc().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RegisterAndLogin
{
    public partial class NewAcc : Form
    {
        UserList userList;
        public NewAcc()
        {
            InitializeComponent();
            userList = new UserList();
            userList.Users = userList.LoadFromDisk();
            this.password.UseSystemPasswordChar = !this.password.UseSystemPasswordChar;
        }
        
        private void textBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_Leave(object sender, EventArgs e)
        { }

        private void Form2_Load(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!agree.Checked)
            {
                MessageBox.Show("Please accept termen and condition", "Error");
                return;
            }
               
            if (
                 String.IsNullOrEmpty(name.Text) ||
                 String.IsNullOrEmpty(surname.Text) ||
                 String.IsNullOrEmpty(country.Text) ||
                 String.IsNullOrEmpty(city.Text) ||
                 String.IsNullOrEmpty(email.Text) ||
                 String.IsNullOrEmpty(username.Text) ||
                 String.IsNullOrEmpty(password.Text) 
             )
            {
                MessageBox.Show("Please fill in all fields", "Error");
                return;
            }
            User user = new User { Name = name.Text, Surname = surname.Text, Country = country.Text, City = city.Text, Email = email.Text, Username = username.Text, Password = password.Text };
            userList.Add(user);
            userList.SaveOnDisk();
            new LoginForm().Show();
            this.Hide();

        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.password.UseSystemPasswordChar = !this.password.UseSystemPasswordChar;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void agree_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

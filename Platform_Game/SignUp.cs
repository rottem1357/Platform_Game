using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platform_Game
{
    public partial class SignUp : Form
    {
        User MyUser;
        public SignUp()
        {
            MyUser = new User();
            Users.DownloadUsers();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                MyColor.BackColor = colorDialog1.Color;
                MyColor.Text = MyColor.BackColor.Name;
            }                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyUser.UserName = textUserName.Text;
            MyUser.Password = textPassword.Text;
            MyUser.NickName = textNickName.Text;
            MyUser.MainColorName = MyColor.BackColor.Name;

            if(Users.IsExist(textUserName.Text) != 0)
            {
                MessageBox.Show("UserName is taken");
                return;
            }
            if(MyUser.IsValidInput())
            {
                Users.AddUser(MyUser);
                Users.UploadUsers();
                MessageBox.Show("You have succesfully signed up");
                return;
            }
            MessageBox.Show("Fill all form fields");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

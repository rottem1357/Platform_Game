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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            Users.DownloadUsers();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form;
            int id;

            id = Users.IsExist(textUserName.Text);
            if (id == 0)
            {
                MessageBox.Show("Account does not exist");
                return;
            }
            if(textPassword.Text != Users.GetPasswordAtId(id))
            {
                MessageBox.Show("Incorrect Password");
                return;
            }
            form = new Form1(id);
            form.ShowDialog();
                
        }
    }
}

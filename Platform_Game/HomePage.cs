﻿using System;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            new Users();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(0);
            form1.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}

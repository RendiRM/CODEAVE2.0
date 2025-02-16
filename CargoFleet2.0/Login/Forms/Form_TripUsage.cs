﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Forms
{
    public partial class Form_TripUsage : Form
    {
        public Form_TripUsage()
        {
            InitializeComponent();
        }

        private void Form_TripUsage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure that you want to sign out", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (exit == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {

            }
        }
    }
}

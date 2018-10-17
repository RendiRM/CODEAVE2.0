using System;
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
    public partial class Form_OfficeManager : Form
    {
        public Form_OfficeManager()
        {
            InitializeComponent();
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
           DialogResult exit = MessageBox.Show("Are you sure that you want to sign out","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if (exit == DialogResult.OK)
            {
                //this.Hide();
                Login login = new Login();
                login.Show();
                
            }
            else
            {

            }
        }
    }
}

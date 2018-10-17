using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.UserControls
{
    public partial class UC_AddVehicle : UserControl
    {
        public UC_AddVehicle()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to store this data on the database","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {

            }
        }
    }
}

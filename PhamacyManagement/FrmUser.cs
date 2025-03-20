using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamacyManagement
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            uC_DashBoard1.Visible = false;
            uC_AddMedicine1.Visible = false;
            BtnDashBroadM.PerformClick();


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

        }

        private void BtnDashBroadM_Click(object sender, EventArgs e)
        {
            uC_DashBoard1.Visible = true;
            uC_DashBoard1.BringToFront();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uC_AddMedicine1.Visible = true;
            uC_DashBoard1.Visible = false;
            uC_AddMedicine1.BringToFront();
        }
    }
}

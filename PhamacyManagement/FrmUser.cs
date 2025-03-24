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
            uC_AddMedicine5.Visible = false;
            uC_ViewMedicine2.Visible = false;
            uC_UpdateMedicine5.Visible = false;
            uC_ViewCheckAvailbility1.Visible = false;
            uC_SellMedicine2.Visible = false;
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
            uC_AddMedicine5.Visible = true;
            uC_AddMedicine5.BringToFront();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uC_ViewMedicine2.Visible = true;
            uC_ViewMedicine2.BringToFront();
        }

        private void btnUpdateMedic_Click(object sender, EventArgs e)
        {
            uC_UpdateMedicine5.Visible = true;
            uC_UpdateMedicine5.BringToFront();
        }

        private void btnCheckValid_Click(object sender, EventArgs e)
        {
            uC_ViewCheckAvailbility1.Visible = true;
            uC_ViewCheckAvailbility1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            uC_SellMedicine2.Visible = true;
            uC_SellMedicine2.BringToFront();
        }
    }
}

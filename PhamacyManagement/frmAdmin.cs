using PhamacyManagement.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace PhamacyManagement
{
    public partial class frmAdmin : Form
    {
        string user="";
        public frmAdmin()
        {
            InitializeComponent();
        }
        public string ID
        {
            get
            {
                return user.ToString();
            }
            
        }
        public frmAdmin(string Username)
        {
            InitializeComponent();
            LbUserName.Text = Username;
            user = Username;
            uC_ViewUsers1.ID = ID;
            uC_Profile1.ID = ID;

        }
        
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            uC_DashBroad1.Visible=false;
            btnDashBoard.PerformClick();
            uC_AddUser1.Visible=false;
            uC_Profile1.Visible = false;
        }

       

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
           uC_DashBroad1.Visible = true;
            uC_ViewUsers1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_DashBroad1.BringToFront();
        }

       

       

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_DashBroad1.Visible = false;
            uC_ViewUsers1.Visible = false;
            uC_AddUser1.BringToFront();
        }

        

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewUsers1.Visible = true;
            uC_AddUser1.Visible = false;
            uC_DashBroad1.Visible = false;
            uC_ViewUsers1.BringToFront();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_ViewUsers1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_Profile1.BringToFront();
        }

        
    }
}

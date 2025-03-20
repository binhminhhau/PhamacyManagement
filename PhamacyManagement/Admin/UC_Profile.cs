using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamacyManagement.Admin
{
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        string query;
        public UC_Profile()
        {
            InitializeComponent();
        }
        public string ID {
        set { lbUserName.Text = value; }
        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query = "Select * from users where username = '" + lbUserName.Text + "'";
            DataSet ds = fn.getData(query);
            TxtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            TxtName.Text = ds.Tables[0].Rows[0][2].ToString();
            TxtDob.Text = ds.Tables[0].Rows[0][3].ToString();
            TxtPhone.Text = ds.Tables[0].Rows[0][4].ToString();
            TxtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            TxtPassword.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String role = TxtUserRole.Text;
            string name = TxtName.Text;
            string dob = TxtDob.Text;
            Int64 mobile = Int64.Parse(TxtPhone.Text);
            string email = TxtEmail.Text;
            string username = lbUserName.Text;
            string pass = TxtPassword.Text;
            query = "update users set userRole = '" +role+ "', name = '" +name+ "', dob = '" +dob+ "', mobile = '" + mobile +"', email = '"+ email +"', pass = '"+ pass +"' where username = '"+ username +"'";
            fn.setData(query,"Hồ sơ đã được cập nhật!");
        }
    }
}

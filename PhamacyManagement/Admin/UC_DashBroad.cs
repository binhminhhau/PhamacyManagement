using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamacyManagement.Admin
{
    public partial class UC_DashBroad : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        public UC_DashBroad()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UC_DashBroad_Load(object sender, EventArgs e)
        {
            query = "Select count(*) from users where userRole = 'Admin'";
            ds = fn.getData(query);
            Setlabel(ds, LblAdmin);
            query = "Select count(*) from users where userRole = 'User'";
            ds = fn.getData(query);
            Setlabel(ds, lbUser);

        }
        private void Setlabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
            lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UC_DashBroad_Load(this, null);
        }
    }
}

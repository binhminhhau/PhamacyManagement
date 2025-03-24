using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamacyManagement.User_Medicine
{
    
    public partial class UC_DashBoard : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        Int64 count;
        public UC_DashBoard()
        {
            InitializeComponent();
        }

        private void US_DashBroad_Load(object sender, EventArgs e)
        {
            LoadChart();

        }
        public void LoadChart()
        {
            query = " select Count(mname) from medic where eDate >= getdate()";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Thuốc còn hạn"].Points.AddY( count);

            query = " select Count(mname) from medic where eDate < getdate()";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Thuốc hết hạn"].Points.AddY(count);

        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            chart1.Series["Thuốc còn hạn"].Points.Clear();
            chart1.Series["Thuốc hết hạn"].Points.Clear();
            LoadChart();
        }
    }
}

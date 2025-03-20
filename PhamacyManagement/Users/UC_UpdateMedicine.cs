using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamacyManagement.Users
{
    public partial class UC_UpdateMedicine : UserControl
    {
        function fn = new function();
        string query;
        public UC_UpdateMedicine()
        {
            InitializeComponent();
        }
        private void clearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtPrice.Clear();
            txtMedicineNumber.Clear();
            txtMDate.ResetText();
            txtEDate.ResetText();
            txtAddQuantity.Clear();
            txtAvailable.Clear();

            if(txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMedicineName.Text;
            String mnumber = txtMedicineNumber.Text;
            String mdate = txtMDate.Text;
            String edate = txtEDate.Text;
            Int64 quantity = Int64.Parse(txtAvailable.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitprice = Int64.Parse(txtPrice.Text);

            totalQuantity = quantity + addQuantity;

            query = "update medic set mname = '" + mname + "', mNumber = '" + mnumber + "', mDate = '" + mdate + "', eDate = '" + edate + "', quantity = " + totalQuantity + ", perunit = " + unitprice + " where mid = " + txtMedicineID.Text + "";
            fn.setData(query, "Đã cập nhật chi tiết thuốc.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "")
            {
                query = "select * from medic where mid = " + txtMedicineID.Text + "";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedicineName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedicineNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAvailable.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thuốc giống ID này: " + txtMedicineID.Text + " Hiện hữu.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                clearAll();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}

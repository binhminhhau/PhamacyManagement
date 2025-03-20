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
    public partial class UC_AddMedicine : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            if (TxtMedicineID.Text !="" && TxtNameMedicine.Text !="" && TxtMedicineNuber.Text !="" && TxtAmount.Text !="" && TxtCostMedicine.Text !="" ) {
                String mid = TxtMedicineID.Text;
                String mname = TxtNameMedicine.Text;
                String mnumber = TxtMedicineNuber.Text;
                string mdate = BtnSanxuat.Text;
                string edate = BtnHethan.Text;
                Int64 quantity = Int64.Parse(TxtAmount.Text);
                Int64 price = Int64.Parse(TxtCostMedicine.Text);

                query = "insert into medic (mid, mname, mnumber, mDate, eDate,quantity,perUnit) values ('" + mid + "','" + mname + "','" + mnumber + "','" + mdate + "','" + edate + "'," + quantity + "," + price + ")";
                fn.setData(query, "Đã thêm thuốc thành công!"); 
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            TxtMedicineID.Clear();
            TxtNameMedicine.Clear();
            TxtMedicineNuber.Clear();
            TxtAmount.Clear();
            TxtCostMedicine.Clear();
            BtnHethan.ResetText();
            BtnSanxuat.ResetText();
        }

        private void UC_AddMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}

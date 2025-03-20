using System;
using DGVPrinterHelper;
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
    public partial class UC_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_SellMedicine()
        {
            InitializeComponent();
        }

        private void UC_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medic where eDate >= getDate() and quantity > 0";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medic where mname like '" + txtSearch.Text + "%' and eDate >= getDate() and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumber.Clear();
            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);
            txtMedicineName.Text = name;
            query = "select mid, eDate, perUnit from medic where mname = '" + name + "'";
            ds = fn.getData(query);
            txtMedicineID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpiryDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][2].ToString();

        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if(txtNumber.Text != "")
            {
                Int64 unitPrice = Convert.ToInt64(txtPrice.Text);
                Int64 number = Convert.ToInt64(txtNumber.Text);
                Int64 total = unitPrice * number;
                txtTotal.Text = total.ToString();
            }
            else
            {
                txtTotal.Clear();
            }
        }

        protected int n, total = 0;
        protected Int64 quantity, newQuantity;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "")
            {
                query = "select quantity from medic where mid = " + txtMedicineID.Text + "";
                DataSet ds = fn.getData(query);
                quantity = Convert.ToInt64(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = Convert.ToInt64(txtNumber.Text);

                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMedicineID.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMedicineName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExpiryDate.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtPrice.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtNumber.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotal.Text;

                    total = total + Convert.ToInt32(txtTotal.Text);
                    lblTotal.Text = "Rs. " + total.ToString();

                    query = "update medic set quantity = '" + newQuantity + " where mid = '" + txtMedicineID.Text + "'";
                    fn.setData(query, "Thuốc đã được thêm vào giỏ hàng!");
                }
                else
                {
                    MessageBox.Show("Thuốc hết hàng\n Chỉ số " + quantity + " Sau ", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                clearAll();
                UC_SellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Chọn thuốc trước tiên", " Thông tin ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int valueAmount;
        String valueID;
        protected Int64 Number;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueID = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Number = Convert.ToInt64(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueID != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch { }
                finally
                {
                    query = "select quantity from medic where mid = " + valueID + "";
                    ds = fn.getData(query);
                    quantity = Convert.ToInt64(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + Number;

                    query = "update medic set quantity = '" + newQuantity + "' where mid = '" + valueID + "'";
                    fn.setData(query, "Thuốc đã được xóa khỏi giỏ hàng!");
                    total = total - valueAmount;
                    lblTotal.Text = "Rs. " + total.ToString();

                }
                UC_SellMedicine_Load(this, null);
            }
        }


        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Hóa Đơn Thuốc";
            printer.SubTitle = String.Format("Ngày: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Tổng tiền phải trả: " + lblTotal.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);

            total = 0;
            lblTotal.Text = "Rs. 00";
            guna2DataGridView1.DataSource=0;
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_SellMedicine_Load(this, null);
        }
        private void clearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtExpiryDate.ResetText();
            txtPrice.Clear();
            txtNumber.Clear();
            txtTotal.Clear();
        }
    }
}

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
    public partial class UC_ViewUsers : UserControl
    {
        function fn = new function();
        string query;
        string Username;
        string CurrentUser;
        public UC_ViewUsers()
        {
            InitializeComponent();
        }
        public string ID
        {
            set
            {
               CurrentUser= value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UC_ViewUsers_Load(this, null);
        }

        private void UC_ViewUsers_Load(object sender, EventArgs e)
        {
            query = "Select * from users";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
             Username = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {
             
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (CurrentUser != Username)
                {
                    query = "delete from users where username = '" + Username + "'";
                    fn.setData(query, "Đã xóa");
                    UC_ViewUsers_Load(this, null);
                    
                }
                else
                {
                    MessageBox.Show("Không thể xóa tài khoản của chính bạn, hoặc có lỗi, Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from users where name like '" + TxtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}

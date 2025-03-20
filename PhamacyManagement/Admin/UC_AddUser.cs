using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamacyManagement.Admin
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string role = txtRole.Text;
            string name = txtName.Text;
            string dob = TxtDob.Text;
            string username = txtUserName.Text;
            string pass = txtPassword.Text;
            Int64 mobile = Int64.Parse(txtPhone.Text);
            string email = txtEmail.Text;


            try
            {
                query = "INSERT INTO users (userRole, name, dob, mobile, email, username, pass) " +
                        "VALUES (@role, @name, @dob, @mobile, @email, @username, @pass)";

                using (SqlConnection con = fn.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@mobile", mobile);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@pass", pass);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Đã thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearAll()
        {
            txtRole.SelectedIndex = -1;
            txtName.Clear();
            TxtDob.ResetText();
            txtUserName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM users WHERE username = @username";
            DataSet ds = fn.getData(query, new SqlParameter("@username", txtUserName.Text));

            if (ds.Tables[0].Rows.Count == 0)
            {
                PicAddUser.ImageLocation = @"C:\Users\ADMIN\Pictures\image_pharmacy\yes.png";
            }
            else
            {
                PicAddUser.ImageLocation = @"C:\Users\ADMIN\Pictures\image_pharmacy\no.png";
            }
        }


        //private void txtUserName_TextChanged(object sender, EventArgs e)
        //{
        //    query = "select * from users where username = '" + txtUserName.Text + "'";
        //    DataSet ds = fn.getData(query);

        //    if (ds.Tables[0].Rows.Count == 0)
        //    {
        //        PicAddUser.ImageLocation = @"C:\Users\ADMIN\Pictures\image_pharmacy\yes.pnj";
        //    }
        //    else
        //    {
        //        PicAddUser.ImageLocation = @"C:\Users\ADMIN\Pictures\image_pharmacy\no.png";
        //    }

        //}

        private void txtRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

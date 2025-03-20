using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhamacyManagement.Admin;

namespace PhamacyManagement
{
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSign; 

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "root" && txtPassword.Text == "root")
            {
                frmAdmin adm = new frmAdmin(txtUsername.Text);
                adm.Show();
                this.Hide();
            }
            else
            {
                query = "select * from users where username = '" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "'";
                ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    string role = ds.Tables[0].Rows[0]["userRole"].ToString();
                    if (role == "Admin")
                    {
                        frmAdmin adm = new frmAdmin(txtUsername.Text);
                        adm.Show();
                        this.Hide();
                    }
                    else if (role == "User")
                    {
                        FrmUser user = new FrmUser();
                        user.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}

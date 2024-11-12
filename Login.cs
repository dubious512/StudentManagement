using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Login : Form
    {
        private MenuManage mainForm;
        public Login(MenuManage main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy thông tin đăng nhập từ người dùng
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                txtUsername.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text)) 
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                txtPassword.Select(); 
                return;
            }
            // Kiểm tra thông tin đăng nhập (ví dụ, so sánh với dữ liệu lưu trữ)
            if (username == "admin" && password == "12345678")
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");
                // Đóng form đăng nhập và mở form chính của ứng dụng
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

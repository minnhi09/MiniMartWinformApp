using QLCuaHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHang
{
    public partial class LoginForm : Form
    {
        private AuthenticationService authService;

        public LoginForm()
        {
            InitializeComponent();
            authService = AuthenticationService.Instance;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text.Trim();
            string password = txt_MatKhau.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt login
            NhanVien user = authService.Login(username, password);

            if (user != null)
            {
                string roleText = user.GetRoleDisplayName();
                MessageBox.Show($"Đăng nhập thành công!\nXin chào {user.TenNV}\nQuyền: {roleText}", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                MainForm frm = new MainForm(user);
                frm.FormClosed += (s, args) => {
                    authService.Logout(); // Đăng xuất khi đóng MainForm
                    this.Show();
                };
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_MatKhau.Clear();
                txt_UserName.Focus();
            }
        }

        private void frm_LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            // Tạm thời disable chức năng đăng ký
            MessageBox.Show("Chức năng đăng ký tạm thời không khả dụng.\nVui lòng liên hệ Admin để tạo tài khoản.", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

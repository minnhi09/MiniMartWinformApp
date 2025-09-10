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
       

        private List<NhanVien> danhSachNhanVien = new List<NhanVien>
        {
            new NhanVien(1, "Moemo", "admin", "123", "Quản lý"),
            new NhanVien(2, "Anh Khoa", "user1", "abc", "Nhân viên"),
            new NhanVien(3, "Quan Thùy Trâm", "user2", "xyz", "Nhân viên")
        };

        private NhanVien LoggedInUser;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            string username = txt_UserName.Text.Trim();
            string password = txt_MatKhau.Text.Trim();
            NhanVien user = null;
            foreach (var nv in danhSachNhanVien)
            {
                if (nv.UserName == username && nv.Password == password)
                {
                    user = nv;
                    break;
                }
            }

            if (user != null)
            {
                LoggedInUser = user;
                MessageBox.Show("Đăng nhập thành công! Xin chào " + user.TenNV, "Thông báo");

                this.Hide();
                MainForm frm = new MainForm(user);
                frm.FormClosed += (s, args) => this.Show();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Hide();

            SignUp signupForm = new SignUp();
            signupForm.ShowDialog();

            this.Show();
        }
    }
}

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
    public partial class frm_NhanVien : Form
    {
        private List<NhanVien> danhSachNhanVien = new List<NhanVien>();
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void btn_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_AccountProfile frm = new frm_AccountProfile();
            frm.FormClosed += (s, args) => this.Hide();
            frm.ShowDialog();
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn trở về không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                MainForm frm = new MainForm();
                frm.FormClosed += (s, args) => this.Show();
                frm.ShowDialog();
            }
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            danhSachNhanVien.Add(new NhanVien(1, "Moemo", "admin", "123", "Quản lý"));
            danhSachNhanVien.Add(new NhanVien(2, "Anh Khoa", "user1", "abc", "Nhân viên"));
            danhSachNhanVien.Add(new NhanVien(3, "Quan Thùy Trâm", "user2", "xyz", "Nhân viên"));

            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            lv_All.Items.Clear();
            lv_QuanLy.Items.Clear();
            lv_NhanVien.Items.Clear();

            foreach (var nv in danhSachNhanVien)
            {
                ListViewItem item = new ListViewItem(nv.MaNV.ToString());
                item.SubItems.Add(nv.TenNV);
                item.SubItems.Add(nv.UserName);
                item.SubItems.Add(new string('*', nv.Password.Length));

                lv_All.Items.Add((ListViewItem)item.Clone()); 

                if (nv.Role == "Quản lý")
                    lv_QuanLy.Items.Add((ListViewItem)item.Clone());
                else if (nv.Role == "Nhân viên")
                    lv_NhanVien.Items.Add((ListViewItem)item.Clone());
            }
        }
    }
}

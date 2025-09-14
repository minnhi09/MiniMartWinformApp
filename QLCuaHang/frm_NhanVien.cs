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
        private AuthenticationService authService;

        public frm_NhanVien()
        {
            InitializeComponent();
            authService = AuthenticationService.Instance;
        }

        private void btn_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_AccountProfile frm = new frm_AccountProfile();
            frm.FormClosed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        /// <summary>
        /// Mở form quản lý user (chỉ Admin)
        /// </summary>
        private void btnQuanLyUser_Click(object sender, EventArgs e)
        {
            if (!authService.IsCurrentUserAdmin())
            {
                MessageBox.Show("Chỉ Admin mới có quyền quản lý user!", "Không có quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            frmUserManagement frm = new frmUserManagement();
            frm.FormClosed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn trở về không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form hiện tại thay vì tạo MainForm mới
            }
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            // Kiểm tra quyền truy cập khi load form
            if (!authService.IsCurrentUserAdmin())
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng quản lý nhân viên!", 
                    "Không có quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            LoadDanhSachNhanVien();
        }

        /// <summary>
        /// Load danh sách nhân viên từ AuthenticationService
        /// </summary>
        private void LoadDanhSachNhanVien()
        {
            var danhSach = authService.GetAllUsers();
            if (danhSach != null)
            {
                HienThiDanhSach(danhSach);
            }
        }

        /// <summary>
        /// Hiển thị danh sách nhân viên lên ListView
        /// </summary>
        private void HienThiDanhSach(List<NhanVien> danhSachNhanVien)
        {
            // Clear tất cả ListView trước
            if (lv_All != null) lv_All.Items.Clear();
            if (lv_QuanLy != null) lv_QuanLy.Items.Clear();
            if (lv_NhanVien != null) lv_NhanVien.Items.Clear();

            foreach (var nv in danhSachNhanVien)
            {
                ListViewItem item = new ListViewItem(nv.MaNV.ToString());
                item.SubItems.Add(nv.TenNV);
                item.SubItems.Add(nv.UserName);
                item.SubItems.Add(new string('*', nv.Password.Length));
                item.SubItems.Add(nv.GetRoleDisplayName());
                item.Tag = nv; // Lưu object NhanVien vào Tag

                // Thêm vào ListView tương ứng
                if (lv_All != null)
                    lv_All.Items.Add((ListViewItem)item.Clone()); 

                if (nv.Role == UserRole.Admin && lv_QuanLy != null)
                    lv_QuanLy.Items.Add((ListViewItem)item.Clone());
                else if (nv.Role == UserRole.NhanVien && lv_NhanVien != null)
                    lv_NhanVien.Items.Add((ListViewItem)item.Clone());
            }
        }
    }
}

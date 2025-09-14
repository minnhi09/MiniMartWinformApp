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
    public partial class MainForm : Form
    {
        private NhanVien currentUser;
        private AuthenticationService authService;

        public MainForm()
        {
            InitializeComponent();
            authService = AuthenticationService.Instance;
        }

        public MainForm(NhanVien user) : this()
        {
            currentUser = user;
            this.Text = $"Hệ thống quản lý cửa hàng - {user.TenNV} ({user.GetRoleDisplayName()})";
            SetupUserInterface();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            SetupUserInterface();
        }

        /// <summary>
        /// Cấu hình giao diện theo quyền user
        /// </summary>
        private void SetupUserInterface()
        {
            if (currentUser == null) return;

            // Hiển thị thông tin user
            UpdateUserInfo();

            // Cấu hình quyền truy cập các chức năng
            ConfigurePermissions();
        }

        /// <summary>
        /// Cập nhật thông tin user hiển thị
        /// </summary>
        private void UpdateUserInfo()
        {
            // Có thể thêm label hiển thị thông tin user ở đây
            // Ví dụ: lblUserInfo.Text = $"Đăng nhập: {currentUser.TenNV} - {currentUser.GetRoleDisplayName()}";
        }

        /// <summary>
        /// Cấu hình quyền truy cập theo role
        /// </summary>
        private void ConfigurePermissions()
        {
            bool isAdmin = currentUser.IsAdmin();

            // Chức năng chỉ Admin mới được truy cập
            if (btnNhanVien != null) 
                btnNhanVien.Enabled = isAdmin;
            
            if (btnDoanhThu != null) 
                btnDoanhThu.Enabled = isAdmin;

            // Thêm tooltip để giải thích tại sao bị disable
            if (!isAdmin)
            {
                if (btnNhanVien != null)
                {
                    btnNhanVien.BackColor = Color.LightGray;
                    ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(btnNhanVien, "Chỉ Admin mới có quyền quản lý nhân viên");
                }

                if (btnDoanhThu != null)
                {
                    btnDoanhThu.BackColor = Color.LightGray;
                    ToolTip tooltip2 = new ToolTip();
                    tooltip2.SetToolTip(btnDoanhThu, "Chỉ Admin mới có quyền xem doanh thu");
                }
            }

            // Chức năng tất cả user đều được truy cập
            // btnHangHoa, btn_KhachHang - giữ nguyên
        }

        /// <summary>
        /// Load danh sách sản phẩm
        /// </summary>
        private void LoadProducts()
        {
            try
            {
                // Sử dụng đường dẫn tương đối từ thư mục dự án
                string projectPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                string cocaPath = System.IO.Path.Combine(projectPath, "..\\..\\..\\cocacola.png");
                string miPath = System.IO.Path.Combine(projectPath, "..\\..\\..\\mihaohao.png");

                // Nếu không tìm thấy file, sử dụng đường dẫn mặc định
                if (!System.IO.File.Exists(cocaPath))
                    cocaPath = @"D:\QLCuaHang\cocacola.png";
                if (!System.IO.File.Exists(miPath))
                    miPath = @"D:\QLCuaHang\mihaohao.png";

                AddButton("Coca Cola", 10000, cocaPath, flpnDoUong);
                AddButton("Mì hảo hảo", 5000, miPath, flpn_DoAn);
                AddButton("Coca Cola", 10000, cocaPath, flpnDoUong);
                AddButton("Mì hảo hảo", 5000, miPath, flpn_DoAn);
                AddButton("Coca Cola", 10000, cocaPath, flpnDoUong);
                AddButton("Mì hảo hảo", 5000, miPath, flpn_DoAn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#F5ECDD");
        }

        private Button CreateProductButton(string ten, decimal gia, string path)
        {
            Button btn = new Button();
            btn.Size = new Size(140, 160);
            btn.Image = new Bitmap(Image.FromFile(path), new Size(80, 80));
            btn.ImageAlign = ContentAlignment.TopCenter;
            btn.Text = ten + "\n" + gia.ToString("N0") + " đ";
            btn.TextAlign = ContentAlignment.BottomCenter;
            return btn;
        }

        private void AddButtonToPanel(Button btn, FlowLayoutPanel panel)
        {
            panel.Controls.Add(btn);
        }

        private void AddButton(string ten, decimal gia, string path, params FlowLayoutPanel[] danhMucPanels)
        {
            Button productButton = CreateProductButton(ten, gia, path);

            foreach (var panel in danhMucPanels)
                AddButtonToPanel(productButton, panel);

            if (!danhMucPanels.Contains(flpnAll))
            {
                Button btnForAll = CreateProductButton(ten, gia, path);
                AddButtonToPanel(btnForAll, flpnAll);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            // Tất cả user đều có quyền quản lý hàng hóa, nhưng có thể giới hạn chức năng cụ thể
            this.Hide();
            frm_HangHoa hangHoafrm = new frm_HangHoa();
            hangHoafrm.FormClosed += (s, args) => this.Show();
            hangHoafrm.ShowDialog();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            // Kiểm tra quyền truy cập
            if (!authService.HasPermission(UserRole.Admin))
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!\nChỉ Admin mới được xem doanh thu.", 
                    "Không có quyền truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            frmDoanhThu doanhThufrm = new frmDoanhThu();
            doanhThufrm.FormClosed += (s, args) => this.Show();
            doanhThufrm.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            // Kiểm tra quyền truy cập
            if (!authService.HasPermission(UserRole.Admin))
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!\nChỉ Admin mới được quản lý nhân viên.", 
                    "Không có quyền truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            frm_NhanVien frm = new frm_NhanVien();
            frm.FormClosed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            // Tất cả user đều có quyền quản lý khách hàng
            this.Hide();
            frm_KhachHang frm = new frm_KhachHang();
            frm.FormClosed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}

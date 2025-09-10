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
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(NhanVien user) : this()
        {
            currentUser = user;
            this.Text = "Xin chào " + user.TenNV;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddButton("Coca Cola", 10000, @"D:\QLCuaHang\cocacola.png", flpnDoUong);
            AddButton("Mì hảo hảo", 5000, @"D:\QLCuaHang\mihaohao.png", flpn_DoAn);
            AddButton("Coca Cola", 10000, @"D:\QLCuaHang\cocacola.png", flpnDoUong);
            AddButton("Mì hảo hảo", 5000, @"D:\QLCuaHang\mihaohao.png", flpn_DoAn);
            AddButton("Coca Cola", 10000, @"D:\QLCuaHang\cocacola.png", flpnDoUong);
            AddButton("Mì hảo hảo", 5000, @"D:\QLCuaHang\mihaohao.png", flpn_DoAn);
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
            this.Hide();
            frm_HangHoa hangHoafrm = new frm_HangHoa();
            hangHoafrm.FormClosed += (s, args) => this.Show();
            hangHoafrm.ShowDialog();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoanhThu doanhThufrm = new frmDoanhThu();
            doanhThufrm.FormClosed += (s, args) => this.Show();
            doanhThufrm.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_NhanVien frm = new frm_NhanVien();
            frm.FormClosed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
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

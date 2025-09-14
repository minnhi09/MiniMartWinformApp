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
    public partial class frmUserManagement : Form
    {
        private AuthenticationService authService;
        private NhanVien selectedUser = null;

        public frmUserManagement()
        {
            InitializeComponent();
            authService = AuthenticationService.Instance;
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            // Kiểm tra quyền truy cập
            if (!authService.IsCurrentUserAdmin())
            {
                MessageBox.Show("Chỉ Admin mới có quyền quản lý user!", "Không có quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            InitializeUI();
            LoadUserList();
        }

        private void InitializeUI()
        {
            // Cấu hình ComboBox Role
            cmbRole.Items.Clear();
            cmbRole.Items.Add(new ComboItem("Admin", UserRole.Admin));
            cmbRole.Items.Add(new ComboItem("Nhân viên", UserRole.NhanVien));
            cmbRole.SelectedIndex = 1; // Mặc định là Nhân viên

            // Cấu hình ListView
            SetupListView();
            
            // Clear form
            ClearForm();
        }

        private void SetupListView()
        {
            lvUsers.View = View.Details;
            lvUsers.FullRowSelect = true;
            lvUsers.GridLines = true;
            
            lvUsers.Columns.Clear();
            lvUsers.Columns.Add("Mã NV", 80);
            lvUsers.Columns.Add("Tên nhân viên", 200);
            lvUsers.Columns.Add("Username", 150);
            lvUsers.Columns.Add("Quyền", 100);
        }

        private void LoadUserList()
        {
            lvUsers.Items.Clear();
            var users = authService.GetAllUsers();
            
            if (users != null)
            {
                foreach (var user in users)
                {
                    ListViewItem item = new ListViewItem(user.MaNV.ToString());
                    item.SubItems.Add(user.TenNV);
                    item.SubItems.Add(user.UserName);
                    item.SubItems.Add(user.GetRoleDisplayName());
                    item.Tag = user;
                    
                    lvUsers.Items.Add(item);
                }
            }
        }

        private void ClearForm()
        {
            txtTenNV.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 1;
            selectedUser = null;
            
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count > 0)
            {
                selectedUser = (NhanVien)lvUsers.SelectedItems[0].Tag;
                
                txtTenNV.Text = selectedUser.TenNV;
                txtUsername.Text = selectedUser.UserName;
                txtPassword.Text = selectedUser.Password;
                
                // Chọn role trong ComboBox
                for (int i = 0; i < cmbRole.Items.Count; i++)
                {
                    ComboItem item = (ComboItem)cmbRole.Items[i];
                    if (item.Value == selectedUser.Role)
                    {
                        cmbRole.SelectedIndex = i;
                        break;
                    }
                }
                
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = selectedUser.MaNV != authService.CurrentUser.MaNV; // Không thể xóa chính mình
            }
            else
            {
                ClearForm();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            ComboItem selectedRole = (ComboItem)cmbRole.SelectedItem;
            NhanVien newUser = new NhanVien(0, txtTenNV.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text, selectedRole.Value);

            if (authService.AddUser(newUser))
            {
                MessageBox.Show("Thêm user thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserList();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm user thất bại! Username có thể đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUser == null || !ValidateInput()) return;

            ComboItem selectedRole = (ComboItem)cmbRole.SelectedItem;
            
            selectedUser.TenNV = txtTenNV.Text.Trim();
            selectedUser.Password = txtPassword.Text;
            selectedUser.Role = selectedRole.Value;

            if (authService.UpdateUser(selectedUser))
            {
                MessageBox.Show("Cập nhật user thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserList();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Cập nhật user thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUser == null) return;

            if (selectedUser.MaNV == authService.CurrentUser.MaNV)
            {
                MessageBox.Show("Không thể xóa chính mình!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa user '{selectedUser.TenNV}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                if (authService.DeleteUser(selectedUser.MaNV))
                {
                    MessageBox.Show("Xóa user thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserList();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Xóa user thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập username!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập password!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn quyền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Helper class cho ComboBox
    public class ComboItem
    {
        public string Text { get; set; }
        public UserRole Value { get; set; }

        public ComboItem(string text, UserRole value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
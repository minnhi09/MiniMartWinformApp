namespace QLCuaHang
{
    partial class frm_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_NhanVien = new System.Windows.Forms.TabControl();
            this.tp_NhanVien = new System.Windows.Forms.TabPage();
            this.lv_NhanVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp_QuanLy = new System.Windows.Forms.TabPage();
            this.lv_QuanLy = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp_All = new System.Windows.Forms.TabPage();
            this.lv_All = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelInput = new System.Windows.Forms.Panel();
            this.btn_ThongTinCaNhan = new System.Windows.Forms.Button();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.tc_NhanVien.SuspendLayout();
            this.tp_NhanVien.SuspendLayout();
            this.tp_QuanLy.SuspendLayout();
            this.tp_All.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_NhanVien
            // 
            this.tc_NhanVien.Controls.Add(this.tp_NhanVien);
            this.tc_NhanVien.Controls.Add(this.tp_QuanLy);
            this.tc_NhanVien.Controls.Add(this.tp_All);
            this.tc_NhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_NhanVien.Location = new System.Drawing.Point(13, 48);
            this.tc_NhanVien.Name = "tc_NhanVien";
            this.tc_NhanVien.SelectedIndex = 0;
            this.tc_NhanVien.Size = new System.Drawing.Size(751, 514);
            this.tc_NhanVien.TabIndex = 0;
            // 
            // tp_NhanVien
            // 
            this.tp_NhanVien.Controls.Add(this.lv_NhanVien);
            this.tp_NhanVien.Location = new System.Drawing.Point(4, 31);
            this.tp_NhanVien.Name = "tp_NhanVien";
            this.tp_NhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tp_NhanVien.Size = new System.Drawing.Size(743, 479);
            this.tp_NhanVien.TabIndex = 0;
            this.tp_NhanVien.Text = "Nhân viên";
            this.tp_NhanVien.UseVisualStyleBackColor = true;
            // 
            // lv_NhanVien
            // 
            this.lv_NhanVien.CheckBoxes = true;
            this.lv_NhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_NhanVien.GridLines = true;
            this.lv_NhanVien.HideSelection = false;
            this.lv_NhanVien.Location = new System.Drawing.Point(3, 3);
            this.lv_NhanVien.Name = "lv_NhanVien";
            this.lv_NhanVien.Size = new System.Drawing.Size(737, 473);
            this.lv_NhanVien.TabIndex = 0;
            this.lv_NhanVien.UseCompatibleStateImageBehavior = false;
            this.lv_NhanVien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã nhân viên";
            this.columnHeader1.Width = 194;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UserName";
            this.columnHeader3.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mật khẩu";
            this.columnHeader4.Width = 288;
            // 
            // tp_QuanLy
            // 
            this.tp_QuanLy.Controls.Add(this.lv_QuanLy);
            this.tp_QuanLy.Location = new System.Drawing.Point(4, 31);
            this.tp_QuanLy.Name = "tp_QuanLy";
            this.tp_QuanLy.Padding = new System.Windows.Forms.Padding(3);
            this.tp_QuanLy.Size = new System.Drawing.Size(743, 479);
            this.tp_QuanLy.TabIndex = 1;
            this.tp_QuanLy.Text = "Quản lý";
            this.tp_QuanLy.UseVisualStyleBackColor = true;
            // 
            // lv_QuanLy
            // 
            this.lv_QuanLy.CheckBoxes = true;
            this.lv_QuanLy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lv_QuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_QuanLy.GridLines = true;
            this.lv_QuanLy.HideSelection = false;
            this.lv_QuanLy.Location = new System.Drawing.Point(3, 3);
            this.lv_QuanLy.Name = "lv_QuanLy";
            this.lv_QuanLy.Size = new System.Drawing.Size(737, 473);
            this.lv_QuanLy.TabIndex = 1;
            this.lv_QuanLy.UseCompatibleStateImageBehavior = false;
            this.lv_QuanLy.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã nhân viên";
            this.columnHeader5.Width = 194;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Họ tên";
            this.columnHeader6.Width = 121;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "UserName";
            this.columnHeader7.Width = 152;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mật khẩu";
            this.columnHeader8.Width = 288;
            // 
            // tp_All
            // 
            this.tp_All.Controls.Add(this.lv_All);
            this.tp_All.Location = new System.Drawing.Point(4, 31);
            this.tp_All.Name = "tp_All";
            this.tp_All.Padding = new System.Windows.Forms.Padding(3);
            this.tp_All.Size = new System.Drawing.Size(743, 479);
            this.tp_All.TabIndex = 2;
            this.tp_All.Text = "Tất cả";
            this.tp_All.UseVisualStyleBackColor = true;
            // 
            // lv_All
            // 
            this.lv_All.CheckBoxes = true;
            this.lv_All.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lv_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_All.GridLines = true;
            this.lv_All.HideSelection = false;
            this.lv_All.Location = new System.Drawing.Point(3, 3);
            this.lv_All.Name = "lv_All";
            this.lv_All.Size = new System.Drawing.Size(737, 473);
            this.lv_All.TabIndex = 1;
            this.lv_All.UseCompatibleStateImageBehavior = false;
            this.lv_All.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mã nhân viên";
            this.columnHeader9.Width = 194;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Họ tên";
            this.columnHeader10.Width = 121;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "UserName";
            this.columnHeader11.Width = 152;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Mật khẩu";
            this.columnHeader12.Width = 288;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.btn_ThongTinCaNhan);
            this.panelInput.Controls.Add(this.txt_MaNV);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.btn_Luu);
            this.panelInput.Controls.Add(this.cb_Role);
            this.panelInput.Controls.Add(this.lblRole);
            this.panelInput.Controls.Add(this.txt_MatKhau);
            this.panelInput.Controls.Add(this.lblPassword);
            this.panelInput.Controls.Add(this.txt_UserName);
            this.panelInput.Controls.Add(this.lblUserName);
            this.panelInput.Controls.Add(this.txt_HoTen);
            this.panelInput.Controls.Add(this.lblHoTen);
            this.panelInput.Location = new System.Drawing.Point(770, 118);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(289, 375);
            this.panelInput.TabIndex = 2;
            // 
            // btn_ThongTinCaNhan
            // 
            this.btn_ThongTinCaNhan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTinCaNhan.Location = new System.Drawing.Point(54, 312);
            this.btn_ThongTinCaNhan.Name = "btn_ThongTinCaNhan";
            this.btn_ThongTinCaNhan.Size = new System.Drawing.Size(185, 44);
            this.btn_ThongTinCaNhan.TabIndex = 16;
            this.btn_ThongTinCaNhan.Text = "Thông tin cá nhân";
            this.btn_ThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btn_ThongTinCaNhan.Click += new System.EventHandler(this.btn_ThongTinCaNhan_Click);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(120, 38);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(150, 25);
            this.txt_MaNV.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã nhân viên:";
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_TroVe.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe.ForeColor = System.Drawing.Color.White;
            this.btn_TroVe.Location = new System.Drawing.Point(979, 13);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(75, 29);
            this.btn_TroVe.TabIndex = 13;
            this.btn_TroVe.Text = "Trở về";
            this.btn_TroVe.UseVisualStyleBackColor = false;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(105, 262);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 29);
            this.btn_Luu.TabIndex = 11;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            // 
            // cb_Role
            // 
            this.cb_Role.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.cb_Role.Location = new System.Drawing.Point(120, 192);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(150, 25);
            this.cb_Role.TabIndex = 7;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(14, 198);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(62, 19);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Quyền:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(120, 152);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(150, 25);
            this.txt_MatKhau.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(14, 158);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(120, 112);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(150, 25);
            this.txt_UserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(14, 118);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(89, 19);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username:";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(120, 74);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(150, 25);
            this.txt_HoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(14, 80);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(64, 19);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.btn_TimKiem.Location = new System.Drawing.Point(472, 12);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(104, 29);
            this.btn_TimKiem.TabIndex = 4;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(12, 12);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(454, 30);
            this.txt_TimKiem.TabIndex = 3;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 612);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.btn_TroVe);
            this.Controls.Add(this.tc_NhanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_NhanVien";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            this.tc_NhanVien.ResumeLayout(false);
            this.tp_NhanVien.ResumeLayout(false);
            this.tp_QuanLy.ResumeLayout(false);
            this.tp_All.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc_NhanVien;
        private System.Windows.Forms.TabPage tp_NhanVien;
        private System.Windows.Forms.TabPage tp_QuanLy;
        private System.Windows.Forms.TabPage tp_All;
        private System.Windows.Forms.ListView lv_NhanVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lv_QuanLy;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lv_All;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.ComboBox cb_Role;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_ThongTinCaNhan;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
    }
}
namespace QLCuaHang
{
    partial class frm_KhachHang
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
            this.lv_KhachHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.lbl_SĐT = new System.Windows.Forms.Label();
            this.lbl_DiemTichLuy = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.mtxt_SĐT = new System.Windows.Forms.MaskedTextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_KhachHang
            // 
            this.lv_KhachHang.CheckBoxes = true;
            this.lv_KhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_KhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_KhachHang.GridLines = true;
            this.lv_KhachHang.HideSelection = false;
            this.lv_KhachHang.Location = new System.Drawing.Point(13, 48);
            this.lv_KhachHang.Name = "lv_KhachHang";
            this.lv_KhachHang.Size = new System.Drawing.Size(746, 514);
            this.lv_KhachHang.TabIndex = 0;
            this.lv_KhachHang.UseCompatibleStateImageBehavior = false;
            this.lv_KhachHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã khách hàng";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên khách hàng";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số điện thoại";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Điểm tích lũy";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Loại khách hàng";
            this.columnHeader5.Width = 181;
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
            this.btn_TimKiem.TabIndex = 5;
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
            this.txt_TimKiem.TabIndex = 4;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(7, 107);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(42, 19);
            this.lbl_HoTen.TabIndex = 0;
            this.lbl_HoTen.Text = "Tên:";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(124, 101);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(150, 25);
            this.txt_TenKH.TabIndex = 1;
            // 
            // lbl_SĐT
            // 
            this.lbl_SĐT.AutoSize = true;
            this.lbl_SĐT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SĐT.Location = new System.Drawing.Point(7, 145);
            this.lbl_SĐT.Name = "lbl_SĐT";
            this.lbl_SĐT.Size = new System.Drawing.Size(45, 19);
            this.lbl_SĐT.TabIndex = 2;
            this.lbl_SĐT.Text = "SĐT:";
            // 
            // lbl_DiemTichLuy
            // 
            this.lbl_DiemTichLuy.AutoSize = true;
            this.lbl_DiemTichLuy.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiemTichLuy.Location = new System.Drawing.Point(7, 185);
            this.lbl_DiemTichLuy.Name = "lbl_DiemTichLuy";
            this.lbl_DiemTichLuy.Size = new System.Drawing.Size(115, 19);
            this.lbl_DiemTichLuy.TabIndex = 4;
            this.lbl_DiemTichLuy.Text = "ĐIểm tích lũy:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(124, 179);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(150, 25);
            this.txt_MatKhau.TabIndex = 5;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(99, 271);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 29);
            this.btn_Luu.TabIndex = 11;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã khách hàng:";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKH.Location = new System.Drawing.Point(124, 65);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(150, 25);
            this.txt_MaKH.TabIndex = 15;
            // 
            // mtxt_SĐT
            // 
            this.mtxt_SĐT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_SĐT.Location = new System.Drawing.Point(124, 141);
            this.mtxt_SĐT.Mask = "(0000)\\.000\\.000";
            this.mtxt_SĐT.Name = "mtxt_SĐT";
            this.mtxt_SĐT.Size = new System.Drawing.Size(150, 25);
            this.mtxt_SĐT.TabIndex = 16;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.mtxt_SĐT);
            this.panelInput.Controls.Add(this.txt_MaKH);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.btn_Luu);
            this.panelInput.Controls.Add(this.txt_MatKhau);
            this.panelInput.Controls.Add(this.lbl_DiemTichLuy);
            this.panelInput.Controls.Add(this.lbl_SĐT);
            this.panelInput.Controls.Add(this.txt_TenKH);
            this.panelInput.Controls.Add(this.lbl_HoTen);
            this.panelInput.Location = new System.Drawing.Point(765, 114);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(289, 375);
            this.panelInput.TabIndex = 3;
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 574);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.btn_TroVe);
            this.Controls.Add(this.lv_KhachHang);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_KhachHang";
            this.Text = "frm_KhachHang";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_KhachHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label lbl_SĐT;
        private System.Windows.Forms.Label lbl_DiemTichLuy;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.MaskedTextBox mtxt_SĐT;
        private System.Windows.Forms.Panel panelInput;
    }
}
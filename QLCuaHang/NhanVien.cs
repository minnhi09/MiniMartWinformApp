using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang
{
    public class NhanVien
    {
        public int MaNV {  get; set; }
        public string TenNV {  get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }

        public NhanVien()
        {

        }

        public NhanVien(int maNV, string tenNV, string userName, string password, UserRole role)
        {
            MaNV = maNV;
            TenNV = tenNV;
            UserName = userName;
            Password = password;
            Role = role;
        }

        // Constructor tương thích ngược với string role
        public NhanVien(int maNV, string tenNV, string userName, string password, string roleString)
        {
            MaNV = maNV;
            TenNV = tenNV;
            UserName = userName;
            Password = password;
            
            // Chuyển đổi string thành enum
            if (roleString.ToLower().Contains("quản lý") || roleString.ToLower().Contains("admin"))
                Role = UserRole.Admin;
            else
                Role = UserRole.NhanVien;
        }

        public string GetRoleDisplayName()
        {
            return Role == UserRole.Admin ? "Quản lý" : "Nhân viên";
        }

        public bool IsAdmin()
        {
            return Role == UserRole.Admin;
        }
    }
}

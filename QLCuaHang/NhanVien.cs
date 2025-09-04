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
        public string Role {  get; set; }

        public NhanVien()
        {

        }

        public NhanVien(int maNV, string tenNV, string userName, string password, string role)
        {
            MaNV = maNV;
            TenNV = tenNV;
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}

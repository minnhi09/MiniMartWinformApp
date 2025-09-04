using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang
{
    public class KhachHang
    {
        public int MaKH {  get; set; }
        public string TenKH {  get; set; }
        public string SĐT {  get; set; }
        public int DiemTichLuy {  get; set; }
        public string LoaiKH {  get; set; }

        public KhachHang()
        {
            
        }

        public KhachHang(int maKH, string tenKH, string sĐT, int diemTichLuy)
        {
            MaKH = maKH;
            TenKH = tenKH;
            SĐT = sĐT;
            DiemTichLuy = diemTichLuy;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang
{
    public class HangHoa
    {
        public int MaHH {  get; set; }
        public string TenHH {  get; set; }
        public int SoLuong {  get; set; }
        public string DonViTinh {  get; set; }
        public decimal DonGia {  get; set; }
        public string NhaCC {  get; set; }
        public string Notes {  get; set; }

        public HangHoa()
        {
            
        }

        public HangHoa(int maHH, string tenHH, int soLuong, string donViTinh, decimal donGia, string nhaCC, string notes)
        {
            MaHH = maHH;
            TenHH = tenHH;
            SoLuong = soLuong;
            DonViTinh = donViTinh;
            DonGia = donGia;
            NhaCC = nhaCC;
            Notes = notes;
        }
    }
}

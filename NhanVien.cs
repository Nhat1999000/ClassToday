using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToday
{
    public class NhanVien : Nguoi
    {
        // Thuộc tính của lớp NhanVien
        public string MSNV { get; set; }
        public double Luong { get; set; }
        public string ChucVu { get; set; }

        // Hàm khởi tạo
        public NhanVien(string hoTen, DateTime ngaySinh, string gioiTinh, string msnv, double luong, string chucVu)
            : base(hoTen, ngaySinh, gioiTinh)
        {
            MSNV = msnv;
            Luong = luong;
            ChucVu = chucVu;
        }
    }
}

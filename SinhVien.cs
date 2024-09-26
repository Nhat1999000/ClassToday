using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToday
{
    public class SinhVien : Nguoi
    {
        // Thuộc tính của lớp SinhVien
        public string MSSV { get; set; }
        public string NganhHoc { get; set; }
        public double DiemTrungBinh { get; set; }

        // Hàm khởi tạo
        public SinhVien(string hoTen, DateTime ngaySinh, string gioiTinh, string mssv, string nganhHoc, double diemTrungBinh)
            : base(hoTen, ngaySinh, gioiTinh)
        {
            MSSV = mssv;
            NganhHoc = nganhHoc;
            DiemTrungBinh = diemTrungBinh;
        }
       
    }

}

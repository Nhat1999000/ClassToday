using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToday
{
    
    public class Nguoi
    {
        // Thuộc tính của lớp Nguoi
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }

        // Hàm khởi tạo
        public Nguoi(string hoTen, DateTime ngaySinh, string gioiTinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
        }
    }
}

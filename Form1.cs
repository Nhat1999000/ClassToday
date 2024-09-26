using System.Windows.Forms;

namespace ClassToday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private List<Nguoi> danhSachNguoi = new List<Nguoi>();
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        private List<NhanVien> danhSachNhanVien = new List<NhanVien>();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                var selectedNV = danhSachNhanVien[dataGridView3.SelectedRows[0].Index];
                selectedNV.MSNV = txtMSNV.Text;
                selectedNV.Luong = double.Parse(txtLuong.Text);
                selectedNV.ChucVu = txtChucVu.Text;
                selectedNV.HoTen = txtHoTenNguoi.Text;
                selectedNV.NgaySinh = dtpNgaySinhNguoi.Value;
                selectedNV.GioiTinh = txtGioiTinhNguoi.Text;
                UpdateDataGridViewNhanVien();
            }
        }
        private void UpdateDataGridViewNhanVien()
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = danhSachNhanVien;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // LỚP NGƯỜI
        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            Nguoi nguoi = new Nguoi(txtHoTenNguoi.Text, dtpNgaySinhNguoi.Value, txtGioiTinhNguoi.Text);
            danhSachNguoi.Add(nguoi);
            HienThiDanhSachNguoi();
        }

        private void btnXoaNguoi_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                danhSachNguoi.RemoveAt(dataGridView1.CurrentRow.Index);
                HienThiDanhSachNguoi();
            }
        }
        private void HienThiDanhSachNguoi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachNguoi;
        }

        // LỚP SINH VIÊN
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien(txtHoTenNguoi.Text, dtpNgaySinhNguoi.Value, txtGioiTinhNguoi.Text, txtMSSV.Text, txtNganhHoc.Text, double.Parse(txtDiemTrungBinh.Text));
            danhSachSinhVien.Add(sv);
            HienThiDanhSachSinhVien();
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                danhSachSinhVien.RemoveAt(dataGridView2.CurrentRow.Index);
                HienThiDanhSachSinhVien();
            }
        }
        private void HienThiDanhSachSinhVien()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = danhSachSinhVien;
        }
        // LỚP NHÂN VIÊN
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            var nhanVien = new NhanVien(txtHoTenNguoi.Text, dtpNgaySinhNguoi.Value, txtGioiTinhNguoi.Text, txtMSNV.Text, Convert.ToDouble(txtLuong.Text), txtChucVu.Text);
            danhSachNhanVien.Add(nhanVien);
            HienThiDanhSachNhanVien();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            

            if (dataGridView3.CurrentRow != null)
            {
                danhSachNhanVien.RemoveAt(dataGridView3.CurrentRow.Index);
                HienThiDanhSachNhanVien();
            }
        }
        private void HienThiDanhSachNhanVien()
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = danhSachNhanVien;
        }
        // NÚT SỬA SV
        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var selectedSV = danhSachSinhVien[dataGridView2.SelectedRows[0].Index];
                selectedSV.MSSV = txtMSSV.Text;
                selectedSV.NganhHoc = txtNganhHoc.Text;
                selectedSV.DiemTrungBinh = double.Parse(txtDiemTrungBinh.Text);
                selectedSV.HoTen = txtHoTenNguoi.Text;
                selectedSV.NgaySinh = dtpNgaySinhNguoi.Value;
                selectedSV.GioiTinh = txtGioiTinhNguoi.Text;
                UpdateDataGridViewSinhVien();
            }
        }
        private void UpdateDataGridViewSinhVien()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = danhSachSinhVien;
        }
        // Sửa Người
        private void btnSuaNguoi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedNguoi = danhSachNguoi[dataGridView1.SelectedRows[0].Index];
                selectedNguoi.HoTen = txtHoTenNguoi.Text;
                selectedNguoi.NgaySinh = dtpNgaySinhNguoi.Value;
                selectedNguoi.GioiTinh = txtGioiTinhNguoi.Text;
                UpdateDataGridViewNguoi();
            }
        }
        private void UpdateDataGridViewNguoi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachNguoi;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            
            var nguoiKQ = danhSachNguoi.Where(n => n.HoTen.ToLower().Contains(searchTerm)).ToList();
            var sinhVienKQ = danhSachSinhVien.Where(sv => sv.HoTen.ToLower().Contains(searchTerm) || sv.MSSV.ToLower().Contains(searchTerm)).ToList();
            var nhanVienKQ = danhSachNhanVien.Where(nv => nv.HoTen.ToLower().Contains(searchTerm) || nv.MSNV.ToLower().Contains(searchTerm)).ToList();

            dataGridView1.DataSource = nguoiKQ;
            dataGridView2.DataSource = sinhVienKQ;
            dataGridView3.DataSource = nhanVienKQ;
        }
    }
}

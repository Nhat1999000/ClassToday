namespace ClassToday
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            btnSuaNguoi = new Button();
            btnXoaNguoi = new Button();
            btnThemNguoi = new Button();
            dtpNgaySinhNguoi = new DateTimePicker();
            txtGioiTinhNguoi = new TextBox();
            txtHoTenNguoi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            btnSuaSV = new Button();
            btnXoaSV = new Button();
            btnThemSV = new Button();
            txtDiemTrungBinh = new TextBox();
            txtNganhHoc = new TextBox();
            txtMSSV = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            dataGridView3 = new DataGridView();
            btnSuaNV = new Button();
            btnXoaNV = new Button();
            btnThemNV = new Button();
            txtChucVu = new TextBox();
            txtLuong = new TextBox();
            txtMSNV = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnSuaNguoi);
            panel1.Controls.Add(btnXoaNguoi);
            panel1.Controls.Add(btnThemNguoi);
            panel1.Controls.Add(dtpNgaySinhNguoi);
            panel1.Controls.Add(txtGioiTinhNguoi);
            panel1.Controls.Add(txtHoTenNguoi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 461);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 273);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(347, 188);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSuaNguoi
            // 
            btnSuaNguoi.Location = new Point(243, 217);
            btnSuaNguoi.Name = "btnSuaNguoi";
            btnSuaNguoi.Size = new Size(94, 29);
            btnSuaNguoi.TabIndex = 8;
            btnSuaNguoi.Text = "SỬA";
            btnSuaNguoi.UseVisualStyleBackColor = true;
            btnSuaNguoi.Click += btnSuaNguoi_Click;
            // 
            // btnXoaNguoi
            // 
            btnXoaNguoi.Location = new Point(129, 216);
            btnXoaNguoi.Name = "btnXoaNguoi";
            btnXoaNguoi.Size = new Size(94, 29);
            btnXoaNguoi.TabIndex = 7;
            btnXoaNguoi.Text = "XÓA";
            btnXoaNguoi.UseVisualStyleBackColor = true;
            btnXoaNguoi.Click += btnXoaNguoi_Click;
            // 
            // btnThemNguoi
            // 
            btnThemNguoi.Location = new Point(14, 217);
            btnThemNguoi.Name = "btnThemNguoi";
            btnThemNguoi.Size = new Size(94, 29);
            btnThemNguoi.TabIndex = 6;
            btnThemNguoi.Text = "THÊM";
            btnThemNguoi.UseVisualStyleBackColor = true;
            btnThemNguoi.Click += btnThemNguoi_Click;
            // 
            // dtpNgaySinhNguoi
            // 
            dtpNgaySinhNguoi.Location = new Point(126, 95);
            dtpNgaySinhNguoi.Name = "dtpNgaySinhNguoi";
            dtpNgaySinhNguoi.Size = new Size(186, 27);
            dtpNgaySinhNguoi.TabIndex = 5;
            // 
            // txtGioiTinhNguoi
            // 
            txtGioiTinhNguoi.Location = new Point(126, 157);
            txtGioiTinhNguoi.Name = "txtGioiTinhNguoi";
            txtGioiTinhNguoi.Size = new Size(186, 27);
            txtGioiTinhNguoi.TabIndex = 4;
            // 
            // txtHoTenNguoi
            // 
            txtHoTenNguoi.Location = new Point(126, 32);
            txtHoTenNguoi.Name = "txtHoTenNguoi";
            txtHoTenNguoi.Size = new Size(186, 27);
            txtHoTenNguoi.TabIndex = 3;
            txtHoTenNguoi.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 157);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Gioi Tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 95);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày Sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 35);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ Và Tên";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(btnSuaSV);
            panel2.Controls.Add(btnXoaSV);
            panel2.Controls.Add(btnThemSV);
            panel2.Controls.Add(txtDiemTrungBinh);
            panel2.Controls.Add(txtNganhHoc);
            panel2.Controls.Add(txtMSSV);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(385, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 461);
            panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 270);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(347, 188);
            dataGridView2.TabIndex = 10;
            // 
            // btnSuaSV
            // 
            btnSuaSV.Location = new Point(244, 217);
            btnSuaSV.Name = "btnSuaSV";
            btnSuaSV.Size = new Size(94, 29);
            btnSuaSV.TabIndex = 11;
            btnSuaSV.Text = "SỬA";
            btnSuaSV.UseVisualStyleBackColor = true;
            btnSuaSV.Click += btnSuaSV_Click;
            // 
            // btnXoaSV
            // 
            btnXoaSV.Location = new Point(131, 216);
            btnXoaSV.Name = "btnXoaSV";
            btnXoaSV.Size = new Size(94, 29);
            btnXoaSV.TabIndex = 10;
            btnXoaSV.Text = "XÓA";
            btnXoaSV.UseVisualStyleBackColor = true;
            btnXoaSV.Click += btnXoaSV_Click;
            // 
            // btnThemSV
            // 
            btnThemSV.Location = new Point(23, 216);
            btnThemSV.Name = "btnThemSV";
            btnThemSV.Size = new Size(94, 29);
            btnThemSV.TabIndex = 9;
            btnThemSV.Text = "THÊM";
            btnThemSV.UseVisualStyleBackColor = true;
            btnThemSV.Click += btnThemSV_Click;
            // 
            // txtDiemTrungBinh
            // 
            txtDiemTrungBinh.Location = new Point(152, 154);
            txtDiemTrungBinh.Name = "txtDiemTrungBinh";
            txtDiemTrungBinh.Size = new Size(186, 27);
            txtDiemTrungBinh.TabIndex = 7;
            // 
            // txtNganhHoc
            // 
            txtNganhHoc.Location = new Point(152, 92);
            txtNganhHoc.Name = "txtNganhHoc";
            txtNganhHoc.Size = new Size(186, 27);
            txtNganhHoc.TabIndex = 6;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(152, 32);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(186, 27);
            txtMSSV.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 157);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 2;
            label6.Text = "Điểm Trung Bình";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 95);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 1;
            label5.Text = "Ngành Học";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 35);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 0;
            label4.Text = "MSSV";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView3);
            panel3.Controls.Add(btnSuaNV);
            panel3.Controls.Add(btnXoaNV);
            panel3.Controls.Add(btnThemNV);
            panel3.Controls.Add(txtChucVu);
            panel3.Controls.Add(txtLuong);
            panel3.Controls.Add(txtMSNV);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(756, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 461);
            panel3.TabIndex = 2;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(3, 270);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(357, 188);
            dataGridView3.TabIndex = 12;
            // 
            // btnSuaNV
            // 
            btnSuaNV.Location = new Point(250, 216);
            btnSuaNV.Name = "btnSuaNV";
            btnSuaNV.Size = new Size(94, 29);
            btnSuaNV.TabIndex = 14;
            btnSuaNV.Text = "SỬA";
            btnSuaNV.UseVisualStyleBackColor = true;
            btnSuaNV.Click += button9_Click;
            // 
            // btnXoaNV
            // 
            btnXoaNV.Location = new Point(134, 216);
            btnXoaNV.Name = "btnXoaNV";
            btnXoaNV.Size = new Size(94, 29);
            btnXoaNV.TabIndex = 13;
            btnXoaNV.Text = "XÓA";
            btnXoaNV.UseVisualStyleBackColor = true;
            btnXoaNV.Click += btnXoaNV_Click;
            // 
            // btnThemNV
            // 
            btnThemNV.Location = new Point(19, 216);
            btnThemNV.Name = "btnThemNV";
            btnThemNV.Size = new Size(94, 29);
            btnThemNV.TabIndex = 12;
            btnThemNV.Text = "THÊM";
            btnThemNV.UseVisualStyleBackColor = true;
            btnThemNV.Click += btnThemNV_Click;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(118, 154);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(186, 27);
            txtChucVu.TabIndex = 10;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(118, 92);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(186, 27);
            txtLuong.TabIndex = 9;
            // 
            // txtMSNV
            // 
            txtMSNV.Location = new Point(118, 32);
            txtMSNV.Name = "txtMSNV";
            txtMSNV.Size = new Size(186, 27);
            txtMSNV.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 157);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 2;
            label9.Text = "Chức Vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 95);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 1;
            label8.Text = "Lương";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 35);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 0;
            label7.Text = "MSNV";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(361, 505);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(485, 506);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(317, 27);
            txtSearch.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 546);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtHoTenNguoi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnSuaNguoi;
        private Button btnXoaNguoi;
        private Button btnThemNguoi;
        private DateTimePicker dtpNgaySinhNguoi;
        private TextBox txtGioiTinhNguoi;
        private Button btnSuaSV;
        private Button btnXoaSV;
        private Button btnThemSV;
        private TextBox txtDiemTrungBinh;
        private TextBox txtNganhHoc;
        private TextBox txtMSSV;
        private Button btnSuaNV;
        private Button btnXoaNV;
        private Button btnThemNV;
        private TextBox txtChucVu;
        private TextBox txtLuong;
        private TextBox txtMSNV;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}

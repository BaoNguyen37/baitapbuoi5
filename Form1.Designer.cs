namespace WinFormsApp5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblHoTen = new Label();
            lblDiem = new Label();
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTaiLai = new Button();
            btnLocDat = new Button();
            dgvSinhVien = new DataGridView();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();

            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.Location = new Point(110, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Text = "QUẢN LÝ SINH VIÊN - EF CORE (CRUD ĐẦY ĐỦ)";

            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(30, 65);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Text = "Họ tên:";

            txtHoTen.Location = new Point(90, 62);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(280, 27);

            lblDiem.AutoSize = true;
            lblDiem.Location = new Point(400, 65);
            lblDiem.Name = "lblDiem";
            lblDiem.Text = "Điểm:";

            txtDiem.Location = new Point(455, 62);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(100, 27);

            btnThem.Location = new Point(30, 105);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 35);
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;

            btnSua.Location = new Point(140, 105);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 35);
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;

            btnXoa.Location = new Point(250, 105);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            btnTaiLai.Location = new Point(360, 105);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(120, 35);
            btnTaiLai.Text = "Tải lại danh sách";
            btnTaiLai.Click += btnTaiLai_Click;

            btnLocDat.Location = new Point(490, 105);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(130, 35);
            btnLocDat.Text = "Lọc SV đạt (LINQ)";
            btnLocDat.Click += btnLocDat_Click;

            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(30, 155);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(590, 230);
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;

            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(30, 400);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Text = "Trạng thái";

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 440);
            Controls.Add(lblTieuDe);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblDiem);
            Controls.Add(txtDiem);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnTaiLai);
            Controls.Add(btnLocDat);
            Controls.Add(dgvSinhVien);
            Controls.Add(lblTrangThai);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên - EF Core CRUD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTieuDe;
        private Label lblHoTen;
        private Label lblDiem;
        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTaiLai;
        private Button btnLocDat;
        private DataGridView dgvSinhVien;
        private Label lblTrangThai;
    }
}

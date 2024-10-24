using System.Windows.Forms;

namespace LNBT
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTaiKhoan = new System.Windows.Forms.TabPage();
            this.panel22 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblLoaiTaiKhoan = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.lblTenHienThi = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.txtTenTk = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dtgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnXemTaiKhoan = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.tabDanhMuc = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dtgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnXemDanhMuc = new System.Windows.Forms.Button();
            this.btnSuaDanhMuc = new System.Windows.Forms.Button();
            this.btnXoaDanhMuc = new System.Windows.Forms.Button();
            this.btnThemDanhMuc = new System.Windows.Forms.Button();
            this.tabDoUong = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnTimDoUong = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXemDoUong = new System.Windows.Forms.Button();
            this.btnSuaDoUong = new System.Windows.Forms.Button();
            this.btnXoaDoUong = new System.Windows.Forms.Button();
            this.btnThemDoUong = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmGia = new System.Windows.Forms.NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnQuaTrang = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPage = new System.Windows.Forms.NumericUpDown();
            this.page = new System.Windows.Forms.NumericUpDown();
            this.dtpkTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtpkDenNgay = new System.Windows.Forms.DateTimePicker();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.dtgvDoUong = new System.Windows.Forms.DataGridView();
            this.tabTaiKhoan.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).BeginInit();
            this.panel13.SuspendLayout();
            this.tabDanhMuc.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMuc)).BeginInit();
            this.panel11.SuspendLayout();
            this.tabDoUong.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGia)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dtgvDoUong)).BeginInit();
            this.tabDoanhThu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaSanPham
            // 
            this.MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            // 
            // TenSanPham
            // 
            this.TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.TenSanPham.Name = "TenSanPham";
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá Tiền";
            this.Gia.Name = "Gia";
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.HeaderText = "Loại Sản Phẩm";
            this.TenDanhMuc.Name = "TenDanhMuc";
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // Mota
            // 
            this.Mota.HeaderText = "Mô Tả";
            this.Mota.Name = "Mota";
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.HeaderText = "Khuyến Mãi";
            this.KhuyenMai.Name = "KhuyenMai";
            // 
            // tabTaiKhoan
            // 
            this.tabTaiKhoan.Controls.Add(this.panel22);
            this.tabTaiKhoan.Controls.Add(this.panel21);
            this.tabTaiKhoan.Controls.Add(this.panel19);
            this.tabTaiKhoan.Controls.Add(this.panel17);
            this.tabTaiKhoan.Controls.Add(this.panel18);
            this.tabTaiKhoan.Controls.Add(this.panel16);
            this.tabTaiKhoan.Controls.Add(this.panel13);
            this.tabTaiKhoan.Location = new System.Drawing.Point(4, 22);
            this.tabTaiKhoan.Name = "tabTaiKhoan";
            this.tabTaiKhoan.Size = new System.Drawing.Size(950, 542);
            this.tabTaiKhoan.TabIndex = 3;
            this.tabTaiKhoan.Text = "Tài Khoản";
            this.tabTaiKhoan.UseVisualStyleBackColor = true;
            this.tabTaiKhoan.Click += new System.EventHandler(this.tabTaiKhoan_Click);
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.txtEmail);
            this.panel22.Controls.Add(this.lbEmail);
            this.panel22.Location = new System.Drawing.Point(561, 174);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(381, 40);
            this.panel22.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(123, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 30);
            this.txtEmail.TabIndex = 7;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(3, 14);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(54, 16);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email :";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.txtMatKhau);
            this.panel21.Controls.Add(this.lbMatKhau);
            this.panel21.Location = new System.Drawing.Point(561, 220);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(381, 40);
            this.panel21.TabIndex = 15;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(123, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(255, 30);
            this.txtMatKhau.TabIndex = 7;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(3, 14);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(69, 16);
            this.lbMatKhau.TabIndex = 6;
            this.lbMatKhau.Text = "Mật khẩu";
            this.lbMatKhau.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.cbRole);
            this.panel19.Controls.Add(this.lblLoaiTaiKhoan);
            this.panel19.Location = new System.Drawing.Point(561, 266);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(381, 40);
            this.panel19.TabIndex = 14;
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cbRole.Location = new System.Drawing.Point(123, 5);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(255, 32);
            this.cbRole.TabIndex = 7;
            // 
            // lblLoaiTaiKhoan
            // 
            this.lblLoaiTaiKhoan.AutoSize = true;
            this.lblLoaiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiTaiKhoan.Location = new System.Drawing.Point(3, 14);
            this.lblLoaiTaiKhoan.Name = "lblLoaiTaiKhoan";
            this.lblLoaiTaiKhoan.Size = new System.Drawing.Size(119, 16);
            this.lblLoaiTaiKhoan.TabIndex = 6;
            this.lblLoaiTaiKhoan.Text = "Loại Tài Khoản :";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.lblTenHienThi);
            this.panel17.Controls.Add(this.txtFullName);
            this.panel17.Location = new System.Drawing.Point(561, 128);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(381, 40);
            this.panel17.TabIndex = 13;
            // 
            // lblTenHienThi
            // 
            this.lblTenHienThi.AutoSize = true;
            this.lblTenHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHienThi.Location = new System.Drawing.Point(3, 14);
            this.lblTenHienThi.Name = "lblTenHienThi";
            this.lblTenHienThi.Size = new System.Drawing.Size(104, 16);
            this.lblTenHienThi.TabIndex = 6;
            this.lblTenHienThi.Text = "Tên Hiện Thị :";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFullName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(123, 5);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(255, 30);
            this.txtFullName.TabIndex = 4;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.lblTenTaiKhoan);
            this.panel18.Controls.Add(this.txtTenTk);
            this.panel18.Location = new System.Drawing.Point(561, 82);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(381, 40);
            this.panel18.TabIndex = 12;
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(3, 14);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(116, 16);
            this.lblTenTaiKhoan.TabIndex = 6;
            this.lblTenTaiKhoan.Text = "Tên Tài Khoản :";
            // 
            // txtTenTk
            // 
            this.txtTenTk.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTenTk.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTk.Location = new System.Drawing.Point(123, 5);
            this.txtTenTk.Name = "txtTenTk";
            this.txtTenTk.Size = new System.Drawing.Size(255, 30);
            this.txtTenTk.TabIndex = 4;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.dtgvTaiKhoan);
            this.panel16.Location = new System.Drawing.Point(7, 82);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(547, 454);
            this.panel16.TabIndex = 5;
            // 
            // dtgvTaiKhoan
            // 
            this.dtgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaiKhoan.Location = new System.Drawing.Point(3, 3);
            this.dtgvTaiKhoan.Name = "dtgvTaiKhoan";
            this.dtgvTaiKhoan.RowHeadersWidth = 51;
            this.dtgvTaiKhoan.Size = new System.Drawing.Size(541, 448);
            this.dtgvTaiKhoan.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnXemTaiKhoan);
            this.panel13.Controls.Add(this.btnEditUser);
            this.panel13.Controls.Add(this.btnXoaTaiKhoan);
            this.panel13.Controls.Add(this.btnThemTaiKhoan);
            this.panel13.Location = new System.Drawing.Point(8, 6);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(545, 70);
            this.panel13.TabIndex = 4;
            // 
            // btnXemTaiKhoan
            // 
            this.btnXemTaiKhoan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnXemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXemTaiKhoan.Location = new System.Drawing.Point(410, 3);
            this.btnXemTaiKhoan.Name = "btnXemTaiKhoan";
            this.btnXemTaiKhoan.Size = new System.Drawing.Size(92, 64);
            this.btnXemTaiKhoan.TabIndex = 3;
            this.btnXemTaiKhoan.Text = "Xem";
            this.btnXemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnXemTaiKhoan.Click += new System.EventHandler(this.btnXemTaiKhoan_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditUser.Location = new System.Drawing.Point(286, 3);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(92, 64);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Text = "Sửa";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnSuaTaiKhoan_Click);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(162, 3);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(92, 64);
            this.btnXoaTaiKhoan.TabIndex = 1;
            this.btnXoaTaiKhoan.Text = "Xóa";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = false;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(33, 3);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(92, 64);
            this.btnThemTaiKhoan.TabIndex = 0;
            this.btnThemTaiKhoan.Text = "Thêm";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.Controls.Add(this.panel14);
            this.tabDanhMuc.Controls.Add(this.panel12);
            this.tabDanhMuc.Controls.Add(this.panel11);
            this.tabDanhMuc.Location = new System.Drawing.Point(4, 22);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.Size = new System.Drawing.Size(950, 542);
            this.tabDanhMuc.TabIndex = 2;
            this.tabDanhMuc.Text = "Danh Mục";
            this.tabDanhMuc.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label1);
            this.panel14.Controls.Add(this.txtTenDanhMuc);
            this.panel14.Location = new System.Drawing.Point(559, 82);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(381, 40);
            this.panel14.TabIndex = 11;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Danh Mục :";
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(123, 5);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(255, 30);
            this.txtTenDanhMuc.TabIndex = 4;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dtgvDanhMuc);
            this.panel12.Location = new System.Drawing.Point(5, 82);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(547, 454);
            this.panel12.TabIndex = 4;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // dtgvDanhMuc
            // 
            this.dtgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhMuc.Location = new System.Drawing.Point(3, 3);
            this.dtgvDanhMuc.Name = "dtgvDanhMuc";
            this.dtgvDanhMuc.RowHeadersWidth = 51;
            this.dtgvDanhMuc.Size = new System.Drawing.Size(541, 448);
            this.dtgvDanhMuc.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnXemDanhMuc);
            this.panel11.Controls.Add(this.btnSuaDanhMuc);
            this.panel11.Controls.Add(this.btnXoaDanhMuc);
            this.panel11.Controls.Add(this.btnThemDanhMuc);
            this.panel11.Location = new System.Drawing.Point(5, 6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(545, 70);
            this.panel11.TabIndex = 3;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // btnXemDanhMuc
            // 
            this.btnXemDanhMuc.BackColor = System.Drawing.Color.Gainsboro;
            this.btnXemDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDanhMuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXemDanhMuc.Location = new System.Drawing.Point(410, 3);
            this.btnXemDanhMuc.Name = "btnXemDanhMuc";
            this.btnXemDanhMuc.Size = new System.Drawing.Size(92, 64);
            this.btnXemDanhMuc.TabIndex = 3;
            this.btnXemDanhMuc.Text = "Xem";
            this.btnXemDanhMuc.UseVisualStyleBackColor = false;
            this.btnXemDanhMuc.Click += new System.EventHandler(this.btnXemDanhMuc_Click);
            // 
            // btnSuaDanhMuc
            // 
            this.btnSuaDanhMuc.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSuaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDanhMuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuaDanhMuc.Location = new System.Drawing.Point(286, 3);
            this.btnSuaDanhMuc.Name = "btnSuaDanhMuc";
            this.btnSuaDanhMuc.Size = new System.Drawing.Size(92, 64);
            this.btnSuaDanhMuc.TabIndex = 2;
            this.btnSuaDanhMuc.Text = "Sửa";
            this.btnSuaDanhMuc.UseVisualStyleBackColor = false;
            this.btnSuaDanhMuc.Click += new System.EventHandler(this.btnSuaDanhMuc_Click);
            // 
            // btnXoaDanhMuc
            // 
            this.btnXoaDanhMuc.BackColor = System.Drawing.Color.Gainsboro;
            this.btnXoaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDanhMuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaDanhMuc.Location = new System.Drawing.Point(162, 3);
            this.btnXoaDanhMuc.Name = "btnXoaDanhMuc";
            this.btnXoaDanhMuc.Size = new System.Drawing.Size(92, 64);
            this.btnXoaDanhMuc.TabIndex = 1;
            this.btnXoaDanhMuc.Text = "Xóa";
            this.btnXoaDanhMuc.UseVisualStyleBackColor = false;
            this.btnXoaDanhMuc.Click += new System.EventHandler(this.btnXoaDanhMuc_Click);
            // 
            // btnThemDanhMuc
            // 
            this.btnThemDanhMuc.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThemDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDanhMuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemDanhMuc.Location = new System.Drawing.Point(33, 3);
            this.btnThemDanhMuc.Name = "btnThemDanhMuc";
            this.btnThemDanhMuc.Size = new System.Drawing.Size(92, 64);
            this.btnThemDanhMuc.TabIndex = 0;
            this.btnThemDanhMuc.Text = "Thêm";
            this.btnThemDanhMuc.UseVisualStyleBackColor = false;
            this.btnThemDanhMuc.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // tabDoUong
            // 
            this.tabDoUong.Controls.Add(this.panel6);
            this.tabDoUong.Controls.Add(this.panel5);
            this.tabDoUong.Controls.Add(this.panel4);
            this.tabDoUong.Controls.Add(this.panel3);
            this.tabDoUong.Location = new System.Drawing.Point(4, 22);
            this.tabDoUong.Name = "tabDoUong";
            this.tabDoUong.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoUong.Size = new System.Drawing.Size(950, 542);
            this.tabDoUong.TabIndex = 1;
            this.tabDoUong.Text = "Đồ Uống";
            this.tabDoUong.UseVisualStyleBackColor = true;
            this.tabDoUong.Enter += new System.EventHandler(this.tabDoUong_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnTimDoUong);
            this.panel6.Controls.Add(this.txtTim);
            this.panel6.Location = new System.Drawing.Point(559, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(381, 70);
            this.panel6.TabIndex = 3;
            // 
            // btnTimDoUong
            // 
            this.btnTimDoUong.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTimDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimDoUong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimDoUong.Location = new System.Drawing.Point(273, 3);
            this.btnTimDoUong.Name = "btnTimDoUong";
            this.btnTimDoUong.Size = new System.Drawing.Size(105, 64);
            this.btnTimDoUong.TabIndex = 9;
            this.btnTimDoUong.Text = "Tìm";
            this.btnTimDoUong.UseVisualStyleBackColor = false;
            this.btnTimDoUong.Click += new System.EventHandler(this.find_product);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(3, 21);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(264, 26);
            this.txtTim.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnXemDoUong);
            this.panel5.Controls.Add(this.btnSuaDoUong);
            this.panel5.Controls.Add(this.btnXoaDoUong);
            this.panel5.Controls.Add(this.btnThemDoUong);
            this.panel5.Location = new System.Drawing.Point(8, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(545, 70);
            this.panel5.TabIndex = 2;
            // 
            // btnXemDoUong
            // 
            this.btnXemDoUong.BackColor = System.Drawing.Color.Gainsboro;
            this.btnXemDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDoUong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXemDoUong.Location = new System.Drawing.Point(410, 3);
            this.btnXemDoUong.Name = "btnXemDoUong";
            this.btnXemDoUong.Size = new System.Drawing.Size(92, 64);
            this.btnXemDoUong.TabIndex = 3;
            this.btnXemDoUong.Text = "Xem";
            this.btnXemDoUong.UseVisualStyleBackColor = false;
            this.btnXemDoUong.Click += new System.EventHandler(this.view_all_product);
            // 
            // btnSuaDoUong
            // 
            this.btnSuaDoUong.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSuaDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDoUong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuaDoUong.Location = new System.Drawing.Point(286, 3);
            this.btnSuaDoUong.Name = "btnSuaDoUong";
            this.btnSuaDoUong.Size = new System.Drawing.Size(92, 64);
            this.btnSuaDoUong.TabIndex = 2;
            this.btnSuaDoUong.Text = "Sửa";
            this.btnSuaDoUong.UseVisualStyleBackColor = false;
            this.btnSuaDoUong.Click += new System.EventHandler(this.update_product);
            // 
            // btnXoaDoUong
            // 
            this.btnXoaDoUong.BackColor = System.Drawing.Color.Gainsboro;
            this.btnXoaDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDoUong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaDoUong.Location = new System.Drawing.Point(162, 3);
            this.btnXoaDoUong.Name = "btnXoaDoUong";
            this.btnXoaDoUong.Size = new System.Drawing.Size(92, 64);
            this.btnXoaDoUong.TabIndex = 1;
            this.btnXoaDoUong.Text = "Xóa";
            this.btnXoaDoUong.UseVisualStyleBackColor = false;
            this.btnXoaDoUong.Click += new System.EventHandler(this.delete_product);
            // 
            // btnThemDoUong
            // 
            this.btnThemDoUong.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThemDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDoUong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemDoUong.Location = new System.Drawing.Point(33, 3);
            this.btnThemDoUong.Name = "btnThemDoUong";
            this.btnThemDoUong.Size = new System.Drawing.Size(92, 64);
            this.btnThemDoUong.TabIndex = 0;
            this.btnThemDoUong.Text = "Thêm";
            this.btnThemDoUong.UseVisualStyleBackColor = false;
            this.btnThemDoUong.Click += new System.EventHandler(this.add_product);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel20);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(559, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 454);
            this.panel4.TabIndex = 1;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.lblTrangThai);
            this.panel20.Controls.Add(this.txtTrangThai);
            this.panel20.Location = new System.Drawing.Point(0, 187);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(378, 40);
            this.panel20.TabIndex = 12;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(3, 14);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(91, 16);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng Thái :";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTrangThai.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(107, 5);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(268, 30);
            this.txtTrangThai.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmGia);
            this.panel10.Controls.Add(this.lblGia);
            this.panel10.Location = new System.Drawing.Point(3, 141);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(378, 40);
            this.panel10.TabIndex = 11;
            // 
            // nmGia
            // 
            this.nmGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmGia.Location = new System.Drawing.Point(104, 9);
            this.nmGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmGia.Name = "nmGia";
            this.nmGia.Size = new System.Drawing.Size(271, 26);
            this.nmGia.TabIndex = 12;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(3, 14);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(39, 16);
            this.lblGia.TabIndex = 6;
            this.lblGia.Text = "Giá :";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblTenMon);
            this.panel8.Controls.Add(this.txtTenMon);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(381, 40);
            this.panel8.TabIndex = 9;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(3, 14);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(75, 16);
            this.lblTenMon.TabIndex = 6;
            this.lblTenMon.Text = "Tên Món :";
            // 
            // txtTenMon
            // 
            this.txtTenMon.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTenMon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(107, 5);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(268, 30);
            this.txtTenMon.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbLoai);
            this.panel9.Controls.Add(this.lblDanhMuc);
            this.panel9.Location = new System.Drawing.Point(3, 95);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(378, 40);
            this.panel9.TabIndex = 10;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(104, 9);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(268, 21);
            this.cbLoai.TabIndex = 7;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMuc.Location = new System.Drawing.Point(3, 14);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(45, 16);
            this.lblDanhMuc.TabIndex = 6;
            this.lblDanhMuc.Text = "Loại :";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblMoTa);
            this.panel7.Controls.Add(this.txtMoTa);
            this.panel7.Location = new System.Drawing.Point(0, 49);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(378, 40);
            this.panel7.TabIndex = 8;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(3, 14);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(53, 16);
            this.lblMoTa.TabIndex = 6;
            this.lblMoTa.Text = "Mô tả :";
            this.lblMoTa.Click += new System.EventHandler(this.lblMaDoUong_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMoTa.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(107, 5);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(268, 30);
            this.txtMoTa.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(dtgvDoUong);
            this.panel3.Location = new System.Drawing.Point(6, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 454);
            this.panel3.TabIndex = 0;
            // 
            // dtgvDoUong
            // 
            dtgvDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDoUong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.Gia,
            this.TenDanhMuc,
            this.TrangThai,
            this.Mota,
            this.KhuyenMai});
            dtgvDoUong.GridColor = System.Drawing.SystemColors.ActiveCaption;
            dtgvDoUong.Location = new System.Drawing.Point(3, 3);
            dtgvDoUong.Name = "dtgvDoUong";
            dtgvDoUong.RowHeadersWidth = 51;
            dtgvDoUong.Size = new System.Drawing.Size(541, 448);
            dtgvDoUong.TabIndex = 0;
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.txtSoTrang);
            this.tabDoanhThu.Controls.Add(this.btnQuayLai);
            this.tabDoanhThu.Controls.Add(this.btnQuaTrang);
            this.tabDoanhThu.Controls.Add(this.btnCuoi);
            this.tabDoanhThu.Controls.Add(this.btnDau);
            this.tabDoanhThu.Controls.Add(this.panel1);
            this.tabDoanhThu.Controls.Add(this.panel2);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 22);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThu.Size = new System.Drawing.Size(950, 542);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "Doanh Thu";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            this.tabDoanhThu.Click += new System.EventHandler(this.tabDoanhThu_Click);
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTrang.Location = new System.Drawing.Point(429, 505);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.ReadOnly = true;
            this.txtSoTrang.Size = new System.Drawing.Size(87, 26);
            this.txtSoTrang.TabIndex = 8;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(243, 498);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 33);
            this.btnQuayLai.TabIndex = 7;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnQuaTrang
            // 
            this.btnQuaTrang.Location = new System.Drawing.Point(635, 498);
            this.btnQuaTrang.Name = "btnQuaTrang";
            this.btnQuaTrang.Size = new System.Drawing.Size(75, 33);
            this.btnQuaTrang.TabIndex = 6;
            this.btnQuaTrang.Text = "Qua Trang";
            this.btnQuaTrang.UseVisualStyleBackColor = true;
            this.btnQuaTrang.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Location = new System.Drawing.Point(866, 498);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(75, 33);
            this.btnCuoi.TabIndex = 5;
            this.btnCuoi.Text = "Cuối";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnDau
            // 
            this.btnDau.Location = new System.Drawing.Point(11, 498);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(75, 33);
            this.btnDau.TabIndex = 4;
            this.btnDau.Text = "Đầu";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvDoanhThu);
            this.panel1.Location = new System.Drawing.Point(8, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 434);
            this.panel1.TabIndex = 1;
            // 
            // dtgvDoanhThu
            // 
            this.dtgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.dtgvDoanhThu.Name = "dtgvDoanhThu";
            this.dtgvDoanhThu.RowHeadersWidth = 51;
            this.dtgvDoanhThu.Size = new System.Drawing.Size(930, 428);
            this.dtgvDoanhThu.TabIndex = 0;
            this.dtgvDoanhThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDoanhThu_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.totalPage);
            this.panel2.Controls.Add(this.page);
            this.panel2.Controls.Add(this.dtpkTuNgay);
            this.panel2.Controls.Add(this.btnThongKe);
            this.panel2.Controls.Add(this.dtpkDenNgay);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 43);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(748, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng số tiền: ";
            // 
            // totalPage
            // 
            this.totalPage.Location = new System.Drawing.Point(554, 24);
            this.totalPage.Margin = new System.Windows.Forms.Padding(2);
            this.totalPage.Name = "totalPage";
            this.totalPage.Size = new System.Drawing.Size(90, 20);
            this.totalPage.TabIndex = 1;
            this.totalPage.Visible = false;
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(350, 11);
            this.page.Margin = new System.Windows.Forms.Padding(2);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(90, 20);
            this.page.TabIndex = 0;
            this.page.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.page.Visible = false;
            // 
            // dtpkTuNgay
            // 
            this.dtpkTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkTuNgay.Location = new System.Drawing.Point(14, 9);
            this.dtpkTuNgay.Name = "dtpkTuNgay";
            this.dtpkTuNgay.Size = new System.Drawing.Size(242, 22);
            this.dtpkTuNgay.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(283, 3);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(87, 34);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.GetProductRevenue);
            // 
            // dtpkDenNgay
            // 
            this.dtpkDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDenNgay.Location = new System.Drawing.Point(402, 7);
            this.dtpkDenNgay.Name = "dtpkDenNgay";
            this.dtpkDenNgay.Size = new System.Drawing.Size(242, 22);
            this.dtpkDenNgay.TabIndex = 2;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabDoanhThu);
            this.tabAdmin.Controls.Add(this.tabDoUong);
            this.tabAdmin.Controls.Add(this.tabDanhMuc);
            this.tabAdmin.Controls.Add(this.tabTaiKhoan);
            this.tabAdmin.Location = new System.Drawing.Point(0, 1);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(958, 568);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.SelectedIndexChanged += new System.EventHandler(this.tabAdmin_SelectedIndexChanged);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 571);
            this.Controls.Add(this.tabAdmin);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.tabTaiKhoan.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).EndInit();
            this.panel13.ResumeLayout(false);
            this.tabDanhMuc.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMuc)).EndInit();
            this.panel11.ResumeLayout(false);
            this.tabDoUong.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGia)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dtgvDoUong)).EndInit();
            this.tabDoanhThu.ResumeLayout(false);
            this.tabDoanhThu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvDoUong;
        private System.Windows.Forms.TabPage tabTaiKhoan;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblLoaiTaiKhoan;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label lblTenHienThi;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.TextBox txtTenTk;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView dtgvTaiKhoan;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnXemTaiKhoan;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.TabPage tabDanhMuc;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dtgvDanhMuc;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnXemDanhMuc;
        private System.Windows.Forms.Button btnSuaDanhMuc;
        private System.Windows.Forms.Button btnXoaDanhMuc;
        private System.Windows.Forms.Button btnThemDanhMuc;
        private System.Windows.Forms.TabPage tabDoUong;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnTimDoUong;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnXemDoUong;
        private System.Windows.Forms.Button btnSuaDoUong;
        private System.Windows.Forms.Button btnXoaDoUong;
        private System.Windows.Forms.Button btnThemDoUong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpkDenNgay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvDoanhThu;
        private System.Windows.Forms.DateTimePicker dtpkTuNgay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnQuaTrang;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.ComboBox cbLoai;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn Mota;
        private DataGridViewTextBoxColumn KhuyenMai;
        private NumericUpDown totalPage;
        private NumericUpDown page;
        private Label label2;
        private Label label3;
    }
}
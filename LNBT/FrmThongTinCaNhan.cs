using LNBT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNBT
{
    public partial class FrmThongTinCaNhan : Form
    {
        private TKNhanVien _tKNhanVien;

        public FrmThongTinCaNhan(TKNhanVien tKNhanVien)
        {
            InitializeComponent();
            _tKNhanVien = tKNhanVien;
        }

        private void FrmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            TKNhanVien tKNhanVien = db.TKNhanViens.SingleOrDefault(x => x.Username == _tKNhanVien.Username);
            NhanVien nhanVien = db.NhanViens.SingleOrDefault(x => x.MaNhanVien == tKNhanVien.EmployeeID);
            txtTenDangNhap.Text = tKNhanVien.Username;
            txtTenHienThi.Text = nhanVien.TenNhanVien;
            txtMatKhau.Text = tKNhanVien.PasswordHash;
            txtMatKhauMoi.Text = tKNhanVien.PasswordHash;
            txtNhapLai.Text = tKNhanVien.PasswordHash;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using(Model1 db = new Model1())
            {
                TKNhanVien tKNhanVien = db.TKNhanViens.SingleOrDefault(x => x.Username == _tKNhanVien.Username);
                tKNhanVien.PasswordHash = txtMatKhauMoi.Text;
                NhanVien nhanVien = db.NhanViens.SingleOrDefault(x => x.MaNhanVien == tKNhanVien.EmployeeID);
                nhanVien.TenNhanVien = txtTenHienThi.Text;
                if (txtNhapLai.Text != tKNhanVien.PasswordHash)
                {
                    MessageBox.Show("Mật khẩu không đúng");
                    return;
                }
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
        }
    }
}

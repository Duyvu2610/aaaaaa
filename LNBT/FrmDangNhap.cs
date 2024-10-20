using LNBT.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNBT
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (Loading loading = new Loading())
            {
                loading.Show();
                string username = txtTenDangNhap.Text;
                string password = txtMatKhau.Text;

                TKNhanVien tkNhanVien = await Task.Run(() =>
                {
                    using (Model1 db = new Model1())
                    {
                        return db.TKNhanViens.SingleOrDefault(x => x.Username == username && x.PasswordHash == password);
                    }
                });

                loading.Close();

                if (tkNhanVien != null)
                {
                    FrmMain f = new FrmMain(tkNhanVien);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát !");
            Application.Exit();
        }

    }
}

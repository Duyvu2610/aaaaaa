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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void lblMaDoUong_Click(object sender, EventArgs e)
        {
            
        }


        private void delete_product(object sender, EventArgs e)
        {
            string product_id = txtMaDoUong.Text;

            if (string.IsNullOrEmpty(product_id))
            {
                MessageBox.Show("Please enter a product ID.");
                return;
            }

            if (!int.TryParse(product_id, out int productId))
            {
                MessageBox.Show("Invalid product ID. Please enter a valid number.");
                return;
            }

            using (Model1 db = new Model1())
            {
                var relatedOrders = db.ChiTietDonHangs.Where(od => od.MaSanPham == productId).ToList();
                if (relatedOrders.Count > 0)
                {
                    db.ChiTietDonHangs.RemoveRange(relatedOrders);
                }

                var productToDelete = db.SanPhams.FirstOrDefault(p => p.MaSanPham == productId);
                if (productToDelete != null)
                {
                    db.SanPhams.Remove(productToDelete);
                    db.SaveChanges();

                    MessageBox.Show("Product and related order details deleted successfully.");
                    dtgvDoUong.DataSource = db.SanPhams.ToList();
                }
                else
                {
                    MessageBox.Show("No product found with the entered ID.");
                }
            }
        }



        private void find_product(object sender, EventArgs e)
        {
            string product_id = txtTim.Text;

            if (string.IsNullOrEmpty(product_id))
            {
                MessageBox.Show("Please enter a product ID.");
                return;
            } 
            
                int productId;
                if (!int.TryParse(product_id, out productId))
                {
                    MessageBox.Show("Invalid product ID. Please enter a valid number.");
                    return;
                }

                Model1 db = new Model1();
                var products = db.SanPhams
                             .Where(p => p.MaSanPham == productId)
                             .ToList();

                if (products.Count >0)
                {
                    txtMaDoUong.Text = products.First().MaSanPham.ToString();
                    textBox1.Text = products.First().TenSanPham;
                    nmGia.Value = products.First().Gia;
                }
                else
                {
                    MessageBox.Show("No product found with the entered ID.");
                }
            

        }

        private void add_product(object sender, EventArgs e)
        {
            string product_name = textBox1.Text;
            decimal price = nmGia.Value;

            if (string.IsNullOrEmpty(product_name))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            using (Model1 db = new Model1())
            {
                var newProduct = new SanPham
                {
                    TenSanPham = product_name,
                    Gia = price
                };

                db.SanPhams.Add(newProduct);
                db.SaveChanges();

                MessageBox.Show("Product added successfully.");

                 dtgvDoUong.DataSource = db.SanPhams.ToList();
            }
        }


        private void view_all_product(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            dtgvDoUong.DataSource = db.SanPhams.ToList();
        }

        private void update_product(object sender, EventArgs e)
        {
            string product_id = txtMaDoUong.Text;

            if (string.IsNullOrEmpty(product_id))
            {
                MessageBox.Show("Please enter a product ID.");
                return;
            }

            if (!int.TryParse(product_id, out int productId))
            {
                MessageBox.Show("Invalid product ID. Please enter a valid number.");
                return;
            }

            string product_name = textBox1.Text;
            decimal price = nmGia.Value;

            if (string.IsNullOrEmpty(product_name))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            using (Model1 db = new Model1())
            {
                var productToUpdate = db.SanPhams.FirstOrDefault(p => p.MaSanPham == productId);

                if (productToUpdate != null)
                {
                    productToUpdate.TenSanPham = product_name;
                    productToUpdate.Gia = price;

                    db.SaveChanges();

                    MessageBox.Show("Product updated successfully.");
                    dtgvDoUong.DataSource = db.SanPhams.ToList();
                }
                else
                {
                    MessageBox.Show("No product found with the entered ID.");
                }
            }
        }


        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void tabDoanhThu_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabTaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}

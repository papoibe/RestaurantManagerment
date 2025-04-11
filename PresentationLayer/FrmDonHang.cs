using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class FrmDonHang : Form
    {
        private MonAn_BL monAnBL;
        private List<MonAn_DOL> danhSachMonAn;

        //private LoaiMonAn_BL loaiMonAnBL; // Assuming you have this class

        public FrmDonHang()
        {
            InitializeComponent();
            monAnBL = new MonAn_BL();
            //loaiMonAnBL = new LoaiMonAn_BL();
        }

        private void FrmDonHang_Load(object sender, EventArgs e)
        {
            LoadMonAn();
            // Load other necessary data
        }

        private void LoadMonAn(int maLoai = 0)
        {
            fLP_Menu.Controls.Clear();

            if (maLoai == 0)
            {
                danhSachMonAn = monAnBL.GetAll().Where(m => m.TrangThai).ToList();
            }
            else
            {
                danhSachMonAn = monAnBL.GetMonAnByLoai(maLoai);
            }

            foreach (MonAn_DOL monAn in danhSachMonAn)
            {
                Button btnMonAn = new Button();
                btnMonAn.Width = 100;
                btnMonAn.Height = 100;
                btnMonAn.Text = monAn.TenMonAn + Environment.NewLine + string.Format("{0:#,###}", monAn.DonGia) + " VND";
                btnMonAn.Tag = monAn;
                btnMonAn.BackColor = Color.LightBlue;
                btnMonAn.FlatStyle = FlatStyle.Flat;
                btnMonAn.Click += BtnMonAn_Click;

                fLP_Menu.Controls.Add(btnMonAn);
            }
        }

        private void BtnMonAn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MonAn_DOL monAn = btn.Tag as MonAn_DOL;

            // Add the selected food item to the order
            // This will depend on how you want to handle orders
            // For example:
            //ThemMonAnVaoDonHang(monAn);
        }

        //private void ThemMonAnVaoDonHang(MonAn_DOL monAn)
        //{
        //    // Implement the logic to add a food item to the order
        //    // This would typically involve adding it to a list or grid view
        //    // that displays the current order items

        //    // Example implementation might look like:
        //    ListViewItem item = new ListViewItem(monAn.MaMonAn.ToString());
        //    item.SubItems.Add(monAn.TenMonAn);
        //    item.SubItems.Add("1"); // Default quantity
        //    item.SubItems.Add(monAn.DonGia.ToString("#,###"));
        //    item.SubItems.Add(monAn.DonGia.ToString("#,###")); // Total for this item
        //    item.Tag = monAn;

        //    lvDonHang.Items.Add(item);

        //    // Update the order total
        //    CapNhatTongTien();
        //}

        //private void CapNhatTongTien()
        //{
        //    float tongTien = 0;
        //    foreach (ListViewItem item in lvDonHang.Items)
        //    {
        //        int soLuong = int.Parse(item.SubItems[2].Text);
        //        float donGia = float.Parse(item.SubItems[3].Text.Replace(",", ""));
        //        tongTien += soLuong * donGia;
        //    }

        //    lblTong.Text = string.Format("{0:#,###} VND", tongTien);
        //}

        private void btnLuuOrder_Click(object sender, EventArgs e)
        {
            // Implement logic to save the order to database
            // This would involve creating a new order in the DB
            // and adding each item from lvDonHang to the order details

            // Example:
            /*
            Order_DTO order = new Order_DTO();
            order.MaBan = selectedBan.MaBan;
            order.NgayDat = DateTime.Now;
            order.TrangThai = false; // Not paid yet
            
            int maOrder = orderBL.ThemOrder(order);
            
            if (maOrder > 0)
            {
                foreach (ListViewItem item in lvDonHang.Items)
                {
                    OrderDetail_DTO detail = new OrderDetail_DTO();
                    detail.MaOrder = maOrder;
                    detail.MaMonAn = int.Parse(item.SubItems[0].Text);
                    detail.SoLuong = int.Parse(item.SubItems[2].Text);
                    detail.DonGia = float.Parse(item.SubItems[3].Text.Replace(",", ""));
                    
                    orderDetailBL.ThemOrderDetail(detail);
                }
                
                MessageBox.Show("Đã lưu đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lvDonHang.Items.Clear();
                CapNhatTongTien();
            }
            */
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Implement payment logic
            // This might involve marking the order as paid
            // and possibly printing a receipt

            // Example:
            /*
            if (lvDonHang.Items.Count > 0)
            {
                // Update order status to paid
                // orderBL.CapNhatTrangThaiOrder(maOrder, true);
                
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lvDonHang.Items.Clear();
                CapNhatTongTien();
            }
            else
            {
                MessageBox.Show("Chưa có món ăn nào để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
        }
    }
}

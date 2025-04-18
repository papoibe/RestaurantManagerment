using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using TransferObject;


namespace PresentationLayer
{
    public partial class FrmQuanLyBan : Form
    {
        private Ban_BL banBL;
        private DonHang_BL donHangBL;
        public FrmQuanLyBan()
        {
            InitializeComponent();
            donHangBL = new DonHang_BL();
            banBL = new Ban_BL();
            LoadDanhSachBan();
        }
        private void LoadDanhSachBan()
        {
            try
            {
                // Lấy danh sách bàn từ lớp Business Layer
                List<Ban_DTO> danhSachBan = banBL.GetAll();
                // Xóa các control cũ trong FlowLayoutPanel 
                fLPBan.Controls.Clear();
                string name;
                // Tạo các button đại diện cho từng bàn
                foreach (var ban in danhSachBan)
                {
                    if (ban.TrangThai == false) // nếu bàn đã có đơn hàng thì load số tiền của bàn lên và màu sẽ là đỏ
                    {
                        name = ban.TenBan +"\n \n"+ banBL.GetTienBan(ban.MaBan);
                    }
                    else
                    {
                        name = ban.TenBan;
                    }
                    Button btnBan = new Button
                    {
                        Text = name,
                        Width = 100,
                        Height = 100,
                        BackColor = ban.TrangThai ? Color.Green : Color.Red, // Màu xanh nếu bàn trống, đỏ nếu đang sử dụng
                        ForeColor = Color.White,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Tag = ban // Lưu thông tin bàn trong thuộc tính Tag
                    };

                    // Gắn sự kiện click cho button
                    btnBan.Click += BtnBan_Click;

                    // Thêm button vào FlowLayoutPanel
                    fLPBan.Controls.Add(btnBan);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách bàn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnBan_Click(object sender, EventArgs e)
        {
            // Lấy thông tin bàn từ thuộc tính Tag của button
            Button btnBan = sender as Button;
            Ban_DTO ban = btnBan.Tag as Ban_DTO;
            if(ban!=null && ban.TrangThai == false) // bàn đã có đơn hàng
            {
                FrmDonHang frmDonHang = new FrmDonHang(donHangBL.GetLastId(ban.MaBan), ban.MaBan);
                DialogResult result = frmDonHang.ShowDialog();
                if(result == DialogResult.OK)
                {
                    // Nếu đơn hàng đã được lưu thành công, gọi lại hàm LoadDanhSachBan
                    // và truyền vào hàm OnOrderSaved để cập nhật lại danh sách bàn
                    
                    LoadDanhSachBan();
                }
                else
                {
                    LoadDanhSachBan();
                }
            }
            else // bàn chưa có đơn hàng
            {
                FrmLapOrder frmLapOrder = new FrmLapOrder(ban);
                DialogResult result = frmLapOrder.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    LoadDanhSachBan();
                }

            }
        }
        private void btn_cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

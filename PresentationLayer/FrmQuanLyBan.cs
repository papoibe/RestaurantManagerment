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
        public FrmQuanLyBan()
        {
            InitializeComponent();
            banBL = new Ban_BL();
            LoadDanhSachBan();
        }

        private void FrmQuanLyBan_Load(object sender, EventArgs e)
        {
            //LoadData();
        }
        private void LoadDanhSachBan()
        {
            try
            {
                // Lấy danh sách bàn từ lớp Business Layer
                List<Ban_DTO> danhSachBan = banBL.GetAll();

                // Xóa các control cũ trong FlowLayoutPanel
                fLPBan.Controls.Clear();

                // Tạo các button đại diện cho từng bàn
                foreach (var ban in danhSachBan)
                {
                    Button btnBan = new Button
                    {
                        Text = ban.TenBan,
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

            if (ban != null)
            {
                MessageBox.Show($"Bạn đã chọn bàn: {ban.TenBan}\nTrạng thái: {(ban.TrangThai ? "Trống" : "Đang sử dụng")}",
                                "Thông tin bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

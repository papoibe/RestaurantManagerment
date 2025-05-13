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
    public partial class FrmBaoCao: Form
    {

        // khai báo đối tượng bl
        private BaoCaoMonAn_BL baoCaoMonAnBL;
        private BaoCaoDoanhThu_BL baoCaoDoanhThuBL;
        public FrmBaoCao()
        {
            InitializeComponent();
            // khởi tạo đối tượng bl
            baoCaoMonAnBL = new BaoCaoMonAn_BL();
            baoCaoDoanhThuBL = new BaoCaoDoanhThu_BL();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            // tạo giá trị măc định cho control
            dtpTuNgay.Value = DateTime.Now.AddDays(-30); // mặc định 30 ngày trước 
            dtpDenNgay.Value = DateTime.Now; // mặc định ngày hiện tại

            // Ẩn các panel chi tiết khi mới mở form
            pnlChiTietDoanhThu.Visible = false;
            pnlChiTietMonAn.Visible = false;


        }

        private void btnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            try
            {
                //hiển thị pnl báo cáo doanh thu
                pnlChiTietDoanhThu.Visible = true;
                pnlChiTietMonAn.Visible = false;

                // lấy dữ liệu từ ngày bắt đầu đến ngày kết thúc
                DateTime tuNgay = dtpTuNgay.Value;
                DateTime denNgay = dtpDenNgay.Value;
                
                // kiểm tra điều kiện 
                if (tuNgay > denNgay)
                {
                    MessageBox.Show("Từ ngày phải nhỏ hơn hoặc bằng đến ngày!", "Lỗi",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //gọi pt lấy dữ liệu báo cáo doanh thu
                DataTable dtDoanhThu = baoCaoDoanhThuBL.GetBaoCaoDoanhThuTheoNgay(tuNgay, denNgay);

                // Hiển thị dữ liệu lên DataGridView
                dgvDoanhThu.DataSource = dtDoanhThu;

                // Tính tổng doanh thu
                decimal tongDoanhThu = 0;
                foreach (DataRow row in dtDoanhThu.Rows)
                {
                    tongDoanhThu += Convert.ToDecimal(row["TongDoanhThu"]);
                }

                // Hiển thị tổng doanh thu
                lblTongDoanhThu.Text = string.Format("{0:#,##0} VNĐ", tongDoanhThu);

                // Hiển thị biểu đồ 
                // HienThiBieuDoDoanhThu(dtDoanhThu);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi hiển thị báo cáo doanh thu: " + ex.Message, "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBaoCaoMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị panel báo cáo món ăn và ẩn panel báo cáo doanh thu
                pnlChiTietMonAn.Visible = true;
                pnlChiTietDoanhThu.Visible = false;

                // Lấy thông tin từ ngày đến ngày
                DateTime tuNgay = dtpTuNgay.Value;
                DateTime denNgay = dtpDenNgay.Value;

                // Kiểm tra điều kiện hợp lệ
                if (tuNgay > denNgay)
                {
                    MessageBox.Show("Từ ngày phải nhỏ hơn hoặc bằng đến ngày!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Số lượng món ăn cần hiển thị
                int soLuong = 10; // Mặc định top 10 món ăn bán chạy
                if (!string.IsNullOrEmpty(txtSoLuongHienThi.Text))
                {
                    soLuong = Convert.ToInt32(txtSoLuongHienThi.Text);
                }

                // Gọi phương thức lấy dữ liệu báo cáo món ăn
                DataTable dtMonAn = baoCaoMonAnBL.GetBaoCaoMonAnBanChay(tuNgay, denNgay, soLuong);

                // Hiển thị dữ liệu lên DataGridView
                dgvMonAn.DataSource = dtMonAn;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi hiển thị báo cáo món ăn: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

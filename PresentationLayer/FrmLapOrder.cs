using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class FrmLapOrder: Form
    {
        public Ban_DTO selectedBan;
        private Ban_BL banBL;
        public FrmLapOrder(Ban_DTO ban)
        {
            InitializeComponent();
            banBL = new Ban_BL();
            selectedBan = ban;
        }

        private void FrmLapOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                // Cập nhật trạng thái bàn sang false (đang sử dụng)
                selectedBan.TrangThai = false;

                // Gọi lớp Business Layer để cập nhật trạng thái bàn
                bool result = banBL.CapNhatBan(selectedBan);

                if (result)
                {
                    MessageBox.Show("Cập nhật trạng thái bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái bàn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái bàn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

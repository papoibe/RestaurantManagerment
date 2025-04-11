using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;
namespace PresentationLayer
{
    public partial class FrmLogin: Form
    {
        private Account_BL accountBL;
        public FrmLogin()
        {
            InitializeComponent();
            accountBL = new Account_BL();
        }


        //xu ly nut dang nhap 
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                //lay thong tin tu textbox
                string username = txt_Username.Text.Trim();
                string password = txt_Password.Text;

                //kiem tra thong tin nhap vao
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui long nhap day du ten dang nhap va mat khau!", "Thong bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                //tao doi tuong NhanVien
                Account_DTO account = new Account_DTO(username, password);


               
                //goi phuong thuc dang nhap
                if (accountBL.Login(account))
                {
                    //neu dang nhap thanh cong
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ten dang nhap hoac mat khau khong dung!", "loi dang nhap",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Password.Clear();
                    txt_Password.Focus();


                    // hien thi lua chon dang ky neu chua co tai khoan
                    DialogResult result = MessageBox.Show("Ban chua co tai khoan? Dang ky ngay", "Thong bao"
                        ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) 
                    {
                        FrmDangKy frmDangKy = new FrmDangKy();
                        frmDangKy.ShowDialog();
                        this.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}

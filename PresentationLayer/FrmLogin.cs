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


                //tao doi tuong 
                Account_DTO account = new Account_DTO(username, password);

                //goi phuong thuc dang nhap tu BL 
                Account_DTO accountDTO = accountBL.Login(account);

                //kiem tra dang nhap thanh cong
                if (accountDTO != null)
                {
                    //neu dang nhap thanh cong, xac dinh ma loai
                    //neu ma loai = 1 thi la admin
                    //neu ma loai = 2 thi la nhan vien
                    if (accountDTO.Maloai == 1) //admin
                    {
                        try
                        {
                            //neu la admin
                            //thuc hien mo form admin
                            FrmAdmin adminForm = new FrmAdmin(accountDTO);
                            //truyen accountDTO vao form admin
                            //hien thi form admin   
                            adminForm.Show();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else if (accountDTO.Maloai == 2)
                    {
                        try
                        {
                            //neu la nhan vien
                            //thuc hien mo form nhan vien
                            FrmWorkers workerForm = new FrmWorkers(accountDTO);
                            //truyen accountDTO vao form nhan vien
                            //hien thi form nhan vien
                            workerForm.Show();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Khong co quyen truy cap!", "loi dang nhap",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Ten dang nhap hoac mat khau khong dung!", "loi dang nhap",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Password.Clear();
                    txt_Password.Focus();
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

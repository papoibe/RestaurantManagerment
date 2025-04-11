using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;
using System.Security.Principal;

namespace DataLayer
{
    public class Account_DAL : DataProvider
    {
        //kiem tra dang nhap
        public bool Login(Account_DTO account)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @Username AND MatKhau = @Password";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                Connect();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }


        //them tai khoan
        public bool AddAccount(Account_DTO account)
        {
            try
            {
                string sql = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, TenHienThi) VALUES (@Username, @Password, @DisplayName)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@DisplayName", account.DisplayName);
                Connect();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        //kiem tra ton tai tai khoan
        public bool CheckAccountExists(string username)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @Username";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Username", username);
                Connect();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
    }
}
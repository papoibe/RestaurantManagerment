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
    public partial class FrmWorkers : Form
    {
        private Account_DTO currentUser;
        public FrmWorkers(Account_DTO accountUser)
        {
            InitializeComponent();
            currentUser = accountUser;
        }

        private void FrmWorkers_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin người dùng
            lb_Username.Text = currentUser.Username;
            lb_DisplayName.Text = currentUser.DisplayName;
            lb_Welcome.Text = "Welcome, " + currentUser.DisplayName + "(Worker)!";
        }
    }
}

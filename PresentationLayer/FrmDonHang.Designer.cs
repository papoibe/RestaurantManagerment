namespace PresentationLayer
{
    partial class FrmDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fLP_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.lvDonHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_MaDonHang = new System.Windows.Forms.Label();
            this.lb_MaBan = new System.Windows.Forms.Label();
            this.gBHinhThucTT = new System.Windows.Forms.GroupBox();
            this.lbTong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TienThoi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SoTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_sum = new System.Windows.Forms.Label();
            this.gBHinhThucTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // fLP_Menu
            // 
            this.fLP_Menu.Location = new System.Drawing.Point(798, 13);
            this.fLP_Menu.Name = "fLP_Menu";
            this.fLP_Menu.Size = new System.Drawing.Size(535, 650);
            this.fLP_Menu.TabIndex = 0;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(819, 688);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(153, 48);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu order";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(1013, 688);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(153, 48);
            this.btn_ThanhToan.TabIndex = 4;
            this.btn_ThanhToan.Text = "ThanhToan";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // lvDonHang
            // 
            this.lvDonHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDonHang.HideSelection = false;
            this.lvDonHang.Location = new System.Drawing.Point(13, 13);
            this.lvDonHang.Name = "lvDonHang";
            this.lvDonHang.Size = new System.Drawing.Size(782, 650);
            this.lvDonHang.TabIndex = 5;
            this.lvDonHang.UseCompatibleStateImageBehavior = false;
            this.lvDonHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 146;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 166;
            // 
            // lb_MaDonHang
            // 
            this.lb_MaDonHang.AutoSize = true;
            this.lb_MaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaDonHang.Location = new System.Drawing.Point(165, 337);
            this.lb_MaDonHang.Name = "lb_MaDonHang";
            this.lb_MaDonHang.Size = new System.Drawing.Size(194, 38);
            this.lb_MaDonHang.TabIndex = 6;
            this.lb_MaDonHang.Text = "maDonhang";
            // 
            // lb_MaBan
            // 
            this.lb_MaBan.AutoSize = true;
            this.lb_MaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaBan.Location = new System.Drawing.Point(399, 337);
            this.lb_MaBan.Name = "lb_MaBan";
            this.lb_MaBan.Size = new System.Drawing.Size(120, 38);
            this.lb_MaBan.TabIndex = 7;
            this.lb_MaBan.Text = "maBan";
            // 
            // gBHinhThucTT
            // 
            this.gBHinhThucTT.Controls.Add(this.lbTong);
            this.gBHinhThucTT.Controls.Add(this.label3);
            this.gBHinhThucTT.Controls.Add(this.lb_TienThoi);
            this.gBHinhThucTT.Controls.Add(this.label2);
            this.gBHinhThucTT.Controls.Add(this.txt_SoTien);
            this.gBHinhThucTT.Controls.Add(this.label1);
            this.gBHinhThucTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBHinhThucTT.Location = new System.Drawing.Point(798, 319);
            this.gBHinhThucTT.Name = "gBHinhThucTT";
            this.gBHinhThucTT.Size = new System.Drawing.Size(535, 344);
            this.gBHinhThucTT.TabIndex = 9;
            this.gBHinhThucTT.TabStop = false;
            this.gBHinhThucTT.Text = "Thanh toán bằng tiền mặt";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(251, 135);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(0, 38);
            this.lbTong.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số tiền phải trả:";
            // 
            // lb_TienThoi
            // 
            this.lb_TienThoi.AutoSize = true;
            this.lb_TienThoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TienThoi.Location = new System.Drawing.Point(296, 213);
            this.lb_TienThoi.Name = "lb_TienThoi";
            this.lb_TienThoi.Size = new System.Drawing.Size(44, 38);
            this.lb_TienThoi.TabIndex = 11;
            this.lb_TienThoi.Text = "!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số tiền thừa:";
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoTien.Location = new System.Drawing.Point(258, 62);
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Size = new System.Drawing.Size(252, 45);
            this.txt_SoTien.TabIndex = 9;
            this.txt_SoTien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SoTien_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số tiền nhận:";
            // 
            // lb_sum
            // 
            this.lb_sum.AutoSize = true;
            this.lb_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sum.Location = new System.Drawing.Point(474, 688);
            this.lb_sum.Name = "lb_sum";
            this.lb_sum.Size = new System.Drawing.Size(64, 25);
            this.lb_sum.TabIndex = 8;
            this.lb_sum.Text = "label4";
            // 
            // FrmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 768);
            this.Controls.Add(this.gBHinhThucTT);
            this.Controls.Add(this.lb_sum);
            this.Controls.Add(this.lb_MaBan);
            this.Controls.Add(this.lb_MaDonHang);
            this.Controls.Add(this.lvDonHang);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.fLP_Menu);
            this.Name = "FrmDonHang";
            this.Text = "FrmDonHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDonHang_Load);
            this.gBHinhThucTT.ResumeLayout(false);
            this.gBHinhThucTT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLP_Menu;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.ListView lvDonHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lb_MaDonHang;
        private System.Windows.Forms.Label lb_MaBan;
        private System.Windows.Forms.GroupBox gBHinhThucTT;
        private System.Windows.Forms.TextBox txt_SoTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_TienThoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_sum;
    }
}
namespace PresentationLayer
{
    partial class FrmDangKy
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_TenDangNhap = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lb_DisplayName = new System.Windows.Forms.Label();
            this.txt_DisplayName = new System.Windows.Forms.TextBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Image = global::PresentationLayer.Properties.Resources.signup;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1007, 624);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TenDangNhap
            // 
            this.lb_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDangNhap.Location = new System.Drawing.Point(243, 219);
            this.lb_TenDangNhap.Name = "lb_TenDangNhap";
            this.lb_TenDangNhap.Size = new System.Drawing.Size(193, 31);
            this.lb_TenDangNhap.TabIndex = 1;
            this.lb_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(457, 219);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(284, 45);
            this.txt_Username.TabIndex = 2;
            // 
            // lb_Password
            // 
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(243, 294);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(193, 31);
            this.lb_Password.TabIndex = 3;
            this.lb_Password.Text = "Mật khẩu";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(457, 294);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(284, 45);
            this.txt_Password.TabIndex = 4;
            // 
            // lb_DisplayName
            // 
            this.lb_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DisplayName.Location = new System.Drawing.Point(243, 371);
            this.lb_DisplayName.Name = "lb_DisplayName";
            this.lb_DisplayName.Size = new System.Drawing.Size(193, 31);
            this.lb_DisplayName.TabIndex = 5;
            this.lb_DisplayName.Text = "Tên hiển thị";
            // 
            // txt_DisplayName
            // 
            this.txt_DisplayName.Location = new System.Drawing.Point(457, 378);
            this.txt_DisplayName.Multiline = true;
            this.txt_DisplayName.Name = "txt_DisplayName";
            this.txt_DisplayName.Size = new System.Drawing.Size(284, 45);
            this.txt_DisplayName.TabIndex = 6;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.Location = new System.Drawing.Point(281, 476);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(155, 62);
            this.btn_DangKy.TabIndex = 7;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(500, 476);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(155, 62);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 43);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đăng ký tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 655);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.txt_DisplayName);
            this.Controls.Add(this.lb_DisplayName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lb_TenDangNhap);
            this.Controls.Add(this.label1);
            this.Name = "FrmDangKy";
            this.Text = "FrmDangKy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_TenDangNhap;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lb_DisplayName;
        private System.Windows.Forms.TextBox txt_DisplayName;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label2;
    }
}
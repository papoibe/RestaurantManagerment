namespace PresentationLayer
{
    partial class FrmQuanLyHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fLP_HD = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_chiTiet = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_GiamGia = new System.Windows.Forms.Label();
            this.lb_Tong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_TrangThai = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_MD = new System.Windows.Forms.Label();
            this.lb_PPTT = new System.Windows.Forms.Label();
            this.col_maCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // fLP_HD
            // 
            this.fLP_HD.AutoScroll = true;
            this.fLP_HD.Location = new System.Drawing.Point(7, 76);
            this.fLP_HD.Name = "fLP_HD";
            this.fLP_HD.Size = new System.Drawing.Size(770, 720);
            this.fLP_HD.TabIndex = 0;
            // 
            // dgv_chiTiet
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_chiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_maCT,
            this.col_SL,
            this.col_ten,
            this.col_tien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_chiTiet.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_chiTiet.Location = new System.Drawing.Point(783, 76);
            this.dgv_chiTiet.Name = "dgv_chiTiet";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chiTiet.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_chiTiet.RowHeadersWidth = 51;
            this.dgv_chiTiet.RowTemplate.Height = 24;
            this.dgv_chiTiet.Size = new System.Drawing.Size(753, 449);
            this.dgv_chiTiet.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1536, 73);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quản lý hóa đơn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_InHD
            // 
            this.btn_InHD.BackColor = System.Drawing.Color.Blue;
            this.btn_InHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_InHD.Location = new System.Drawing.Point(1187, 690);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(143, 78);
            this.btn_InHD.TabIndex = 15;
            this.btn_InHD.Text = "In";
            this.btn_InHD.UseVisualStyleBackColor = false;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close.Location = new System.Drawing.Point(1357, 690);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(134, 78);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1227, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tổng Tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(856, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1227, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Giảm giá:";
            // 
            // lb_GiamGia
            // 
            this.lb_GiamGia.AutoSize = true;
            this.lb_GiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GiamGia.Location = new System.Drawing.Point(1414, 562);
            this.lb_GiamGia.Name = "lb_GiamGia";
            this.lb_GiamGia.Size = new System.Drawing.Size(0, 29);
            this.lb_GiamGia.TabIndex = 22;
            // 
            // lb_Tong
            // 
            this.lb_Tong.AutoSize = true;
            this.lb_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tong.Location = new System.Drawing.Point(1414, 612);
            this.lb_Tong.Name = "lb_Tong";
            this.lb_Tong.Size = new System.Drawing.Size(0, 29);
            this.lb_Tong.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(802, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Trạng thái:";
            // 
            // lb_TrangThai
            // 
            this.lb_TrangThai.AutoSize = true;
            this.lb_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrangThai.Location = new System.Drawing.Point(999, 612);
            this.lb_TrangThai.Name = "lb_TrangThai";
            this.lb_TrangThai.Size = new System.Drawing.Size(0, 29);
            this.lb_TrangThai.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(802, 665);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "Thanh Toán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(802, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Mã đơn:";
            // 
            // lb_MD
            // 
            this.lb_MD.AutoSize = true;
            this.lb_MD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MD.Location = new System.Drawing.Point(999, 562);
            this.lb_MD.Name = "lb_MD";
            this.lb_MD.Size = new System.Drawing.Size(0, 29);
            this.lb_MD.TabIndex = 28;
            // 
            // lb_PPTT
            // 
            this.lb_PPTT.AutoSize = true;
            this.lb_PPTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PPTT.Location = new System.Drawing.Point(999, 665);
            this.lb_PPTT.Name = "lb_PPTT";
            this.lb_PPTT.Size = new System.Drawing.Size(0, 29);
            this.lb_PPTT.TabIndex = 29;
            // 
            // col_maCT
            // 
            this.col_maCT.HeaderText = "mã chi tiết";
            this.col_maCT.MinimumWidth = 6;
            this.col_maCT.Name = "col_maCT";
            this.col_maCT.Visible = false;
            this.col_maCT.Width = 125;
            // 
            // col_SL
            // 
            this.col_SL.HeaderText = "SL";
            this.col_SL.MinimumWidth = 6;
            this.col_SL.Name = "col_SL";
            this.col_SL.ReadOnly = true;
            this.col_SL.Width = 50;
            // 
            // col_ten
            // 
            this.col_ten.HeaderText = "Tên món";
            this.col_ten.MinimumWidth = 6;
            this.col_ten.Name = "col_ten";
            this.col_ten.ReadOnly = true;
            this.col_ten.Width = 220;
            // 
            // col_tien
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_tien.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_tien.HeaderText = "Thành Tiền";
            this.col_tien.MinimumWidth = 6;
            this.col_tien.Name = "col_tien";
            this.col_tien.ReadOnly = true;
            this.col_tien.Width = 200;
            // 
            // FrmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 803);
            this.Controls.Add(this.dgv_chiTiet);
            this.Controls.Add(this.lb_PPTT);
            this.Controls.Add(this.lb_MD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_TrangThai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Tong);
            this.Controls.Add(this.lb_GiamGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_InHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fLP_HD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuanLyHoaDon";
            this.Text = "FrmQuanLyHoaDon";
            this.Load += new System.EventHandler(this.FrmQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLP_HD;
        private System.Windows.Forms.DataGridView dgv_chiTiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_GiamGia;
        private System.Windows.Forms.Label lb_Tong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_TrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_MD;
        private System.Windows.Forms.Label lb_PPTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tien;
    }
}
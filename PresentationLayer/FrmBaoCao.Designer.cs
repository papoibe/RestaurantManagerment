namespace PresentationLayer
{
    partial class FrmBaoCao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.txtSoLuongHienThi = new System.Windows.Forms.TextBox();
            this.lblSoLuongHienThi = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.btnBaoCaoMonAn = new System.Windows.Forms.Button();
            this.btnBaoCaoDoanhThu = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlChiTietDoanhThu = new System.Windows.Forms.Panel();
            this.pnlTongDoanhThu = new System.Windows.Forms.Panel();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTongDoanhThuTitle = new System.Windows.Forms.Label();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlChiTietMonAn = new System.Windows.Forms.Panel();
            this.chartMonAn = new System.Windows.Forms.Panel();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.colMaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlChiTietDoanhThu.SuspendLayout();
            this.pnlTongDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.pnlChiTietMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1179, 62);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1179, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.txtSoLuongHienThi);
            this.pnlFilter.Controls.Add(this.lblSoLuongHienThi);
            this.pnlFilter.Controls.Add(this.dtpDenNgay);
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Controls.Add(this.dtpTuNgay);
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 62);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlFilter.Size = new System.Drawing.Size(1179, 73);
            this.pnlFilter.TabIndex = 1;
            // 
            // txtSoLuongHienThi
            // 
            this.txtSoLuongHienThi.Location = new System.Drawing.Point(720, 23);
            this.txtSoLuongHienThi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuongHienThi.Name = "txtSoLuongHienThi";
            this.txtSoLuongHienThi.Size = new System.Drawing.Size(79, 22);
            this.txtSoLuongHienThi.TabIndex = 5;
            this.txtSoLuongHienThi.Text = "10";
            // 
            // lblSoLuongHienThi
            // 
            this.lblSoLuongHienThi.AutoSize = true;
            this.lblSoLuongHienThi.Location = new System.Drawing.Point(600, 27);
            this.lblSoLuongHienThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuongHienThi.Name = "lblSoLuongHienThi";
            this.lblSoLuongHienThi.Size = new System.Drawing.Size(107, 16);
            this.lblSoLuongHienThi.TabIndex = 4;
            this.lblSoLuongHienThi.Text = "Số lượng hiển thị:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(387, 23);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(159, 22);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(307, 27);
            this.lblDenNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(67, 16);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(107, 23);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(159, 22);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(27, 27);
            this.lblTuNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(59, 16);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnXuatBaoCao);
            this.pnlButtons.Controls.Add(this.btnBaoCaoMonAn);
            this.pnlButtons.Controls.Add(this.btnBaoCaoDoanhThu);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 135);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlButtons.Size = new System.Drawing.Size(1179, 74);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXuatBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXuatBaoCao.Location = new System.Drawing.Point(600, 12);
            this.btnXuatBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(200, 49);
            this.btnXuatBaoCao.TabIndex = 2;
            this.btnXuatBaoCao.Text = "Xuất Báo Cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = false;
            // 
            // btnBaoCaoMonAn
            // 
            this.btnBaoCaoMonAn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBaoCaoMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoMonAn.ForeColor = System.Drawing.Color.White;
            this.btnBaoCaoMonAn.Location = new System.Drawing.Point(240, 12);
            this.btnBaoCaoMonAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCaoMonAn.Name = "btnBaoCaoMonAn";
            this.btnBaoCaoMonAn.Size = new System.Drawing.Size(200, 49);
            this.btnBaoCaoMonAn.TabIndex = 1;
            this.btnBaoCaoMonAn.Text = "Báo Cáo Món Ăn";
            this.btnBaoCaoMonAn.UseVisualStyleBackColor = false;
            this.btnBaoCaoMonAn.Click += new System.EventHandler(this.btnBaoCaoMonAn_Click);
            // 
            // btnBaoCaoDoanhThu
            // 
            this.btnBaoCaoDoanhThu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBaoCaoDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnBaoCaoDoanhThu.Location = new System.Drawing.Point(17, 12);
            this.btnBaoCaoDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCaoDoanhThu.Name = "btnBaoCaoDoanhThu";
            this.btnBaoCaoDoanhThu.Size = new System.Drawing.Size(200, 49);
            this.btnBaoCaoDoanhThu.TabIndex = 0;
            this.btnBaoCaoDoanhThu.Text = "Báo Cáo Doanh Thu";
            this.btnBaoCaoDoanhThu.UseVisualStyleBackColor = false;
            this.btnBaoCaoDoanhThu.Click += new System.EventHandler(this.btnBaoCaoDoanhThu_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlChiTietDoanhThu);
            this.pnlMain.Controls.Add(this.pnlChiTietMonAn);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 209);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlMain.Size = new System.Drawing.Size(1179, 481);
            this.pnlMain.TabIndex = 3;
            // 
            // pnlChiTietDoanhThu
            // 
            this.pnlChiTietDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChiTietDoanhThu.Controls.Add(this.pnlTongDoanhThu);
            this.pnlChiTietDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.pnlChiTietDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChiTietDoanhThu.Location = new System.Drawing.Point(13, 12);
            this.pnlChiTietDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlChiTietDoanhThu.Name = "pnlChiTietDoanhThu";
            this.pnlChiTietDoanhThu.Size = new System.Drawing.Size(1153, 457);
            this.pnlChiTietDoanhThu.TabIndex = 0;
            this.pnlChiTietDoanhThu.Visible = false;
            // 
            // pnlTongDoanhThu
            // 
            this.pnlTongDoanhThu.Controls.Add(this.lblTongDoanhThu);
            this.pnlTongDoanhThu.Controls.Add(this.lblTongDoanhThuTitle);
            this.pnlTongDoanhThu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTongDoanhThu.Location = new System.Drawing.Point(0, 393);
            this.pnlTongDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTongDoanhThu.Name = "pnlTongDoanhThu";
            this.pnlTongDoanhThu.Size = new System.Drawing.Size(1151, 62);
            this.pnlTongDoanhThu.TabIndex = 1;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(240, 18);
            this.lblTongDoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(75, 25);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "0 VNĐ";
            // 
            // lblTongDoanhThuTitle
            // 
            this.lblTongDoanhThuTitle.AutoSize = true;
            this.lblTongDoanhThuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThuTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTongDoanhThuTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongDoanhThuTitle.Name = "lblTongDoanhThuTitle";
            this.lblTongDoanhThuTitle.Size = new System.Drawing.Size(171, 25);
            this.lblTongDoanhThuTitle.TabIndex = 0;
            this.lblTongDoanhThuTitle.Text = "Tổng doanh thu:";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNgay,
            this.colSoDonHang,
            this.colTongDoanhThu});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoanhThu.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.dgvDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1151, 369);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // colNgay
            // 
            this.colNgay.DataPropertyName = "Ngay";
            this.colNgay.HeaderText = "Ngày";
            this.colNgay.MinimumWidth = 6;
            this.colNgay.Name = "colNgay";
            this.colNgay.ReadOnly = true;
            // 
            // colSoDonHang
            // 
            this.colSoDonHang.DataPropertyName = "SoDonHang";
            this.colSoDonHang.HeaderText = "Số đơn hàng";
            this.colSoDonHang.MinimumWidth = 6;
            this.colSoDonHang.Name = "colSoDonHang";
            this.colSoDonHang.ReadOnly = true;
            // 
            // colTongDoanhThu
            // 
            this.colTongDoanhThu.DataPropertyName = "TongDoanhThu";
            this.colTongDoanhThu.HeaderText = "Tổng doanh thu";
            this.colTongDoanhThu.MinimumWidth = 6;
            this.colTongDoanhThu.Name = "colTongDoanhThu";
            this.colTongDoanhThu.ReadOnly = true;
            // 
            // pnlChiTietMonAn
            // 
            this.pnlChiTietMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChiTietMonAn.Controls.Add(this.chartMonAn);
            this.pnlChiTietMonAn.Controls.Add(this.dgvMonAn);
            this.pnlChiTietMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChiTietMonAn.Location = new System.Drawing.Point(13, 12);
            this.pnlChiTietMonAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlChiTietMonAn.Name = "pnlChiTietMonAn";
            this.pnlChiTietMonAn.Size = new System.Drawing.Size(1153, 457);
            this.pnlChiTietMonAn.TabIndex = 1;
            this.pnlChiTietMonAn.Visible = false;
            // 
            // chartMonAn
            // 
            this.chartMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMonAn.Location = new System.Drawing.Point(0, 369);
            this.chartMonAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartMonAn.Name = "chartMonAn";
            this.chartMonAn.Size = new System.Drawing.Size(1151, 86);
            this.chartMonAn.TabIndex = 1;
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AllowUserToAddRows = false;
            this.dgvMonAn.AllowUserToDeleteRows = false;
            this.dgvMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMonAn,
            this.colTenMonAn,
            this.colSoLuong,
            this.colDoanhThu});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonAn.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvMonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMonAn.Location = new System.Drawing.Point(0, 0);
            this.dgvMonAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersWidth = 51;
            this.dgvMonAn.Size = new System.Drawing.Size(1151, 369);
            this.dgvMonAn.TabIndex = 0;
            // 
            // colMaMonAn
            // 
            this.colMaMonAn.DataPropertyName = "MaMonAn";
            this.colMaMonAn.HeaderText = "Mã món ăn";
            this.colMaMonAn.MinimumWidth = 6;
            this.colMaMonAn.Name = "colMaMonAn";
            this.colMaMonAn.ReadOnly = true;
            // 
            // colTenMonAn
            // 
            this.colTenMonAn.DataPropertyName = "TenMonAn";
            this.colTenMonAn.HeaderText = "Tên món ăn";
            this.colTenMonAn.MinimumWidth = 6;
            this.colTenMonAn.Name = "colTenMonAn";
            this.colTenMonAn.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "TongSoLuong";
            this.colSoLuong.HeaderText = "Số lượng đã bán";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colDoanhThu
            // 
            this.colDoanhThu.DataPropertyName = "TongDoanhThu";
            this.colDoanhThu.HeaderText = "Doanh thu";
            this.colDoanhThu.MinimumWidth = 6;
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.ReadOnly = true;
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlChiTietDoanhThu.ResumeLayout(false);
            this.pnlTongDoanhThu.ResumeLayout(false);
            this.pnlTongDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.pnlChiTietMonAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox txtSoLuongHienThi;
        private System.Windows.Forms.Label lblSoLuongHienThi;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.Button btnBaoCaoMonAn;
        private System.Windows.Forms.Button btnBaoCaoDoanhThu;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlChiTietDoanhThu;
        private System.Windows.Forms.Panel pnlTongDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThuTitle;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongDoanhThu;
        private System.Windows.Forms.Panel pnlChiTietMonAn;
        private System.Windows.Forms.Panel chartMonAn;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThu;
    }
}
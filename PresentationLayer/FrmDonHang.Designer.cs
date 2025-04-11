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
            this.dgv_MonDaChon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonDaChon)).BeginInit();
            this.SuspendLayout();
            // 
            // fLP_Menu
            // 
            this.fLP_Menu.Location = new System.Drawing.Point(458, 12);
            this.fLP_Menu.Name = "fLP_Menu";
            this.fLP_Menu.Size = new System.Drawing.Size(330, 371);
            this.fLP_Menu.TabIndex = 0;
            // 
            // dgv_MonDaChon
            // 
            this.dgv_MonDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonDaChon.Location = new System.Drawing.Point(13, 68);
            this.dgv_MonDaChon.Name = "dgv_MonDaChon";
            this.dgv_MonDaChon.RowHeadersWidth = 51;
            this.dgv_MonDaChon.RowTemplate.Height = 24;
            this.dgv_MonDaChon.Size = new System.Drawing.Size(439, 315);
            this.dgv_MonDaChon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(458, 390);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(153, 48);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu order";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(635, 390);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(153, 48);
            this.btn_ThanhToan.TabIndex = 4;
            this.btn_ThanhToan.Text = "ThanhToan";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // FrmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_MonDaChon);
            this.Controls.Add(this.fLP_Menu);
            this.Name = "FrmDonHang";
            this.Text = "FrmDonHang";
            this.Load += new System.EventHandler(this.FrmDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonDaChon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLP_Menu;
        private System.Windows.Forms.DataGridView dgv_MonDaChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_ThanhToan;
    }
}
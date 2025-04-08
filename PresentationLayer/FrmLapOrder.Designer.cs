namespace PresentationLayer
{
    partial class FrmLapOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxt_Note = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox_PhucVuChinh = new System.Windows.Forms.ComboBox();
            this.cbox_LoaiKhach = new System.Windows.Forms.ComboBox();
            this.cbox_Ban = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phục vụ chính";
            // 
            // rtxt_Note
            // 
            this.rtxt_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_Note.Location = new System.Drawing.Point(3, 273);
            this.rtxt_Note.Name = "rtxt_Note";
            this.rtxt_Note.Size = new System.Drawing.Size(601, 46);
            this.rtxt_Note.TabIndex = 5;
            this.rtxt_Note.Text = "Ghi chú khác";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lập Order";
            // 
            // cbox_PhucVuChinh
            // 
            this.cbox_PhucVuChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_PhucVuChinh.FormattingEnabled = true;
            this.cbox_PhucVuChinh.Items.AddRange(new object[] {
            "Thu ngân chiều",
            "Thu ngân sáng",
            "Nguyễn Thị Kim Ngân",
            "Huỳnh Kim Lượm"});
            this.cbox_PhucVuChinh.Location = new System.Drawing.Point(192, 223);
            this.cbox_PhucVuChinh.Name = "cbox_PhucVuChinh";
            this.cbox_PhucVuChinh.Size = new System.Drawing.Size(286, 33);
            this.cbox_PhucVuChinh.TabIndex = 8;
            // 
            // cbox_LoaiKhach
            // 
            this.cbox_LoaiKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_LoaiKhach.FormattingEnabled = true;
            this.cbox_LoaiKhach.Items.AddRange(new object[] {
            "Khách",
            "Đối tác",
            "Nhân viên",
            "Quản lý"});
            this.cbox_LoaiKhach.Location = new System.Drawing.Point(192, 172);
            this.cbox_LoaiKhach.Name = "cbox_LoaiKhach";
            this.cbox_LoaiKhach.Size = new System.Drawing.Size(286, 33);
            this.cbox_LoaiKhach.TabIndex = 9;
            // 
            // cbox_Ban
            // 
            this.cbox_Ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Ban.FormattingEnabled = true;
            this.cbox_Ban.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7"});
            this.cbox_Ban.Location = new System.Drawing.Point(192, 65);
            this.cbox_Ban.Name = "cbox_Ban";
            this.cbox_Ban.Size = new System.Drawing.Size(286, 33);
            this.cbox_Ban.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(192, 116);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 30);
            this.numericUpDown1.TabIndex = 13;
            // 
            // FrmLapOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(610, 331);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbox_Ban);
            this.Controls.Add(this.cbox_LoaiKhach);
            this.Controls.Add(this.cbox_PhucVuChinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxt_Note);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLapOrder";
            this.Text = "                                               Lập Order";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxt_Note;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbox_PhucVuChinh;
        private System.Windows.Forms.ComboBox cbox_LoaiKhach;
        private System.Windows.Forms.ComboBox cbox_Ban;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
namespace PresentationLayer
{
    partial class FrmAdmin
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
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_DisplayName = new System.Windows.Forms.Label();
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Location = new System.Drawing.Point(88, 54);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(102, 16);
            this.lb_Username.TabIndex = 0;
            this.lb_Username.Text = "Tên Đăng Nhập";
            // 
            // lb_DisplayName
            // 
            this.lb_DisplayName.AutoSize = true;
            this.lb_DisplayName.Location = new System.Drawing.Point(88, 106);
            this.lb_DisplayName.Name = "lb_DisplayName";
            this.lb_DisplayName.Size = new System.Drawing.Size(78, 16);
            this.lb_DisplayName.TabIndex = 1;
            this.lb_DisplayName.Text = "Tên hiển thị ";
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Location = new System.Drawing.Point(88, 164);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(17, 16);
            this.lb_Welcome.TabIndex = 2;
            this.lb_Welcome.Text = "\"\"";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Welcome);
            this.Controls.Add(this.lb_DisplayName);
            this.Controls.Add(this.lb_Username);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_DisplayName;
        private System.Windows.Forms.Label lb_Welcome;
    }
}
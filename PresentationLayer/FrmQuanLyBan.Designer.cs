namespace PresentationLayer
{
    partial class FrmQuanLyBan
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tầngTrệtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lầuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mangVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chínToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tầngTrệtToolStripMenuItem,
            this.lầuToolStripMenuItem,
            this.mangVềToolStripMenuItem,
            this.beeToolStripMenuItem,
            this.grabToolStripMenuItem,
            this.shopeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tầngTrệtToolStripMenuItem
            // 
            this.tầngTrệtToolStripMenuItem.Name = "tầngTrệtToolStripMenuItem";
            this.tầngTrệtToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.tầngTrệtToolStripMenuItem.Text = "Tầng trệt";
            // 
            // lầuToolStripMenuItem
            // 
            this.lầuToolStripMenuItem.Name = "lầuToolStripMenuItem";
            this.lầuToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.lầuToolStripMenuItem.Text = "Lầu";
            // 
            // beeToolStripMenuItem
            // 
            this.beeToolStripMenuItem.Name = "beeToolStripMenuItem";
            this.beeToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.beeToolStripMenuItem.Text = "Bee";
            // 
            // grabToolStripMenuItem
            // 
            this.grabToolStripMenuItem.Name = "grabToolStripMenuItem";
            this.grabToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.grabToolStripMenuItem.Text = "Grab";
            // 
            // shopeeToolStripMenuItem
            // 
            this.shopeeToolStripMenuItem.Name = "shopeeToolStripMenuItem";
            this.shopeeToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.shopeeToolStripMenuItem.Text = "Shopee";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(812, 436);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // mangVềToolStripMenuItem
            // 
            this.mangVềToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chínToolStripMenuItem,
            this.sốngToolStripMenuItem});
            this.mangVềToolStripMenuItem.Name = "mangVềToolStripMenuItem";
            this.mangVềToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.mangVềToolStripMenuItem.Text = "Mang về";
            // 
            // chínToolStripMenuItem
            // 
            this.chínToolStripMenuItem.Name = "chínToolStripMenuItem";
            this.chínToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chínToolStripMenuItem.Text = "Chín";
            // 
            // sốngToolStripMenuItem
            // 
            this.sốngToolStripMenuItem.Name = "sốngToolStripMenuItem";
            this.sốngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sốngToolStripMenuItem.Text = "Sống";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 128);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 502);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmQuanLyBan";
            this.Text = "FrmQuanLyBan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tầngTrệtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lầuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopeeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem mangVềToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chínToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốngToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}


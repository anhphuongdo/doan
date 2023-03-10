
namespace doan
{
    partial class frmNV
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCủaTôiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtTàiKhoảnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panel);
            this.panelContainer.Controls.Add(this.menuStrip1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(896, 533);
            this.panelContainer.TabIndex = 2;
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(896, 509);
            this.panel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.tạoHóaĐơnToolStripMenuItem,
            this.xemBáoCáoToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem1,
            this.thôngBáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiSảnPhẩmToolStripMenuItem});
            this.trangChủToolStripMenuItem.Image = global::doan.Properties.Resources.home;
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // loạiSảnPhẩmToolStripMenuItem
            // 
            this.loạiSảnPhẩmToolStripMenuItem.Name = "loạiSảnPhẩmToolStripMenuItem";
            this.loạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loạiSảnPhẩmToolStripMenuItem.Text = "Loại Sản Phẩm";
            this.loạiSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.loạiSảnPhẩmToolStripMenuItem_Click);
            // 
            // tạoHóaĐơnToolStripMenuItem
            // 
            this.tạoHóaĐơnToolStripMenuItem.Image = global::doan.Properties.Resources.add;
            this.tạoHóaĐơnToolStripMenuItem.Name = "tạoHóaĐơnToolStripMenuItem";
            this.tạoHóaĐơnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F10)));
            this.tạoHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.tạoHóaĐơnToolStripMenuItem.Text = "Tạo hóa đơn";
            // 
            // xemBáoCáoToolStripMenuItem
            // 
            this.xemBáoCáoToolStripMenuItem.Image = global::doan.Properties.Resources.report;
            this.xemBáoCáoToolStripMenuItem.Name = "xemBáoCáoToolStripMenuItem";
            this.xemBáoCáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F11)));
            this.xemBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.xemBáoCáoToolStripMenuItem.Text = "Xem báo cáo ";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Image = global::doan.Properties.Resources.customer;
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem1
            // 
            this.thôngTinCáNhânToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCủaTôiToolStripMenuItem1,
            this.càiĐặtTàiKhoảnToolStripMenuItem1});
            this.thôngTinCáNhânToolStripMenuItem1.Image = global::doan.Properties.Resources.Người_dùng;
            this.thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
            this.thôngTinCáNhânToolStripMenuItem1.Size = new System.Drawing.Size(131, 20);
            this.thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
            // 
            // thôngTinCủaTôiToolStripMenuItem1
            // 
            this.thôngTinCủaTôiToolStripMenuItem1.Name = "thôngTinCủaTôiToolStripMenuItem1";
            this.thôngTinCủaTôiToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.thôngTinCủaTôiToolStripMenuItem1.Text = "Thông tin của tôi";
            this.thôngTinCủaTôiToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinCủaTôiToolStripMenuItem1_Click);
            // 
            // càiĐặtTàiKhoảnToolStripMenuItem1
            // 
            this.càiĐặtTàiKhoảnToolStripMenuItem1.Name = "càiĐặtTàiKhoảnToolStripMenuItem1";
            this.càiĐặtTàiKhoảnToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.càiĐặtTàiKhoảnToolStripMenuItem1.Text = "Cài đặt tài khoản";
            this.càiĐặtTàiKhoảnToolStripMenuItem1.Click += new System.EventHandler(this.càiĐặtTàiKhoảnToolStripMenuItem1_Click);
            // 
            // thôngBáoToolStripMenuItem
            // 
            this.thôngBáoToolStripMenuItem.Image = global::doan.Properties.Resources.tin_tức;
            this.thôngBáoToolStripMenuItem.Name = "thôngBáoToolStripMenuItem";
            this.thôngBáoToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.thôngBáoToolStripMenuItem.Text = "Thông báo";
            this.thôngBáoToolStripMenuItem.Click += new System.EventHandler(this.thôngBáoToolStripMenuItem_Click);
            // 
            // frmNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 533);
            this.Controls.Add(this.panelContainer);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNV";
            this.Text = "frmNV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNV_FormClosing);
            this.Load += new System.EventHandler(this.frmNV_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tạoHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngBáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCủaTôiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtTàiKhoảnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loạiSảnPhẩmToolStripMenuItem;
    }
}
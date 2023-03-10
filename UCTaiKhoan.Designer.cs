
namespace doan
{
    partial class UCTaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.mkcu = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.xacnhan = new System.Windows.Forms.PictureBox();
            this.mkmoi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mkcu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xacnhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkmoi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(93, 276);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 13);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(331, 109);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(378, 20);
            this.txtOldPass.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(331, 181);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(378, 20);
            this.txtNewPass.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(503, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu thay đổi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Xác nhận mật khẩu mới";
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(331, 254);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(378, 20);
            this.txtCheck.TabIndex = 2;
            // 
            // mkcu
            // 
            this.mkcu.Image = global::doan.Properties.Resources.Xem;
            this.mkcu.Location = new System.Drawing.Point(726, 109);
            this.mkcu.Name = "mkcu";
            this.mkcu.Size = new System.Drawing.Size(25, 20);
            this.mkcu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mkcu.TabIndex = 41;
            this.mkcu.TabStop = false;
            this.mkcu.Click += new System.EventHandler(this.mkcu_Click);
            // 
            // avatar
            // 
            this.avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatar.Image = global::doan.Properties.Resources.Người_dùng;
            this.avatar.Location = new System.Drawing.Point(59, 125);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(148, 136);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 23;
            this.avatar.TabStop = false;
            // 
            // xacnhan
            // 
            this.xacnhan.Image = global::doan.Properties.Resources.Xem;
            this.xacnhan.Location = new System.Drawing.Point(726, 254);
            this.xacnhan.Name = "xacnhan";
            this.xacnhan.Size = new System.Drawing.Size(25, 20);
            this.xacnhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.xacnhan.TabIndex = 42;
            this.xacnhan.TabStop = false;
            this.xacnhan.Click += new System.EventHandler(this.xacnhan_Click);
            // 
            // mkmoi
            // 
            this.mkmoi.Image = global::doan.Properties.Resources.Xem;
            this.mkmoi.Location = new System.Drawing.Point(726, 181);
            this.mkmoi.Name = "mkmoi";
            this.mkmoi.Size = new System.Drawing.Size(25, 17);
            this.mkmoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mkmoi.TabIndex = 43;
            this.mkmoi.TabStop = false;
            this.mkmoi.Click += new System.EventHandler(this.mkmoi_Click);
            // 
            // UCTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.mkmoi);
            this.Controls.Add(this.xacnhan);
            this.Controls.Add(this.mkcu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.avatar);
            this.Name = "UCTaiKhoan";
            this.Size = new System.Drawing.Size(896, 509);
            this.Load += new System.EventHandler(this.UCTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mkcu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xacnhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkmoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.PictureBox mkcu;
        private System.Windows.Forms.PictureBox xacnhan;
        private System.Windows.Forms.PictureBox mkmoi;
    }
}

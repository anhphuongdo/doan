using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using doan.BLL;
using doan.DTO;

namespace doan
{
    public partial class UCTaiKhoan : UserControl
    {
        public UCTaiKhoan()
        {
            InitializeComponent();
            txtOldPass.UseSystemPasswordChar = true;
            txtNewPass.UseSystemPasswordChar = true;
            txtCheck.UseSystemPasswordChar = true;
        }

        private static UCTaiKhoan _instance;
        public static UCTaiKhoan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCTaiKhoan();
                return _instance;
            }
        }

        private void mkcu_Click(object sender, EventArgs e)
        {
            if(txtOldPass.UseSystemPasswordChar == true)
            {
                txtOldPass.UseSystemPasswordChar = false;
            }
            else { txtOldPass.UseSystemPasswordChar = true; }
        }

        private void mkmoi_Click(object sender, EventArgs e)
        {
            if (txtNewPass.UseSystemPasswordChar == true)
            {
                txtNewPass.UseSystemPasswordChar = false;
            }
            else { txtNewPass.UseSystemPasswordChar = true; }
        }

        private void xacnhan_Click(object sender, EventArgs e)
        {
            if (txtCheck.UseSystemPasswordChar == true)
            {
                txtCheck.UseSystemPasswordChar = false;
            }
            else { txtCheck.UseSystemPasswordChar = true; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCheck.Text == txtNewPass.Text)
            {
                MessageBox.Show("Đổi mật khẩu thành công", "thông báo!");
            }
        }

        private void UCTaiKhoan_Load(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
        }
    }
}

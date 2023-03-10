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
    public partial class UCProfile : UserControl
    {
        public UCProfile()
        {
            InitializeComponent();
        }
        private static UCProfile _instance;
        public static UCProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCProfile();
                return _instance;
            }
        }
        private void Load_Data_GridView()
        {
            NhanVienDTO nv = new NhanVienDTO();
            List<CaLamDTO> ListCa = CaLamBLL.EF_GetShift(nv);
            dgvCaLam.DataSource = ListCa;
        }
        private void btnSave_Enter(object sender, EventArgs e)
        {

        }

        private void UCProfile_Load(object sender, EventArgs e)
        {
            Load_Data_GridView();
            NhanVienDTO nv = new NhanVienDTO();
            txtChucVu.Text = nv.ChucVu;
            txtGioiTinh.Text = nv.GioiTinh;
            txtDiaChi.Text = nv.DiaChi;
            txtEmail.Text = nv.Email;
            txtLuong.Text = nv.MucLuong.ToString();
            txtSDT.Text = nv.SDT;
            txtSoCong.Text = nv.SoCong.ToString();
            txtUsername.Text = nv.Username;
            txtNgaySinh.Text = nv.NgaySinh;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}

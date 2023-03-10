using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using doan.DTO;
using doan.BLL;

namespace doan
{
    public partial class UCCustomer : UserControl
    {
        public UCCustomer()
        {
            InitializeComponent();
            dgvDSKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private static UCCustomer _instance;
        public static UCCustomer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCCustomer();
                return _instance;
            }
        }
        private void Load_Data_GridView()
        {
            List<KhachHangDTO> listKH = KhachHangBLL.EF_GetAll();
            dgvDSKH.DataSource = listKH;
        }


        private void UCCustomer_Load(object sender, EventArgs e)
        {
            Load_Data_GridView();
        }

        private void dgvDSKH_SelectionChanged(object sender, EventArgs e)
        {
            txtMaKH.ReadOnly = true;
            int n = dgvDSKH.CurrentRow.Index;
            txtMaKH.Text = dgvDSKH.Rows[n].Cells[0].Value.ToString();
            txtHoten.Text = dgvDSKH.Rows[n].Cells[1].Value.ToString();
            txtEmail.Text = dgvDSKH.Rows[n].Cells[2].Value.ToString();
            txtSDT.Text = dgvDSKH.Rows[n].Cells[3].Value.ToString();
            if(dgvDSKH.Rows[n].Cells[4].Value.ToString() == "1")
            {
                ckBVIP.Checked = true;
            }
            if (dgvDSKH.Rows[n].Cells[4].Value.ToString() == "0")
            {
                ckBVIP.Checked = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKH = txtMaKH.Text;
            kh.Email = txtEmail.Text;
            kh.TenKH = txtHoten.Text;
            kh.SDT = txtSDT.Text;
            kh.TrangThai = true;
            if (ckBVIP.Checked == false)
            {
                kh.VIP = true;
            }
            else { kh.VIP = false; }
            KhachHangBLL.EF_Edit(kh);
            Load_Data_GridView();
            MessageBox.Show("Chỉnh sửa thành công", "Thông báo");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKH = txtMaKH.Text;
                kh.Email = txtEmail.Text;
                kh.TenKH = txtHoten.Text;
                kh.SDT = txtSDT.Text;
                kh.TrangThai = false;
                if (ckBVIP.Checked == true)
                {
                    kh.VIP = true;
                }
                else { kh.VIP = false; }
                KhachHangBLL.EF_Delete(kh);
                Load_Data_GridView();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else { return; }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            List<KhachHangDTO> listKH = KhachHangBLL.EF_GetReallyAll();
            int sl = listKH.Count;
            txtMaKH.Text = "KH00" + sl;
            txtHoten.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            ckBVIP.Checked = false;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtHoten.Text;
            kh.Email = txtEmail.Text;
            kh.SDT = txtSDT.Text;
            kh.TrangThai = true;
            if (ckBVIP.Checked == true)
            {
                kh.VIP = true;
            }
            else { kh.VIP = false; }
            KhachHangBLL.EF_AddNew(kh);
            Load_Data_GridView();
            MessageBox.Show("Lưu thành công", "Thông báo");
        }
    }
}

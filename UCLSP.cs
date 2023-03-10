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
    public partial class UCLSP : UserControl
    {
        public UCLSP()
        {
            InitializeComponent();
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cbLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private static UCLSP _instance;
        public static UCLSP Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCLSP();
                return _instance;
            }
        }
        private void Load_Data_GridView()
        {
            List<SanPhamDTO> listsp = SanPhamBLL.EF_GetAll();
            dgvSanPham.DataSource = listsp;
        }

        private void UCLSP_Load(object sender, EventArgs e)
        {
            List<LoaiSanPhamDTO> listlsp = LoaiSanPhamBLL.EF_GetAll();
            dgvSanPham.DataSource = listlsp;
            cbLoaiSP.DataSource = listlsp;
            cbLoaiSP.DisplayMember = "TenLoai";
            cbLoaiSP.ValueMember = "MaLoai";
            List<SanPhamDTO> listsp = SanPhamBLL.EF_GetAll();
            dgvSanPham.DataSource = listsp;
        }

        private void btnFindLSP_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text != "" && txtAnd.Text != "")
            {
                Load_Data_GridView();
                int a = int.Parse(txtFrom.Text);
                int b = int.Parse(txtAnd.Text);
                SanPhamDTO lspwp = new SanPhamDTO();
                lspwp.MaLoai = cbLoaiSP.SelectedValue.ToString();
                List<SanPhamDTO> listLSPwP = SanPhamBLL.EF_GetLsPWithPrice(a, b, lspwp);
                dgvSanPham.DataSource = listLSPwP;
            }
            else
            {
                Load_Data_GridView();
                SanPhamDTO lsp = new SanPhamDTO();
                lsp.MaLoai = cbLoaiSP.SelectedValue.ToString();
                List<SanPhamDTO> listLSP = SanPhamBLL.EF_FindLSP(lsp);
                dgvSanPham.DataSource = listLSP;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Load_Data_GridView();
        }
    }
}

using doan.BLL;
using doan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private static UCHome _instance;
        public static UCHome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCHome();
                return _instance;
            }
        }
        private void Load_Data_GridView()
        {
            List<SanPhamDTO> listsp = SanPhamBLL.EF_GetAll();
            dgvSanPham.DataSource = listsp;
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            Load_Data_GridView();
            txtSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            addTenSP(DataCollection);
            txtSP.AutoCompleteCustomSource = DataCollection;

            txtMSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollections = new AutoCompleteStringCollection();
            addMaSP(DataCollections);
            txtMSP.AutoCompleteCustomSource = DataCollections;
        }

        private void txtSP_TextChanged_1(object sender, EventArgs e)
        {
            if(txtSP.Text != "")
            {
                txtMSP.Text = "";
                txtAnd.Text = "";
                txtFrom.Text = "";
            }
        }

        private void txtMSP_TextChanged_1(object sender, EventArgs e)
        {
            if(txtMSP.Text != "")
            {
                txtSP.Text = "";
                txtAnd.Text = "";
                txtFrom.Text = "";
            }
        }

        private void btnFindSP_Click(object sender, EventArgs e)
        {
            if(txtMSP.Text != "") {
                Load_Data_GridView();
                SanPhamDTO masp = new SanPhamDTO();
                masp.MaSP = txtMSP.Text;
                List<SanPhamDTO> listKQ = SanPhamBLL.EF_FindMSP(masp);
                dgvSanPham.DataSource = listKQ;
            }
            if(txtSP.Text != "")
            {
                Load_Data_GridView();
                SanPhamDTO sp = new SanPhamDTO();
                sp.TenSP = txtSP.Text;
                List<SanPhamDTO> listSP = SanPhamBLL.EF_FindSP(sp);
                dgvSanPham.DataSource = listSP;
            }
            if(txtFrom.Text != "" && txtAnd.Text != "")
            {
                int a = int.Parse(txtFrom.Text);
                int b = int.Parse(txtAnd.Text);
                Load_Data_GridView();
                List<SanPhamDTO> listPrice = SanPhamBLL.EF_Price(a,b);
                dgvSanPham.DataSource = listPrice;
                
            }
        }
        public static void addTenSP(AutoCompleteStringCollection col)
        {
            List<SanPhamDTO> a = SanPhamBLL.EF_GetAll();
            foreach (SanPhamDTO sp in a)
            {
                col.Add(sp.TenSP);
            }
        }
        public static void addMaSP(AutoCompleteStringCollection col)
        {
            List<SanPhamDTO> a = SanPhamBLL.EF_GetAll();
            foreach (SanPhamDTO sp in a)
            {
                col.Add(sp.MaSP);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Load_Data_GridView();
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            txtSP.Text = "";
            txtMSP.Text = "";
        }

        private void txtAnd_TextChanged(object sender, EventArgs e)
        {
            txtSP.Text = "";
            txtMSP.Text = "";
        }
    }
}

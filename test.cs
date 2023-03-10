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
    public partial class test : UserControl
    {
        public test()
        {
            InitializeComponent();
        }
        private static test _instance;
        public static test Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new test();
                return _instance;
            }
        }
        public static void truyvan() {
            QLNSEntities data = new QLNSEntities();
            var v = (from c in data.NhanViens
                     join m in data.PhanCongs on c.MaNV equals m.MaNV
                     where m.MaCa.Equals(cbbCaLam.Text)
                     && string.IsNullOrEmpty(cbbChucvu.SelectedItem.ToString()) ? false : c.ChucVu.Equals(cbbChucvu.SelectedItem.ToString())
                     && string.IsNullOrEmpty(cbbGioiTinh.SelectedItem.ToString()) ? true : c.GioiTinh.Equals(cbbGioiTinh.SelectedItem.ToString())
                     select c).ToList();
            dgv.DataSource = v;
        }
        
        private void test_Load(object sender, EventArgs e)
                {
                }
            }
        }

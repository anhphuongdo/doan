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
    public partial class frmNV : Form
    {
        public frmNV()
        {
            InitializeComponent();
        }

        private void frmNV_Load(object sender, EventArgs e)
        {
            UCHome uchome = new UCHome();
            panel.Controls.Add(uchome);
            uchome.BringToFront();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UCHome.Instance))
            {
                panel.Controls.Add(UCHome.Instance);
                UCHome.Instance.Dock = DockStyle.Fill;
                UCHome.Instance.BringToFront();
            }
            else
                UCHome.Instance.BringToFront();
        }

        private void thôngTinCủaTôiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UCProfile.Instance))
            {
                panel.Controls.Add(UCProfile.Instance);
                UCProfile.Instance.Dock = DockStyle.Fill;
                UCProfile.Instance.BringToFront();
            }
            else
                UCProfile.Instance.BringToFront();
        }

        private void càiĐặtTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UCTaiKhoan.Instance))
            {
                panel.Controls.Add(UCTaiKhoan.Instance);
                UCTaiKhoan.Instance.Dock = DockStyle.Fill;
                UCTaiKhoan.Instance.BringToFront();
            }
            else
                UCTaiKhoan.Instance.BringToFront();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UCCustomer.Instance))
            {
                panel.Controls.Add(UCCustomer.Instance);
                UCCustomer.Instance.Dock = DockStyle.Fill;
                UCCustomer.Instance.BringToFront();
            }
            else
                UCCustomer.Instance.BringToFront();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UCLSP.Instance))
            {
                panel.Controls.Add(UCLSP.Instance);
                UCLSP.Instance.Dock = DockStyle.Fill;
                UCLSP.Instance.BringToFront();
            }
            else
                UCLSP.Instance.BringToFront();
        }

        private void frmNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn chắc chắn muốn đóng form?", "Cảnh báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void thôngBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(test.Instance))
            {
                panel.Controls.Add(test.Instance);
                test.Instance.Dock = DockStyle.Fill;
                test.Instance.BringToFront();
            }
            else
                test.Instance.BringToFront();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        //private Dictionary<string, CNhaSanXuat> ds;
        private List<CNhaSanXuat> ds;
        private void hienDSNhaSanXuat()
        {
            //dgvNSX.DataSource = ds.Values.ToList();
            dgvNSX.DataSource = ds.ToList();
        }
        private CNhaSanXuat tim(string mansx)
        {
            //try
            //{
            //    return ds[mansx];
            //}
            //catch
            //{
            //    return null;
            //}
            foreach(CNhaSanXuat n in ds)
            {
                if(n.MaNSX==mansx)
                    return n;
            }
            return null;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CNhaSanXuat n=new CNhaSanXuat();
            n.MaNSX=txtMaNSX.Text;
            n.TenNSX=txtTenNSX.Text;
            n.SoDT=txtSoDT.Text;
            n.DiaChi = txtDiaChi.Text;
            if (tim(n.MaNSX)==null)
            {
                //ds.Add(n.MaNSX, n);
                ds.Add(n);
                hienDSNhaSanXuat();
            }
            else
            {
                MessageBox.Show("Mã NSX " + n.MaNSX + " đã tồn tại. Ko thêm được.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ds = new Dictionary<string, CNhaSanXuat>();
            ds = new List<CNhaSanXuat>();

        }

        private void dgvNSX_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNSX.Text = dgvNSX.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNSX.Text = dgvNSX.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoDT.Text = dgvNSX.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNSX.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CNhaSanXuat kq = tim(txtMaNSX.Text);
            if (kq != null)
            {
                //ds.Remove(txtMaNSX.Text);
                ds.Remove(kq);
                hienDSNhaSanXuat();
            }
            else
            {
                MessageBox.Show("Mã NSX " + txtMaNSX.Text + " ko đã tồn tại. Ko xóa được.");
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CNhaSanXuat kq=tim(txtMaNSX.Text);
            if (kq != null)
            {
                kq.TenNSX = txtTenNSX.Text;
                kq.SoDT = txtSoDT.Text;
                kq.DiaChi = txtDiaChi.Text;
                hienDSNhaSanXuat();
            }
            else
            {
                MessageBox.Show("Mã NSX " + txtMaNSX.Text + " ko đã tồn tại. Ko sửa được.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            InitView();
        }
        private void InitView()
        {
            this.rdBtnKD.Checked = true;
            this.tbSlSP.Enabled = false;


        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            Nhanvien nv;

            string MSNV = this.txtbMS.Text;
            string hoten = this.txtBHoten.Text;
            bool isNVKinhDoang = this.rdBtnKD.Checked;
            if (isNVKinhDoang)
            {
                int luongcoban = int.Parse(this.tbLCB.Text);
                int soluongHD = int.Parse(this.tbSLHD.Text);
                nv = new nhanvienKD(MSNV, hoten, luongcoban, soluongHD);
            }
            else 
            {
                int soluongSP = int.Parse(this.tbSlSP.Text);
                nv = new nhanvienSX(MSNV, hoten, soluongSP);
            }
            this.lbLuongNV.Text = nv.TinhLuong().ToString();

        }
        private void cleartextbox()
        {
            this.tbSlSP.Text = "";
            this.tbLCB.Text = "";
            this.tbSLHD.Text = "";
        }

        private void rdBtnSX_CheckedChanged(object sender, EventArgs e)
        {
            this.tbSlSP.Enabled = true;
            this.tbLCB.Enabled = false;
            this.tbSLHD.Enabled = false;

        }

        private void rdBtnKD_CheckedChanged(object sender, EventArgs e)
        {
            this.tbSlSP.Enabled = false;
            this.tbLCB.Enabled = true;
            this.tbSLHD.Enabled = true;
        }
    }
}

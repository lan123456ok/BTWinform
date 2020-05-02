using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnTongPS_Click(object sender, EventArgs e)
        {
            int tusoA = int.Parse(this.tbTuSoa.Text);
            int mausoA = int.Parse(this.tbmauSoa.Text);
            int tusoB = int.Parse(this.tbtusob.Text);
            int mausoB = int.Parse(this.tbmausob.Text);

            Phanso kq = new Phanso(tusoA, mausoA) + new Phanso(tusoB, mausoB);
            kq = Phanso.Reduce(kq);
            this.lbKQ.Text = "Ket qua cong hai phan so:" + kq.tuso + "/" + kq.mauso;
        }
    }
}

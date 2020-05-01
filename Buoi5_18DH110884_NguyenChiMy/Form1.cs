using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_18DH110884_NguyenChiMy
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
           
        }

        private void btnXuLLy_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.tbx.Text);
            int y = int.Parse(this.txtY.Text);

            MessageBox.Show("x mu y là"+ Math.Pow(x,y));
        }
    }
}

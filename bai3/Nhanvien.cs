using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class Nhanvien
    {

        public string MSNV;
         public string hoten;

        public Nhanvien(string MSNV, string hoten)
        {
            this.MSNV = MSNV;
            this.hoten = hoten;
        }

        public virtual int TinhLuong()
        {
            return 0;
        }

    }
}

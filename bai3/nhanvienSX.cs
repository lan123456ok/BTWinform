using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class nhanvienSX : Nhanvien
    {
        public nhanvienSX(string MSNV, string hoten,int SlSanpham) : base(MSNV, hoten) {
            this.SLSanpham = SlSanpham;
        }

        public static int TienCuaMotSP = 1000;

        public int SLSanpham
        {
            get { return _SLSanpham; }
            set { _SLSanpham = value; }
        }
        public int _SLSanpham = 0;



        public int TinhLuong()
        {
            if (this.SLSanpham < 3000)
            {
                return this.SLSanpham + nhanvienSX.TienCuaMotSP;
            }
            else
            {
                return (int)((this.SLSanpham + nhanvienSX.TienCuaMotSP) * 1.05);
            }

        }


    }
}

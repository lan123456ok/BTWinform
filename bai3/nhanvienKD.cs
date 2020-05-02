using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class nhanvienKD : Nhanvien
    {
       

        public static int TienCuaMotHD = 500000;
        private int _SLHopdong = 0;
        public int SlHopdong
        {
            get { return _SLHopdong; }
            set { _SLHopdong = value; }
        }

        public int _luongCoBan = 0;

        public int LuongCoBan
        {
            get { return _luongCoBan; }
            set { _luongCoBan = value; }
        }
        public nhanvienKD(string MSNV, string hoten, int LuongCoBan, int SlHopdong ) : base(MSNV, hoten) {
            this.LuongCoBan = LuongCoBan;
            this.SlHopdong = SlHopdong;
        }

        public override int TinhLuong()
        {
            return this.LuongCoBan + this.SlHopdong * nhanvienKD.TienCuaMotHD;
        }

    }
}

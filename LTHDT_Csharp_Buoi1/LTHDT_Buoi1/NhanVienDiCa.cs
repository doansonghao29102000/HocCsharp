using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_Buoi1
{
    public class NhanVienDiCa : NhanVien
    {
        public string ca { get; set; }

        //override phuong tich tinh luong

        public new double TinhLuong()
        {
            return base.TinhLuong()*1.05;
        }

    }
}

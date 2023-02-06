using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_Buoi1
{
    public class NhanVien
    {
        public int maNV { get; set; }  
        public string tenNV { get; set; }

        public double TinhLuong()
        {
            return 1000;
        }

        public virtual double ThuongThuCong(int NgayCong)
        {
            if (NgayCong >= 26) return 100;
            else
            {
                return 0;
            }
        }
    }
}

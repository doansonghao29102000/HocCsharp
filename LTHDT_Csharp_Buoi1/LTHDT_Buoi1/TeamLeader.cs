using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_Buoi1
{
    public class TeamLeader : Developer
    {
        public long luongTrachNhiem { get; set; }

        public TeamLeader() : base()
        {
            luongTrachNhiem = 1000;
        }

        public TeamLeader(string hoTen, int namSinh, long luong, long tienTaiKhoan , long luongTrachNghiem)
            :base(hoTen,namSinh,luong,tienTaiKhoan)
        {
            this.luongTrachNhiem = luongTrachNghiem;

        }
        public override void nhapTT()
        {
            base.nhapTT();
            Console.WriteLine("Lương trách nhiệm : ");
            luongTrachNhiem = Convert.ToInt64(Console.ReadLine());
        }

        public new void inTT()
        {
            base.inTT();
            Console.WriteLine("Lương trách nhiệm : " + luongTrachNhiem);
        }
        public override string ToString()
        {
            return base.ToString() + this.tienTaiKhoan;
        }
        public new long tinhLuong()
        {
            return base.tinhLuong() + luongTrachNhiem;
        }
    }
}

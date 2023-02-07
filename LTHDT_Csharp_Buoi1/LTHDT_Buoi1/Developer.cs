using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_Buoi1
{
    public class Developer
    {
        #region atttribute
        public string hoTen { get; set; }
        public int namSinh { get; set; }
        public long luong { get; set;}
        public long tienTaiKhoan { get; set; }

        #endregion

        #region constructor no parameter
        public Developer() 
        {
            hoTen = "no name";
            namSinh = 2000;
            luong = 1000;
            tienTaiKhoan = 0;
        }
        #endregion

        #region constructor yes parameter
        ~Developer() { }

        public Developer(string hoTen, int namSinh, long luong, long tienTaiKhoan)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.luong = luong;
            this.tienTaiKhoan = tienTaiKhoan;
        }
        #endregion

        #region method input info
        public virtual void nhapTT()
        {
            Console.WriteLine("Họ tên : ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Năm sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Mức lương : ");
            luong= long.Parse(Console.ReadLine());
            Console.WriteLine("Số tiền trong tài khoảng : ");
            tienTaiKhoan = Convert.ToInt64(Console.ReadLine());
        }
        #endregion

        #region method generate info
        public void inTT()
        {
            Console.WriteLine("Họ tên : " + hoTen);
            Console.WriteLine("Năm sinh : " + namSinh);
            Console.WriteLine("Lương : " + luong);
            Console.WriteLine("Tiền trong tài khoản : " + tienTaiKhoan);
        }
        #endregion

        #region method to string
        public override string ToString()
        {
            return this.hoTen + "/" + this.namSinh + "/" + this.luong + "/" + this.tienTaiKhoan;
        }
        #endregion

        #region salary
        public long tinhLuong()
        {
            return tienTaiKhoan + luong;
        }
        #endregion
    }
}

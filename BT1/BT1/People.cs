using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    public class People
    {
        #region atttribute
        public string hoTen { get; set; }
        public int tuoi { get; set; }
        public string gioiTinh { get; set; }
        #endregion
        
        #region constructor no parameter
        public People() 
        {
            hoTen = "xxx";
            tuoi = 1;
            gioiTinh = "Nam";

        }
        #endregion

        #region constructor yes parameter
        public People(string hoTen, int tuoi, string gioiTinh)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
        }
        #endregion

        #region desconstructor
        ~People() { }
        #endregion

        #region input info
        public void nhapTT()
        {
            Console.Write("Nhập họ tên : " );
            hoTen = Console.ReadLine();
            Console.Write("Nhập tuổi : ");
            tuoi = int.Parse( Console.ReadLine());
            Console.Write("Nhập giới tính : ");
            gioiTinh = Console.ReadLine();
        }
        #endregion

        #region generate info
        public void hienThi()
        {
            Console.WriteLine("Họ tên : " + hoTen);
            Console.WriteLine("Tuổi : " + tuoi);
            Console.WriteLine("Giới tính : " + gioiTinh);
        }

        public override string ToString()
        {
            return hoTen + "/" + tuoi + "/" + gioiTinh;
        }
        #endregion



    }
}

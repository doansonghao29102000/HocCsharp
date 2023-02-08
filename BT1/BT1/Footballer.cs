using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    public class Footballer : People
    {
        #region attribute
        public static int soCauThu; 
        // biến static dùng chung cho cả lớp , bao giờ ct hủy mới về 0
        // tạo đối tượng nào thì số cầu thủ sẽ tăng lên 
        public int soBanThang { get; set; }
        public double luong { get; set; }

        #endregion

        #region constructor no parameter
        public Footballer() : base() 
        {
            soCauThu++;
            soBanThang = 0;
            luong = 0;
        }

        #endregion

        #region constructor yes parameter
        public Footballer(string hoTen, int tuoi, string gioiTinh, int soBanThang, double luong)
            : base(hoTen, tuoi, gioiTinh)
        {
            this.soBanThang = soBanThang;
            this.luong = luong;
        }
        #endregion

        #region descontructor
        ~Footballer() { }

        #endregion

        #region input info
        public new void nhapTT()
        {
            base.nhapTT();
            Console.Write("Nhập số bàn thắng : ");
            soBanThang = int.Parse(Console.ReadLine());
            Console.Write("Nhập lương : ");
            luong = double.Parse(Console.ReadLine());
        }
        #endregion

        #region generate info
        public new void hienThi()
        {
            base.hienThi();
            Console.WriteLine("Số bàn thằng : " + soBanThang);
            Console.WriteLine("Lương : " + luong);

        }

        public override string ToString()
        {
            return base.ToString() + "/" + soBanThang + "/" +luong;
        }
        #endregion


    }
}

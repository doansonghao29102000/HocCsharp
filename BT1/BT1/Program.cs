using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            #region  a nhap n cau thu

            Footballer[] arr = new Footballer[100];
            int n = 0;
            Console.Write("Nhập số lượng cầu thủ : ");
            int.TryParse(Console.ReadLine() , out n);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Nhập thông tin cho cầu thủ thứ " + i);
                arr[i] = new Footballer();
                arr[i].nhapTT();
            }

            #endregion

            #region tang luong cho cau thu ghi tren 10 ban

            for (int i = 1; i <= n; i++)
            {
                if (arr[i].soBanThang > 10)
                {
                    arr[i].luong = arr[i].luong + arr[i].luong * 2 / 10;
                }
            }

            #endregion

            #region dua ra thong tin cau thu ghi nhieu ban nhat

            int maxn = 0;
            for (int i = 1; i <= n; i++)
            {
                if (maxn < arr[i].soBanThang) maxn = arr[i].soBanThang;
            }
            Console.WriteLine("danh sách cầu thủ ghi nhiều bàn nhất");
            for (int i = 1; i <= n; i++)
            {
                if (maxn == arr[i].soBanThang) Console.WriteLine(arr[i]); ;
            }
            #endregion

            Developer d = new Developer();
            d.HoTen = "xlxx";
            Console.WriteLine(d.HoTen);


        }
    }
}

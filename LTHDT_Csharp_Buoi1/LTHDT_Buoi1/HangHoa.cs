using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_Buoi1
{
    internal class HangHoa
    {
        //Khai báo thuộc tính hàng hóa
        private string MaHang { get; set; }
        private string TenHang { get; set; }
        private int SoLuong { get; set; }
        private long DonGia { get; set; }

        //Hàm khởi tạo không tham số
        public HangHoa()
        {
            MaHang = string.Empty;
            TenHang = string.Empty;
            SoLuong = 0;
            DonGia = 0;
        }
        //Hàm khởi tạo có tham số
        public HangHoa(string maHang, string tenHang, int soLuong, long donGia)
        {
            MaHang = maHang;
            TenHang = tenHang;
            SoLuong = soLuong;
            DonGia = donGia;
        }
        //Hàm nhập thông tin sinh viên
        public void Nhap()
        {
            Console.Write("Nhập mã hàng : ");
            MaHang = Console.ReadLine();
            Console.Write("Nhập tên hàng : ");
            TenHang = Console.ReadLine();
            Console.Write("Nhập số lượng : ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhập đơn giá : ");
            DonGia = int.Parse(Console.ReadLine());

        }
        //Hàm hiện thị thông tin sinh viên
        public void HienThi()
        {
            Console.WriteLine("{0} {1} {2} {3}", MaHang, TenHang, SoLuong, DonGia);
        }
        //Hàm sửa đơn giá
        public void Update(int DonG)
        {
            DonGia = DonG;
        }
    }
}

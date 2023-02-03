using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_Buoi1
{
    internal class SinhVien
    {
        //Khai báo thuộc tính sinh viên
        private string maSV { get; set; }
        private string tenSV { get; set; }
        private float dtb { get; set; }

        //Hàm khởi tạo không có tham số
        public SinhVien()
        {
            maSV = "";
            tenSV = "";
            dtb = 0.0f;
        }
        //Hàm khởi tạo có tham số
        public SinhVien(string maSV, string tenSV, float dtb)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.dtb = dtb;
        }
        //Hàm hủy
        ~SinhVien  () { }
        //Hàm nhập thông tin sinh viên
        public void Nhap()
        {
            Console.Write("Nhập mã sinh viên : ");
            maSV = Console.ReadLine();
            Console.Write("Nhập họ tên sinh viên : ");
            tenSV = Console.ReadLine();
            Console.Write("Nhập điểm trung bình : ");
            dtb = float.Parse(Console.ReadLine());

        }
        //Hàm hiển thị thông tin sinh viên
        public void HienThi()
        {
            Console.WriteLine("{0}   {1}   {2}", maSV, tenSV, dtb);
        }
    }
}

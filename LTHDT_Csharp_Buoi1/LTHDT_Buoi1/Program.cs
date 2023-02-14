using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LTHDT_Buoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //PhanSo ps1 = new PhanSo(1,4);
            //PhanSo ps2 = new PhanSo(1,4);
            //// PhanSo ps3 = ps1.Tong(ps2);
            //PhanSo ps3 = ps1.Thuong(ps2);
            ////ps3.NghichDao();
            //ps3.In();
            SinhVien sinhVien = new SinhVien(dtb: 9);
            sinhVien.HienThi();
            //sinhVien.maSV = "01";
            //Console.WriteLine(sinhVien.maSV);
            //Console.WriteLine(sinhVien.ToString());
            //Console.WriteLine(sinhVien);
            // Console.WriteLine(sinhVien.Tong(1,2));
            //Console.WriteLine(sinhVien.Tong(1,2,3));
            //Console.WriteLine(sinhVien.TBgpa(1, 2, 4, 5, 6, 7, 8));

            //NhanVien nhanVien = new NhanVien();
            //nhanVien.tenNV = "Nhân viên 1";
            //nhanVien.maNV = 1;
            //Console.WriteLine("{0}/{1}" , nhanVien.tenNV , nhanVien.maNV);
            //Console.WriteLine("Lương nhân viên : " + nhanVien.TinhLuong());

            //NhanVienHanhChinh nhanVienHanhChinh = new NhanVienHanhChinh();
            //nhanVienHanhChinh.tenNV = "Hành Chính";
            //Console.WriteLine("{0}/{1}", nhanVienHanhChinh.tenNV, nhanVienHanhChinh.maNV);
            //nhanVienHanhChinh.maNV = 2;
            //Console.WriteLine("Lương nhân viên hành chính : " + nhanVienHanhChinh.TinhLuong());

            //NhanVienDiCa nhanVienDiCa = new NhanVienDiCa();
            //nhanVienDiCa.maNV = 3;
            //nhanVienDiCa.tenNV = "Đi Ca";
            //nhanVienDiCa.ca = "Sáng";
            //Console.WriteLine("{0}/{1}/{2}", nhanVienDiCa.tenNV, nhanVienDiCa.maNV , nhanVienDiCa.ca);
            //Console.WriteLine("Lương nhân viên đi ca : " + nhanVienDiCa.TinhLuong());

            //Console.WriteLine(nhanVien.ThuongThuCong(26));
            //Console.WriteLine(nhanVienHanhChinh.ThuongThuCong(26));
            //Console.WriteLine(nhanVienDiCa.ThuongThuCong(26));

            //Developer d1 = new Developer();
            //Developer d2 = new Developer("Trần Thị Nở" , 2002 , 1500 , 3900);
            //TeamLeader t1 = new TeamLeader();
            //Console.WriteLine(t1);
            //TeamLeader[] a = new TeamLeader[100];
            //int n;
            //Console.WriteLine("Nhập số lượng TeamLeader : ");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    a[i] = new TeamLeader();
            //    a[i].nhapTT();

            //}

            //for (int i = 1; i <= n; i++)
            //{
            //    a[i] = new TeamLeader();
            //    a[i].inTT();

            //}

            //for (int i = 1; i <= n; i++)
            //{
            //    if (a[i].tienTaiKhoan > 200)
            //    {
            //        a[i].inTT();
            //    }

            //}
            //TeamLeader ld = new TeamLeader();
            //ld.inTT();
        }
    }
}

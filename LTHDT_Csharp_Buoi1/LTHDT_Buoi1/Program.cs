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
            PhanSo ps1 = new PhanSo(1,4);
            PhanSo ps2 = new PhanSo(1,4);
            // PhanSo ps3 = ps1.Tong(ps2);
            PhanSo ps3 = ps1.Thuong(ps2);
            //ps3.NghichDao();
            ps3.In();
        }
    }
}

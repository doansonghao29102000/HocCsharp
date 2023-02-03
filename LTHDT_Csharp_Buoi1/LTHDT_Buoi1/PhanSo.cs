using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_Buoi1
{
    internal class PhanSo
    {
        static int UCLN(int a, int b)
        {
            int n = Math.Abs(a);
            int m = Math.Abs(b);
            while (n != m)
            {
                if (n > m) n = n - m;
                else m = m - n;
            }
            return n;
        }
        private int TuSo { get; set; }
        private int MauSo { get; set; }
        public PhanSo() 
        {
            TuSo = 0;
            MauSo = 0;
        }

        public PhanSo(int tuSo, int maSo)
        {
            TuSo = tuSo;
            MauSo = maSo;
        }
        ~PhanSo() { }   
        public void Nhap()
        {
            Console.Write("Nhập tử số : ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số : ");
            MauSo= int.Parse(Console.ReadLine());
        }
        public void In()
        {
            if (MauSo == 0)
            {
                Console.WriteLine("Phân số không tồn tại!");
            }
            else if (TuSo % MauSo == 0)
            {
                Console.WriteLine("{0}", TuSo / MauSo);
            }
            else if (MauSo < 0)
            {
                Console.WriteLine("{0}/{1}", (-1) * TuSo, (-1) * MauSo);
            }
            else
            {
                Console.WriteLine("{0}/{1}", TuSo, MauSo);
            }
        }
        public PhanSo Tong(PhanSo PS2)
        {
            PhanSo PS = new PhanSo();
            PS.TuSo = TuSo*PS2.MauSo + MauSo*PS2.TuSo;
            PS.MauSo = MauSo * PS2.MauSo;
            return PS;
        }
        public PhanSo Hieu(PhanSo PS2)
        {
            PhanSo PS = new PhanSo();
            PS.TuSo = TuSo * PS2.MauSo - MauSo * PS2.TuSo;
            PS.MauSo = MauSo * PS2.MauSo;
            return PS;
        }

        public PhanSo Tich(PhanSo PS2)
        {
            PhanSo PS = new PhanSo();
            PS.TuSo = TuSo * PS2.TuSo;
            PS.MauSo = MauSo * PS2.MauSo;
            return PS;
        }

        public PhanSo Thuong(PhanSo PS2)
        {
            PhanSo PS = new PhanSo();
            PS.TuSo = TuSo * PS2.MauSo;
            PS.MauSo = MauSo * PS2.TuSo;
            return PS;
        }
        public void RutGon()
        {
            if(TuSo != 0 && MauSo != 0)
            {
                int UocCLN = UCLN(TuSo, MauSo);
                TuSo = TuSo / UocCLN;
                MauSo = MauSo / UocCLN;
            }

        }
        public void NghichDao()
        {
            int x = TuSo;
            int y = MauSo;
            TuSo = y;
            MauSo = x;
        }

    }
}

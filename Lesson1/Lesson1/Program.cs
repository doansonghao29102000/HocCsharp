using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Bai1()
        {
            Console.WriteLine("Đoàn Sông Hào");
        }
        static void Bai2()
        {
            int a, b;
            Console.Write("Nhập a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / b);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai2();
        }
    }
}

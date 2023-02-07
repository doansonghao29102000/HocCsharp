using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_Buoi1
{
    internal class SinhVien
    {
        #region attribute
        //Khai báo thuộc tính sinh viên
        public string maSV { get; set; }

        //private maSV
        //public string MSV
        //{
        //    get { return maSV; }     ==  public string maSV { get; set; } 
        //    set { maSV = value; }
        //}
        // ==
        //public string getMSV()
        //{
        //    return maSV;
        //}
        //public void setMSV(string maSV)
        //{
        //    this.maSV = maSV;
        //}
        public string tenSV { get; set; }
        public float dtb { get; set; }

        #endregion

        #region constructor
        //Hàm khởi tạo không có tham số
        public SinhVien()
        {
            maSV = "000";
            tenSV = "no name";
            dtb = 0.0f;
        }
        //Hàm khởi tạo có tham số
        public SinhVien(string maSV, string tenSV, float dtb)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.dtb = dtb;
        }

        #endregion

        #region desconstructor
        //Hàm hủy
        ~SinhVien  () { }
        //Hàm nhập thông tin sinh viên

        #endregion

        #region nhap
        public void Nhap()
        {
            Console.Write("Nhập mã sinh viên : ");
            maSV = Console.ReadLine();
            Console.Write("Nhập họ tên sinh viên : ");
            tenSV = Console.ReadLine();
            Console.Write("Nhập điểm trung bình : ");
            dtb = float.Parse(Console.ReadLine());

        }

        #endregion

        #region service method phương thức hiện thị cho người dùng
        //Hàm hiển thị thông tin sinh viên
        public void HienThi()
        {
            Console.WriteLine("{0}   {1}   {2}", maSV, tenSV, dtb);
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return this.maSV + "/" + this.tenSV + "/" + this.dtb;
        }

        #endregion

        #region support method phương thức ẩn
        private bool CheckDiem()
        {
            return (this.dtb > 8);
        }
        #endregion

        #region overloading method
        public int Tong(int x, int y)
        {
            return x + y;
        }

        public int Tong(int x, int y , int z)
        {
            return x + y + z;
        }

        public float Tong(float x, float y , float z)
        {
            return x + y + z;
        }
        #endregion

        #region parametter list method 
        // k nắm rõ tham số chuyền vào
        public float TBgpa(params float[] array)
        {
            float s = 0;
            foreach(float f in array)
            {
                s += f;
            }
            return s / array.Length;
        }
        #endregion


    }
}

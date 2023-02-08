using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Developer
    {
        private string hoTen;
        private int tuoi;

        //public string HoTen { get => hoTen; set => hoTen = value; }
        //public int Tuoi { get => tuoi; set => tuoi = value; }
        public string HoTen
        {
            get
            {
                return hoTen;
            }
            set
            {
                hoTen = value;
            }
        }

        public int Tuoi
        {
            get
            {
                return tuoi;
            }
            set
            {
                tuoi = value;
            }
        }
        //public string getHoTen() 
        //{
        //    return hoTen; 
        //}
        //public void setHoTen(string hT)
        //{   
        //    hoTen = hT;
        //}

        //public int getTuoi()
        //{
        //    return tuoi;
        //}

        //public void setTuoi(int T)
        //{
        //    tuoi = T;
        //}
    }
}

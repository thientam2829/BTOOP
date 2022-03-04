using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU4
{
    public class Vehicle
    {
        private int  dungTich;
        private double triGia;
        private String chuXe, maXe;

        public Vehicle(String chuXe, String maXe, int dungTich, double triGia)
        {
            this.maXe = maXe;
            this.dungTich = dungTich;
            this.triGia = triGia;
            this.chuXe = chuXe;
            
        }
        public Vehicle()
        {

        }
        public String getMaXe()
        {
            return maXe;
        }

        public void setMaXe(String maXe)
        {
            this.maXe = maXe;
        }

        public int getDungTich()
        {
            return dungTich;
        }

        public void setDungTich(int dungTich)
        {
            this.dungTich = dungTich;
        }

        public double getTriGia()
        {
            return triGia;
        }

        public void setTriGia(double triGia)
        {
            this.triGia = triGia;
        }

        public String getChuXe()
        {
            return chuXe;
        }

        public void setChuXe(String chuXe)
        {
            this.chuXe = chuXe;
        }


        public double Thue()
        {
            double thue;
            if (dungTich < 100) thue = triGia * 0.01;
            else if (dungTich >= 100 && dungTich <= 200) thue = triGia * 0.03;
            else thue = triGia * 0.05;
            return thue;
        }
        public String ToString()
        {
             
            return string.Format("{0,-20} {1,-10} {2,10} {3,15} {4,15}", chuXe, maXe, dungTich, triGia, Thue());
        }
    

        public void NHAP()
        {
            Console.WriteLine("NHAP TEN CHU XE ");
            chuXe = Console.ReadLine();
            Console.WriteLine("NHAP LOAI XE ");
            maXe = Console.ReadLine();
            Console.WriteLine("NHAP DUNG TICH ");
            dungTich = Int32.Parse(Console.ReadLine());
            Console.WriteLine("NHAP TRI GIA");
            triGia = Double.Parse(Console.ReadLine());

        }
    }
}


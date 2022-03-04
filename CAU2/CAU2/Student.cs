using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU2
{
    public class Student
    {
        private int maSV;
        private string hoTen;
        private double diemLT;
        private double diemTH;

        public int getmaSV()
        {
            return maSV;
        }
        public void setmaSV(int maSV)
        {
            this.maSV = maSV;
        }
        public string gethoTen()
        {
            return hoTen;
        }
        public void sethoTen()
        {
            this.hoTen = hoTen;
        }
        public double getdiemLT()
        {
            return diemLT;
        }
        public void setdiemLT()
        {
            if (diemLT < 0.0 || diemLT > 10.0)
            {
                this.diemLT = 0;
            }

            else this.diemLT = diemLT;
        }
        public double getdiemTH()
        {
            return diemTH;
        }
        public void setdiemTH()
        {
            if (diemTH < 0.0 || diemTH > 10.0)
            {
                this.diemTH = 0;
            }

            else this.diemTH = diemTH;
        }

        public double DiemTB
        {
            get { return (diemLT + diemTH) / 2; }
        }

        public override string ToString()
        {
            return string.Format("{0,-10} {1,-25} {2,-15:N0} {3,-15:N0} {4:N0}", maSV, hoTen, diemLT, diemTH, DiemTB);
        }

        public Student()
        {

        }
        public Student(int a, string b, double c, double d)
        {
            maSV = a;
            hoTen = b;
            diemLT = c;
            diemTH = d;
        }
        public void NHAP()
        {
            Console.WriteLine("NHAP MA SO SINH VIEN ");
            maSV = Int16.Parse(Console.ReadLine());
            Console.WriteLine("NHAP HO TEN SINH VIEN ");
            hoTen = Console.ReadLine();
            Console.WriteLine("NHAP DIEM THUC HANH");
            diemTH = double.Parse(Console.ReadLine());
            Console.WriteLine("NHAP DIEM LY THUYET ");
            diemLT = double.Parse(Console.ReadLine());

        }

           




    }

}

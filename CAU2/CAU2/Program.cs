// See https://aka.ms/new-console-template for more information
using System;
namespace CAU2 
{
    class Program
    {
        static void Main()
        {
            Student sv1 = new Student(1, "NGUYEN THIEN TAM", 8.0, 7);
            Student sv2 = new Student(2, "LE THI KIM NGAN", 9, 8);
            Student sv3 = new Student();
            sv3.NHAP();
            Console.WriteLine("MSSV        HO TEN           DIEM THUC HANH      DIEM LY THUYET     DIEM TRUNG BINH");
            Console.WriteLine(sv1.ToString());
            Console.WriteLine(sv2.ToString());
            Console.WriteLine(sv3.ToString());
        }

    }
    
}

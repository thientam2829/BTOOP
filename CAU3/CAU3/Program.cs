using System;
namespace CAU3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TamGiac TG1 = new TamGiac(1,3,4);
            TG1.setloaitamgiac();
            TamGiac TG2 = new TamGiac(8, 8, 8);
            TG2.setloaitamgiac();
            TamGiac TG3 = new TamGiac(6, 8, 10);
            TG3.setloaitamgiac();
            TamGiac TG4 = new TamGiac(2, 2, 4);
            TG4.setloaitamgiac();
            TamGiac TG5 = new TamGiac(5, 9, 12);
            TG5.setloaitamgiac();

            Console.WriteLine("CANH A   CANH B   CANH C     LOAI TAM GIAC                         CHU VI                    DIEN TICH");
            Console.WriteLine(TG1.ToString());
            Console.WriteLine(TG2.ToString());
            Console.WriteLine(TG3.ToString());
            Console.WriteLine(TG4.ToString());
            Console.WriteLine(TG5.ToString());
        }
    }
}

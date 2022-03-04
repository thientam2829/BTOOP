using System;

namespace CAU4
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Vehicle xe1 = new Vehicle("NGUYEN THU LOAN","Future Neo",100,35000000);
            Vehicle xe2 = new Vehicle("LE MINH TINH ","Ford Ranger",3000,250000000);
            Vehicle xe3 = new Vehicle();
            xe3.NHAP();

            Console.WriteLine("CHU XE              LOAI XE          DUNG TICH      TRI GIA         THUE ");
            Console.WriteLine("===========================================================================================");
            Console.WriteLine(xe1.ToString());
            Console.WriteLine(xe2.ToString());
            Console.WriteLine(xe3.ToString());
        }
    }


}

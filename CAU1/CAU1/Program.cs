using System;
namespace CAU1
{
    public class Program
    {
        public static void Main()
        {
            ToaDo Td1 = new ToaDo(1,2,"X");
            Console.WriteLine(Td1.ToString());
            ToaDo Td2 = new ToaDo(25,3,"Z");
            Console.WriteLine(Td2.ToString());
            
        }
    }
}
